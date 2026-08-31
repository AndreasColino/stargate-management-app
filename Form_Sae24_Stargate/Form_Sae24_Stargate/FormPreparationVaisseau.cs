using System;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;
using UserControlPlaqueMilitaire;

namespace Form_Sae24_Stargate
{
    public partial class FormPreparationVaisseau : Form
    {
        private string m_matriculeSelectionne = null;
        private string m_planeteSelectionnee;
        private string m_dateD;
        private string m_dateR;
        Form m_formParent;

        public FormPreparationVaisseau(Form formParent = null)
        {
            InitializeComponent();
            m_formParent = formParent;
            m_planeteSelectionnee = SessionMission.PlaneteSelectionnee;
            m_dateD = SessionMission.DateDepart;
            m_dateR = SessionMission.DateRetour;
            btnRetour.afficheur = btnRetour_Click;
            btnContinuer.afficheur = btnContinuer_Click;
            btnHome.afficheur = btnHome_Click;
        }

        private void FormPreparationVaisseau_Load(object sender, EventArgs e)
        {
            DateTime dateDepart = DateTime.Parse(m_dateD);
            DateTime dateRetour = DateTime.Parse(m_dateR);
            lblPlanet.Text = "MISSION SUR LA PLANÈTE : " + m_planeteSelectionnee.ToUpper() +
                             $"\nDÉPART : {dateDepart:dd/MM/yyyy}  —  ARRIVÉE : {dateRetour:dd/MM/yyyy}";
            lblPlanet.Font = FontHelper.GetOrbitron(16);
            label1.Font = FontHelper.GetOrbitron(16);
            label1.Text = "✦  CHOISISSEZ LE CHEF DE MISSION  ✦";
            ChargerEquipageDisponible();
        }


        private void ChargerEquipageDisponible()
        {
            flpEquipage.Controls.Clear();

            string requete = $@"
                SELECT M.matricule, M.nom, M.prenom, Mi.grade
                FROM Membre M
                JOIN Militaire Mi ON M.matricule = Mi.matriculeMembre
                WHERE M.matricule NOT IN (
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
                        string nom = reader["nom"].ToString().ToUpper();
                        string prenom = reader["prenom"].ToString();
                        string grade = reader["grade"].ToString();

                        UCPlaqueMilitaire plaque = new UCPlaqueMilitaire();
                        plaque.NomMembre = nom;
                        plaque.PrenomMembre = prenom;
                        plaque.GradeMembre = grade;       
                        plaque.Tag = matricule;   
                        plaque.afficheur = ClicSurMembre;
                        flpEquipage.Controls.Add(plaque);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement : " + ex.Message);
            }
        }


        private void ClicSurMembre(object sender, EventArgs e)
        {
            UCPlaqueMilitaire plaqueCliquee;
            if (sender is UCPlaqueMilitaire)
                plaqueCliquee = (UCPlaqueMilitaire)sender;
            else
                plaqueCliquee = (UCPlaqueMilitaire)((Control)sender).Parent;

            foreach (Control ctrl in flpEquipage.Controls)
                if (ctrl is UCPlaqueMilitaire)
                    ctrl.BackColor = Color.Transparent;

            plaqueCliquee.BackColor = Color.LightGreen;
            btnContinuer.PasserEnVert();

            if (plaqueCliquee.Tag != null)
            {
                m_matriculeSelectionne = plaqueCliquee.Tag.ToString();
            }
            else
            {
                m_matriculeSelectionne = plaqueCliquee.GradeMembre;
            }
        }


        private void btnContinuer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(m_matriculeSelectionne))
            {
                btnContinuer.DeclencherErreur();
                return;
            }
            SessionMission.MatriculeChef = m_matriculeSelectionne;
            FormParametreMission frmSuivant = new FormParametreMission(this);
            this.Hide();
            frmSuivant.ShowDialog();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            if (m_formParent != null)
                m_formParent.Show();
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            FormAccueil frmSuivant = new FormAccueil();
            frmSuivant.Show();
            this.Close();
        }
    }
}