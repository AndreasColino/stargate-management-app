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
    public partial class FormParametreMission : Form
    {
        private string m_planeteSelectionnee;
        private string m_dateD;
        private string m_dateR;
        private string m_matriculeChef;
        Form m_formParent;
        private Dictionary<int, (string Nom, int Objectif)> m_objectifsCaptures = new Dictionary<int, (string, int)>();

        public FormParametreMission(Form formParent = null)
        {
            InitializeComponent();
            m_formParent = formParent;
            m_planeteSelectionnee = SessionMission.PlaneteSelectionnee;
            m_dateD = SessionMission.DateDepart;
            m_dateR = SessionMission.DateRetour;
            m_matriculeChef = SessionMission.MatriculeChef;

            DateTime dateDepart = DateTime.Parse(m_dateD);
            DateTime dateRetour = DateTime.Parse(m_dateR);

            string nomCompletChef = m_matriculeChef;

            if (MesDatas.DsGlobal.Tables.Contains("Membre"))
            {
                DataRow[] rChef = MesDatas.DsGlobal.Tables["Membre"].Select($"matricule = '{m_matriculeChef}'");
                if (rChef.Length > 0)
                {
                    nomCompletChef = rChef[0]["nom"].ToString().ToUpper() + " " + rChef[0]["prenom"].ToString();
                }
            }

            lblPlanet.Font = FontHelper.GetOrbitron(16);
            lblPlanet.Text = $"MISSION SUR LA PLANÈTE : {m_planeteSelectionnee.ToUpper()}\n" +
                             $"DU {dateDepart:dd/MM/yyyy} AU {dateRetour:dd/MM/yyyy}\n" +
                             $"DIRIGÉE PAR : {nomCompletChef}";

            label1.Font = FontHelper.GetOrbitron(20);
            label1.Text = "✦  SÉLECTIONNEZ LES PARAMÈTRES  ✦";
            txtFeuilleRoute.Font = FontHelper.GetOrbitron(12);
            grp.Text = "✦  FEUILLE DE ROUTE  ✦";
            grp.Font = FontHelper.GetOrbitron(16);
            grbCaptures.Font = FontHelper.GetOrbitron(16);

            btnRetour.afficheur = btnRetour_Click;
            btnContinuer.afficheur = btnContinuer_Click;
            btnHome.afficheur = btnHome_Click;
        }

        private void FormParametreMission_Load(object sender, EventArgs e)
        {
            ChargerEspecesEnnemies();
            btnContinuer.PasserEnVert();
        }

        private void ChargerEspecesEnnemies()
        {
            cmbEspeces.Items.Clear();

            if (!MesDatas.DsGlobal.Tables.Contains("Espece") ||
                !MesDatas.DsGlobal.Tables.Contains("Ennemi") ||
                !MesDatas.DsGlobal.Tables.Contains("Habiter"))
            {
                return;
            }

            DataRow[] especesSurPlanete = MesDatas.DsGlobal.Tables["Habiter"].Select($"nomPlanete = '{m_planeteSelectionnee}'");

            foreach (DataRow rHabiter in especesSurPlanete)
            {
                int idEspece = Convert.ToInt32(rHabiter["idEspece"]);

                DataRow[] rEnnemi = MesDatas.DsGlobal.Tables["Ennemi"].Select($"idEspece = {idEspece}");

                if (rEnnemi.Length > 0)
                {
                    DataRow[] rEspece = MesDatas.DsGlobal.Tables["Espece"].Select($"id = {idEspece}");
                    if (rEspece.Length > 0)
                    {
                        string nom = rEspece[0]["nom"].ToString();
                        string couleur = rEspece[0]["couleur"].ToString();
                        cmbEspeces.Items.Add(new EspeceItem(idEspece, $"{nom} - {couleur}"));
                    }
                }
            }

            if (cmbEspeces.Items.Count > 0)
            {
                cmbEspeces.SelectedIndex = 0;
                cmbEspeces.Enabled = true;
                btnAjouterCapture.Enabled = true;
                nudObjectifCapture.Enabled = true;
            }
            else
            {
                cmbEspeces.Enabled = false;
                btnAjouterCapture.Enabled = false;
                nudObjectifCapture.Enabled = false;
                cmbEspeces.Text = "Aucun ennemi sur cette planète";
            }
        }

        private void btnAjouterCapture_Click(object sender, EventArgs e)
        {
            if (cmbEspeces.SelectedItem == null)
            {
                return;
            }

            EspeceItem espece = (EspeceItem)cmbEspeces.SelectedItem;
            int objectif = (int)nudObjectifCapture.Value;

            if (objectif <= 0)
            {
                MessageBox.Show("L'objectif de capture doit être supérieur à 0.",
                    "Valeur invalide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            m_objectifsCaptures[espece.Id] = (espece.Nom, objectif);
            RafraichirListeObjectifs();
        }

        private void btnSupprimerCapture_Click(object sender, EventArgs e)
        {
            if (lstObjectifsCaptures.SelectedItem == null)
            {
                return;
            }

            ObjectifItem item = (ObjectifItem)lstObjectifsCaptures.SelectedItem;
            m_objectifsCaptures.Remove(item.IdEspece);
            RafraichirListeObjectifs();
        }

        private void RafraichirListeObjectifs()
        {
            lstObjectifsCaptures.Items.Clear();
            foreach (var kvp in m_objectifsCaptures)
            {
                lstObjectifsCaptures.Items.Add(new ObjectifItem(kvp.Key, kvp.Value.Nom, kvp.Value.Objectif));
            }
        }

        private void btnContinuer_Click(object sender, EventArgs e)
        {
            SessionMission.NbMembresTotal = Convert.ToInt32(ucBoutonIncrementer1.Valeur);
            SessionMission.Budget = Convert.ToInt32(ucBoutonIncrementer3.Valeur);
            SessionMission.ObjectifDataBaz = Convert.ToInt32(ucBoutonIncrementer2.Valeur);
            SessionMission.FeuilleRoute = txtFeuilleRoute.Text;

            SessionMission.ObjectifsCaptures = new List<(int IdEspece, int Objectif)>();

            foreach (var kvp in m_objectifsCaptures)
            {
                SessionMission.ObjectifsCaptures.Add((kvp.Key, kvp.Value.Objectif));
            }

            FromTrombino frmSuivant = new FromTrombino(this);
            this.Hide();
            frmSuivant.ShowDialog();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            if (m_formParent != null)
            {
                m_formParent.Show();
            }
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            FormAccueil frmSuivant = new FormAccueil();
            frmSuivant.Show(this);
            this.Close();
        }

        private void lblCapture_Click(object sender, EventArgs e)
        {
        }
    }

    public class EspeceItem
    {
        public int Id { get; }
        public string Nom { get; }

        public EspeceItem(int id, string nom)
        {
            Id = id;
            Nom = nom;
        }

        public override string ToString()
        {
            return Nom;
        }
    }

    public class ObjectifItem
    {
        public int IdEspece { get; }
        public string Nom { get; }
        public int Objectif { get; }

        public ObjectifItem(int id, string nom, int objectif)
        {
            IdEspece = id;
            Nom = nom;
            Objectif = objectif;
        }

        public override string ToString()
        {
            return $"{Nom}  -->  objectif de captures : {Objectif}";
        }
    }
}