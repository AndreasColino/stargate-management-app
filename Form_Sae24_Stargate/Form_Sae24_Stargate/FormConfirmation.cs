using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Sae24_Stargate
{
    public partial class FormConfirmation : Form
    {
        Form m_formParent;

        public FormConfirmation(Form formParent = null)
        {
            InitializeComponent();
            m_formParent = formParent;
        }

        private void FormConfirmation_Load(object sender, EventArgs e)
        {
            DateTime dateD = DateTime.Parse(SessionMission.DateDepart);
            DateTime dateR = DateTime.Parse(SessionMission.DateRetour);
            lblRecapDates.Text = $"Du {dateD:dd/MM/yyyy} au {dateR:dd/MM/yyyy}";
            lblRecapPlanete.Text = "Planète : " + SessionMission.PlaneteSelectionnee;
            lblRecapBudget.Text = "Budget : " + SessionMission.Budget.ToString("N0") + " $";
            lblRecapDataBaz.Text = "Objectif DataBaz : " + SessionMission.ObjectifDataBaz;

            string nomChef = ResolveNomPrenom(SessionMission.MatriculeChef);
            lblRecapChef.Text = "Chef de mission : " + nomChef;

            lstRecapEquipe.Items.Clear();
            string posteChef = ResolvePoste(SessionMission.MatriculeChef);
            lstRecapEquipe.Items.Add($"[CHEF] {nomChef} : {posteChef} ({SessionMission.MatriculeChef})");

            foreach (string matricule in SessionMission.MembresSelectionnes)
            {
                string nomPrenom = ResolveNomPrenom(matricule);
                string poste = ResolvePoste(matricule);
                lstRecapEquipe.Items.Add($"{nomPrenom} : {poste} ({matricule})");
            }

            lstRecapCaptures.Items.Clear();
            if (SessionMission.ObjectifsCaptures.Count == 0)
            {
                lstRecapCaptures.Items.Add("Aucun objectif de capture défini.");
            }
            else
            {
                foreach (var obj in SessionMission.ObjectifsCaptures)
                {
                    string nomEspece = ResolveNomEspece(obj.IdEspece);
                    lstRecapCaptures.Items.Add($"{nomEspece}  -->  objectif de captures : {obj.Objectif}");
                }
            }
        }

        private string ResolveNomPrenom(string matricule)
        {
            if (string.IsNullOrEmpty(matricule)) return "Inconnu";
            if (!MesDatas.DsGlobal.Tables.Contains("Membre")) return matricule;

            DataRow[] rows = MesDatas.DsGlobal.Tables["Membre"].Select($"matricule = '{matricule}'");
            if (rows.Length > 0)
                return rows[0]["nom"].ToString().ToUpper() + " " + rows[0]["prenom"].ToString();

            return matricule;
        }

        private string ResolveNomEspece(int idEspece)
        {
            if (!MesDatas.DsGlobal.Tables.Contains("Espece")) return idEspece.ToString();
            DataRow[] rows = MesDatas.DsGlobal.Tables["Espece"].Select($"id = {idEspece}");
            if (rows.Length > 0)
                return rows[0]["nom"].ToString();
            return idEspece.ToString();
        }

        private string ResolvePoste(string matricule)
        {
            if (string.IsNullOrEmpty(matricule)) return "Inconnu";

            if (MesDatas.DsGlobal.Tables.Contains("Militaire"))
            {
                DataRow[] rMil = MesDatas.DsGlobal.Tables["Militaire"].Select($"matriculeMembre = '{matricule}'");
                if (rMil.Length > 0) return rMil[0]["grade"].ToString();
            }

            if (MesDatas.DsGlobal.Tables.Contains("Civil"))
            {
                DataRow[] rCiv = MesDatas.DsGlobal.Tables["Civil"].Select($"matriculeMembre = '{matricule}'");
                if (rCiv.Length > 0) return rCiv[0]["Specialite"].ToString();
            }

            return "Inconnu";
        }

        private int ProchainNumeroMission(string nomPlanete)
        {
            string req = $"SELECT COALESCE(MAX(numero), 0) + 1 FROM Mission WHERE nomPlanete = '{nomPlanete}'";
            using (SQLiteCommand cmd = new SQLiteCommand(req, Connexion.Connec))
            {
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        private void InsererMission()
        {
            string planete = SessionMission.PlaneteSelectionnee;
            string dateD = SessionMission.DateDepart;
            string dateR = SessionMission.DateRetour;
            string chef = SessionMission.MatriculeChef;
            string feuille = SessionMission.FeuilleRoute ?? "";
            int nbMembres = SessionMission.NbMembresTotal;
            int databaz = SessionMission.ObjectifDataBaz;
            int budget = SessionMission.Budget;

            int numero = ProchainNumeroMission(planete);

            using (SQLiteTransaction transaction = Connexion.Connec.BeginTransaction())
            {
                try
                {
                    string reqMission = $@"
                        INSERT INTO Mission
                            (nomPlanete, numero, nbMembreRequis, dateDepart, dateRetour,
                             matriculeChef, feuilleDeRoute, objectifDatabaz, budget)
                        VALUES
                            ('{planete}', {numero}, {nbMembres}, '{dateD}', '{dateR}',
                             '{chef}', '{feuille.Replace("'", "''")}', {databaz}, {budget})";

                    using (SQLiteCommand cmd = new SQLiteCommand(reqMission, Connexion.Connec, transaction))
                        cmd.ExecuteNonQuery();

                    List<string> tousLesMembres = new List<string> { chef };
                    tousLesMembres.AddRange(SessionMission.MembresSelectionnes);

                    foreach (string matricule in tousLesMembres)
                    {
                        string reqComposer = $@"
                            INSERT INTO Composer (nomPlanete, numeroMission, matriculeMembre)
                            VALUES ('{planete}', {numero}, '{matricule}')";

                        using (SQLiteCommand cmd = new SQLiteCommand(reqComposer, Connexion.Connec, transaction))
                            cmd.ExecuteNonQuery();
                    }

                    foreach (var obj in SessionMission.ObjectifsCaptures)
                    {
                        string reqCapture = $@"
                            INSERT INTO ObjectifCapture (nomPlanete, numeroMission, idEspeceEnnemi, objectif)
                            VALUES ('{planete}', {numero}, {obj.IdEspece}, {obj.Objectif})";

                        using (SQLiteCommand cmd = new SQLiteCommand(reqCapture, Connexion.Connec, transaction))
                            cmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    _nomMissionCreee = $"{planete}-{numero}";
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new Exception("Erreur lors de l'insertion en base : " + ex.Message, ex);
                }
            }
        }

        private string _nomMissionCreee = "";

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            if (m_formParent != null)
                m_formParent.Show();
            this.Close();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            try
            {
                InsererMission();

                MessageBox.Show(
                    $"Mission {_nomMissionCreee} créée avec succès !",
                    "Confirmation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                SessionMission.Reinitialiser();

                FormAccueil frmAccueil = new FormAccueil();
                frmAccueil.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Erreur lors de la création de la mission",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}