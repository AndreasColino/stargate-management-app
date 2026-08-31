using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;
using UserControlMembreEquipageDetail;
using UCTrombinoEquipage = UserControlMembreEquipage.UCTrombinoEquipage;

namespace Form_Sae24_Stargate
{
    public partial class FromTrombino : Form
    {
        private int m_limiteSelection;
        private string m_matriculeChef;
        private List<string> m_membresSelectionnes = new List<string>();
        private string m_planete;
        private string m_dateD;
        private string m_dateR;
        private int m_budget;
        private int m_objectifDataBaz;
        private string m_feuilleRoute;

        Form m_formParent;

        public FromTrombino(Form formParent = null)
        {
            InitializeComponent();
            m_formParent = formParent;
            m_planete = SessionMission.PlaneteSelectionnee;
            m_dateD = SessionMission.DateDepart;
            m_dateR = SessionMission.DateRetour;
            m_matriculeChef = SessionMission.MatriculeChef;
            m_budget = SessionMission.Budget;
            m_objectifDataBaz = SessionMission.ObjectifDataBaz;
            m_feuilleRoute = SessionMission.FeuilleRoute;
            m_limiteSelection = SessionMission.NbMembresTotal - 1;
            btnRetour.afficheur = btnRetour_Click;
            btnContinuer.afficheur = btnContinuer_Click;
            btnHome.afficheur = btnHome_Click;
            btnContinuer.Enabled = (m_limiteSelection == 0);
        }

        private void FromTrombino_Load(object sender, EventArgs e)
        {
            lblTitre.Font = FontHelper.GetOrbitron(16);
            if (m_limiteSelection == 0)
                lblTitre.Text = "Aucun membre supplémentaire requis pour cette mission.";
            else
                lblTitre.Text = $"Sélectionnez {m_limiteSelection} membre(s) d'équipage :";

            if (SessionMission.MembresSelectionnes != null && SessionMission.MembresSelectionnes.Count > 0)
                m_membresSelectionnes = new List<string>(SessionMission.MembresSelectionnes);
            ChargerEquipage();

            btnContinuer.Enabled = (m_membresSelectionnes.Count == m_limiteSelection) || (m_limiteSelection == 0);
        }

        private void ChargerEquipage()
        {
            flpEquipage.Controls.Clear();

            string requete = $@"
                SELECT M.matricule, M.nom, M.prenom
                FROM Membre M
                WHERE M.matricule != '{m_matriculeChef}'
                AND M.matricule NOT IN (
                    SELECT C.matriculeMembre
                    FROM Composer C
                    JOIN Mission Miss ON C.nomPlanete = Miss.nomPlanete AND C.numeroMission = Miss.numero
                    WHERE Miss.dateDepart <= '{m_dateR}' AND Miss.dateRetour >= '{m_dateD}'
                )
                AND M.matricule NOT IN (
                    SELECT Miss.matriculeChef
                    FROM Mission Miss
                    WHERE Miss.dateDepart <= '{m_dateR}' AND Miss.dateRetour >= '{m_dateD}'
                    AND Miss.matriculeChef IS NOT NULL
                )";

            try
            {
                using (SQLiteCommand cmd = new SQLiteCommand(requete, Connexion.Connec))
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string matricule = reader["matricule"].ToString();
                        string nomPrenom = reader["nom"].ToString().ToUpper() + " " + reader["prenom"].ToString();

                        UCTrombinoEquipage membre = new UCTrombinoEquipage();
                        membre.MatriculeMembre = matricule;
                        membre.NomPrenom = nomPrenom;
                        membre.afficheur = ClickSurLeBoutonInfo;
                        membre.selectionneur = ClickSurLaVignette;

                        if (m_membresSelectionnes.Contains(matricule))
                            membre.BackColor = Color.LightGreen;

                        flpEquipage.Controls.Add(membre);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement : " + ex.Message);
            }
        }

        private void ClickSurLaVignette(object sender, EventArgs e)
        {

            if (m_limiteSelection == 0) return;

            UCTrombinoEquipage membreClique;
            if (sender is UCTrombinoEquipage)
                membreClique = (UCTrombinoEquipage)sender;
            else
                membreClique = (UCTrombinoEquipage)((Control)sender).Parent;

            string matricule = membreClique.MatriculeMembre;

            if (m_membresSelectionnes.Contains(matricule))
            {
                m_membresSelectionnes.Remove(matricule);
                membreClique.BackColor = Color.Transparent;
            }
            else
            {
                if (m_membresSelectionnes.Count < m_limiteSelection)
                {
                    m_membresSelectionnes.Add(matricule);
                    membreClique.BackColor = Color.LightGreen;
                }
                else
                {
                    MessageBox.Show(
                        $"Vous avez déjà atteint la limite de {m_limiteSelection} membre(s) ! Désélectionnez-en un pour changer.",
                        "Équipe complète",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }

            btnContinuer.Enabled = (m_membresSelectionnes.Count == m_limiteSelection);
        }

        private void ClickSurLeBoutonInfo(object sender, EventArgs e)
        {
            
        }

        private void btnContinuer_Click(object sender, EventArgs e)
        {
            if (m_membresSelectionnes.Count < m_limiteSelection)
            {
                btnContinuer.DeclencherErreur();
                return;
            }
            else
            {
                btnContinuer.PasserEnVert();
            }

            SessionMission.MembresSelectionnes = m_membresSelectionnes;
            FormConfirmation frmSuivant = new FormConfirmation(this);
            this.Hide();
            frmSuivant.ShowDialog();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            FormAccueil frmSuivant = new FormAccueil();
            frmSuivant.Show();
            this.Close();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {

            SessionMission.MembresSelectionnes.Clear();
            if (m_formParent != null)
                m_formParent.Show();
            this.Close();
        }
    }
}