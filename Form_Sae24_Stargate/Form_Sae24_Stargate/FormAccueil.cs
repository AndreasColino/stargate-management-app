using BCrypt.Net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserControlBoutonAvecImage;

namespace Form_Sae24_Stargate
{
    public partial class FormAccueil : Form
    {
        private FlowLayoutPanel flpAffichage;

        public FormAccueil()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            flpAffichage = new FlowLayoutPanel();

            // Initialisation / Vérification du compte administrateur Andreas
            try
            {
                string checkUserQuery = "SELECT COUNT(*) FROM Admin WHERE login = 'Andreas'";
                using (SQLiteCommand checkCmd = new SQLiteCommand(checkUserQuery, Connexion.Connec))
                {
                    long count = (long)checkCmd.ExecuteScalar();
                    if (count == 0)
                    {
                        string hashedPassword = BCrypt.Net.BCrypt.HashPassword("Andreas");
                        string addLogin = "INSERT INTO Admin (login, mdp) VALUES ('Andreas', @mdp)";
                        using (SQLiteCommand insertCmd = new SQLiteCommand(addLogin, Connexion.Connec))
                        {
                            insertCmd.Parameters.AddWithValue("@mdp", hashedPassword);
                            insertCmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch
            {
                // Gestion si la table Admin n'est pas encore initialisée
            }

            // Chargement dynamique des tables du schéma
            try
            {
                DataTable dtSchema = Connexion.Connec.GetSchema("Tables");
                MesDatas.DsGlobal.Clear();

                for (int i = 0; i < dtSchema.Rows.Count; i++)
                {
                    string nomTable = dtSchema.Rows[i]["TABLE_NAME"].ToString();
                    string req = "SELECT * FROM " + nomTable;
                    using (SQLiteCommand cd = new SQLiteCommand(req, Connexion.Connec))
                    using (SQLiteDataAdapter da = new SQLiteDataAdapter(cd))
                    {
                        da.Fill(MesDatas.DsGlobal, nomTable);
                    }
                }
            }
            catch
            {
                // Gestion des exceptions de chargement
            }

            // Association du délégué au bouton Nouvelle Mission
            if (btnUCNouvelleMission != null)
            {
                btnUCNouvelleMission.afficheur = clickAjouterNouvelleMission;
            }
        }

        // Événement déclenché lors du clic sur le bouton Nouvelle Mission
        private void clickAjouterNouvelleMission(object sender, EventArgs e)
        {
            FormAuthentification frmLogin = new FormAuthentification();
            if (frmLogin.ShowDialog() == DialogResult.OK)
            {
                // Ouverture du formulaire de saisie de la nouvelle mission
                FormNouvelleMission frmMission = new FormNouvelleMission();
                frmMission.ShowDialog();
            }
            else
            {
                MessageBox.Show("Échec de l'authentification", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}