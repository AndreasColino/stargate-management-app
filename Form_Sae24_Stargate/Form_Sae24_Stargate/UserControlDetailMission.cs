using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Sae24_Stargate
{
    public partial class UserControlMissionDetail : UserControl
    {
        private string planeteActuelle = "";
        private int numeroMissionActuelle = 0;
        private DataSet dataSetGlobal;
        public UserControlMissionDetail()
        {
            InitializeComponent();
        }
        public void ChargerMission(int numeroMission, string planete, DataSet monDataSet)
        {
            this.planeteActuelle = planete;
            this.numeroMissionActuelle = numeroMission;
            this.dataSetGlobal = monDataSet;

            try
            {
                string filtre = "numero = " + numeroMission + " AND nomPlanete = '" + planete + "'";
                DataRow[] lignesMission = monDataSet.Tables["Mission"].Select(filtre);

                double budgetInitial = 0;

                if (lignesMission.Length > 0)
                {
                    DataRow ligne = lignesMission[0];

                    lblNomMission.Text = "Mission n°" + numeroMission + " - " + planete.ToUpper();

                    DateTime dateDep = Convert.ToDateTime(ligne["dateDepart"]);
                    lblDateDep.Text = "Date de départ : " + dateDep.ToString("dd/MM/yyyy");

                    DateTime dateRet = Convert.ToDateTime(ligne["dateRetour"]);
                    lblRetour.Text = "Date de retour prévu : " + dateRet.ToString("dd/MM/yyyy");

                    lblDatabaz.Text = "Objectif Databaz : " + ligne["objectifDatabaz"].ToString() + " tonnes";

                    //calcul de la récolte de databaz
                    try
                    {
                        if (monDataSet.Tables.Contains("Negocier"))
                        {
                            string filtreDatabaz = "numeroMission = " + numeroMission + " AND nomPlanete = '" + planete + "'";
                            DataRow[] lignesNegociation = monDataSet.Tables["Negocier"].Select(filtreDatabaz);

                            double totalDatabazRecolte = 0;

                            //additionne les quantités négociées 
                            foreach (DataRow ligneNegoc in lignesNegociation)
                            {
                                if (ligneNegoc["qteDataBaz"] != DBNull.Value)
                                {
                                    totalDatabazRecolte += Convert.ToDouble(ligneNegoc["qteDataBaz"]);
                                }
                            }

                            lblDatabazRecolte.Text = "Databaz récolté : " + totalDatabazRecolte + " tonnes";

                            //change la couleur si l'objectif est atteint 
                            double objectif = 0;
                            if (ligne["objectifDatabaz"] != DBNull.Value)
                            {
                                objectif = Convert.ToDouble(ligne["objectifDatabaz"]);
                            }

                            if (totalDatabazRecolte >= objectif && objectif > 0)
                            {
                                lblDatabazRecolte.ForeColor = Color.SpringGreen; //vert
                            }
                            else
                            {
                                lblDatabazRecolte.ForeColor = Color.Red; //orange
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        lblDatabazRecolte.Text = "Databaz récolté : Erreur de calcul";
                    }

                    string feuilleTexte = ligne["feuilleDeRoute"].ToString();
                    feuilleTexte = feuilleTexte.Replace("\r\n", "\n").Replace("\n\n", "##PARAGRAPHE##").Replace("\n", " ").Replace("##PARAGRAPHE##", "\n\n");
                    while (feuilleTexte.Contains("  ")) { 
                        feuilleTexte = feuilleTexte.Replace("  ", " "); 
                    }

                    rtbFeuilleRoute.Text = feuilleTexte;

                    if (ligne["budget"] != DBNull.Value)
                    {
                        budgetInitial = Convert.ToDouble(ligne["budget"]);
                    }

                    lblBudget.Text = "Budget initial : " + budgetInitial.ToString("F2") + " €";
                }

                string filtreDepenses = "numeroMission = " + numeroMission + " AND nomPlanete = '" + planete + "'";
                DataRow[] lignesDepenses = monDataSet.Tables["Depense"].Select(filtreDepenses);

                double totalDepenses = 0;

                foreach (DataRow ligne in lignesDepenses)
                {
                    if (ligne["montant"] != DBNull.Value)
                        totalDepenses += Convert.ToDouble(ligne["montant"]);
                }

                double budgetRestant = budgetInitial - totalDepenses;

                if (budgetRestant < 200)
                {
                    lblSolde.ForeColor = Color.Red;
                    lblSolde.Text = "Budget restant : " + budgetRestant.ToString("F2") + " € (DÉPASSEMENT !)";
                }
                else
                {
                    lblSolde.ForeColor = Color.SpringGreen;
                    lblSolde.Text = "Budget restant : " + budgetRestant.ToString("F2") + " €";
                }
                
                //image de la planete
                string nomFichierPlanete = planete + ".png";

                //construction su chemin dynamique : "dossier_actuel/Images/Planetes/planete.png"
                string cheminImagePlanete = System.IO.Path.Combine(Application.StartupPath, "Images","Planetes", nomFichierPlanete);

                pbPlanete.SizeMode = PictureBoxSizeMode.Zoom;

                // vérifie si l'image de la planète existe 
                if (System.IO.File.Exists(cheminImagePlanete))
                {
                    pbPlanete.Image = Image.FromFile(cheminImagePlanete);
                }
                else
                {
                    pbPlanete.Image = null; 
                }

                AfficherTrombinoEquipe(numeroMission, planete, monDataSet);

                AfficherObjectifs(numeroMission, planete, monDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement (Mode Déconnecté) : " + ex.Message);
            }
        }

        // N'oublie pas d'ajouter tout en haut de ton fichier (si ce n'est pas fait) :
// using System.IO;

    private void AfficherTrombinoEquipe(int numeroMission, string planete, DataSet monDataSet)
    {
        flptrombi.Controls.Clear();

        string filtreMembres = "numeroMission = " + numeroMission + " AND nomPlanete = '" + planete + "'";
        DataRow[] lignesMembres = monDataSet.Tables["Composer"].Select(filtreMembres); 
        
        foreach (DataRow ligne in lignesMembres)
        {
            string matricule = ligne["matriculeMembre"].ToString();
            string nomComplet = "Membre inconnu";
            string metier = "Inconnu";

                if (!string.IsNullOrEmpty(matricule))
                {
                    DataRow[] infoMembre = monDataSet.Tables["Membre"].Select("matricule = '" + matricule + "'");

                    if (infoMembre.Length > 0)
                    {
                        string prenom = infoMembre[0]["prenom"].ToString();
                        string nom = infoMembre[0]["nom"].ToString();
                        nomComplet = prenom + " " + nom;
                    }
                    if (monDataSet.Tables.Contains("Civil"))
                    {
                        DataRow[] rowsCivil = monDataSet.Tables["Civil"].Select("matriculeMembre = '" + matricule + "'");
                        if (rowsCivil.Length > 0)
                        {
                            metier = rowsCivil[0]["Specialite"].ToString();
                        }
                    }
                    if (metier == "Inconnu" && monDataSet.Tables.Contains("Militaire"))
                    {
                        DataRow[] rowsMilitaire = monDataSet.Tables["Militaire"].Select("matriculeMembre = '" + matricule + "'");
                        if (rowsMilitaire.Length > 0)
                        {
                            metier = rowsMilitaire[0]["grade"].ToString();
                        }
                    }
                }

            Panel carteMembre = new Panel();
            carteMembre.Size = new Size(150, 220);
            carteMembre.Margin = new Padding(10); 
            carteMembre.BorderStyle = BorderStyle.FixedSingle;
            carteMembre.BackColor = System.Drawing.Color.RoyalBlue ;


            PictureBox picPhoto = new PictureBox();
            picPhoto.Size = new Size(130, 130);
            picPhoto.Location = new Point(10, 10);
            picPhoto.SizeMode = PictureBoxSizeMode.Zoom;
            picPhoto.BackColor = Color.Transparent;


            string nomFichierImage = matricule + ".png";

            //construction su chemin dynamique : "dossier_actuel/Images/ImageMetier/matricule.png"
            string cheminImage = System.IO.Path.Combine(Application.StartupPath, "Images", "ImageMetier", nomFichierImage);

            //vérifie si l'image existe
            if (System.IO.File.Exists(cheminImage))
            {
                picPhoto.Image = Image.FromFile(cheminImage);
            }

            Label lblNom = new Label();
            lblNom.Text = nomComplet;
            lblNom.Location = new Point(10, 145); 
            lblNom.Size = new Size(130, 40);
            lblNom.TextAlign = ContentAlignment.TopCenter; 
            lblNom.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            Label lblMetier = new Label();
            lblMetier.Text = metier;
            lblMetier.Location = new Point(10, 185);
            lblMetier.Size = new Size(130, 25);
            lblMetier.TextAlign = ContentAlignment.TopCenter;
            lblMetier.Font = new Font("Segoe UI", 10, FontStyle.Italic);

            carteMembre.Controls.Add(picPhoto);
            carteMembre.Controls.Add(lblNom);
            carteMembre.Controls.Add(lblMetier);

            flptrombi.Controls.Add(carteMembre);
        }
    }

        private void AfficherObjectifs(int numeroMission, string planete, DataSet monDataSet)
        {
            groupBox1.Controls.Clear();
            int yPos = 35;

            
            string filtreObj = "numeroMission = " + numeroMission + " AND nomPlanete = '" + planete + "'";
            DataRow[] lignesObj = monDataSet.Tables["ObjectifCapture"].Select(filtreObj);

            foreach (DataRow ligne in lignesObj)
            {

                string descriptionObjectif = ligne["objectif"].ToString();
                string idEspece = ligne["idEspeceEnnemi"].ToString();
                string nomEspece = "Espèce inconnue"; //valeur par défaut au cas où

                if (!string.IsNullOrEmpty(idEspece))
                {
                    DataRow[] lignesEspece = monDataSet.Tables["Espece"].Select("id = " + idEspece);
                    if (lignesEspece.Length > 0)
                    {
                        nomEspece = lignesEspece[0]["nom"].ToString();
                    }
                }

                Label lblObj = new Label();
                lblObj.AutoSize = true;

                lblObj.Text = "• " + nomEspece + " : " + descriptionObjectif;

                lblObj.Location = new Point(15, yPos);
                lblObj.Font = new Font("Microsoft Sans Serif", 12);

                groupBox1.Controls.Add(lblObj);
                yPos += 30;
            }
        }

        public void ActiverModeEdition(bool actif)
        {
            btnEditerMission.Visible = actif;
        }


        private void btnEditerMission_Click(object sender, EventArgs e)
        {
            try
            {
                UCEditionMission ucEdition = new UCEditionMission();
                ucEdition.ChargerPourEdition(this.numeroMissionActuelle, this.planeteActuelle, MesDatas.DsGlobal);

                //crée une fenêtre vide
                Form fenetreEdition = new Form();

                // prendre la taille exacte du user controle
                fenetreEdition.ClientSize = ucEdition.Size; 
                fenetreEdition.FormBorderStyle = FormBorderStyle.FixedDialog; //empêche de redimensionner
                fenetreEdition.StartPosition = FormStartPosition.CenterScreen; //centre à l'écran
                fenetreEdition.Text = "Édition de la Mission"; //titre de la fenêtre
               
                fenetreEdition.Controls.Add(ucEdition);
                ucEdition.Location = new Point(0, 0);

                fenetreEdition.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ouverture de la fenêtre d'édition : " + ex.Message, "Erreur");
            }
        }

        private void btnJournal_Click(object sender, EventArgs e)
        {
            try
            {
                UCJournalBord ucJournal = new UCJournalBord();
                ucJournal.ChargerJournal(this.numeroMissionActuelle, this.planeteActuelle, MesDatas.DsGlobal);

                //crée une fenêtre vide
                Form fenetreJournal = new Form();

                //prendre la taille exacte du user controle
                fenetreJournal.ClientSize = ucJournal.Size;
                fenetreJournal.FormBorderStyle = FormBorderStyle.FixedDialog; //empêche de redimensionner
                fenetreJournal.StartPosition = FormStartPosition.CenterScreen; //centre à l'écran
                fenetreJournal.Text = "Journal de bord"; //titre de la fenêtre

                fenetreJournal.Controls.Add(ucJournal);
                ucJournal.Location = new Point(0, 0);

                fenetreJournal.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ouverture du journal : " + ex.Message, "Erreur");
            }
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            Form fenetreParente = this.FindForm();
            if (fenetreParente != null)
            {
                fenetreParente.Close();
            }
        }
    }
}
