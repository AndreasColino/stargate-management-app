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
    public partial class UCEditionMission : UserControl
    {
        private int numeroEnCours;
        private string planeteEnCours;
        private DataSet dataSetGlobal;

        public UCEditionMission()
        {
            InitializeComponent();
        }

        public void ChargerPourEdition(int numero, string planete, DataSet ds)
        {
            this.numeroEnCours = numero;
            this.planeteEnCours = planete;
            this.dataSetGlobal = ds;
            try
            {

                cmbInformateur.DataSource = dataSetGlobal.Tables["Informateur"];
                cmbInformateur.DisplayMember = "nom";
                cmbInformateur.ValueMember = "nomCode";
                cmbInformateur.SelectedIndex = -1;


                //enlever le type Infomateur de la combobox
                DataView vueTypesFiltres = new DataView(dataSetGlobal.Tables["TypeDepense"]);
                vueTypesFiltres.RowFilter = "id <> 2";

                cmbTypeDepense.DataSource = vueTypesFiltres;
                cmbTypeDepense.DisplayMember = "libelle";
                cmbTypeDepense.ValueMember = "id";
                cmbTypeDepense.SelectedIndex = -1;



                cmbEspeceAlliee.DataSource = dataSetGlobal.Tables["Espece"];
                cmbEspeceAlliee.DisplayMember = "nom";
                cmbEspeceAlliee.ValueMember = "id";    
                cmbEspeceAlliee.SelectedIndex = -1;

                cmbEspece.DataSource = dataSetGlobal.Tables["Espece"];
                cmbEspece.DisplayMember = "nom";
                cmbEspece.ValueMember = "id";
                cmbEspece.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des listes déroulantes : " + ex.Message);
            }
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            try
            {
                double sommePayee = 0;

                if (cmbInformateur.SelectedValue == null)
                {
                    FormSucces.Afficher("Veuillez sélectionner un informateur.", true);
                    return;
                }

                if (!string.IsNullOrWhiteSpace(txtSomme.Text))
                {
                    sommePayee = Convert.ToDouble(txtSomme.Text);
                }
                else
                {
                    FormSucces.Afficher("Veuillez écrire une somme.", true);
                    return;
                }


                    //Table Contact
                DataTable dtContacts = dataSetGlobal.Tables["Contact"];
                DataRow nouveauContact = dtContacts.NewRow();


                nouveauContact["nomPlanete"] = this.planeteEnCours;
                nouveauContact["numeroMission"] = this.numeroEnCours;
                nouveauContact["dateC"] = dtpDateContact.Value.Date;
                nouveauContact["sommeVersee"] = sommePayee;
                nouveauContact["appreciation"] = rtxtAppreciation.Text;


                nouveauContact["nomCodeInformateur"] = cmbInformateur.SelectedValue.ToString();

                dtContacts.Rows.Add(nouveauContact);

                //Table Depense
                if (sommePayee > 0)
                {
                    DataTable dtDepenses = dataSetGlobal.Tables["Depense"];
                    DataRow nouvelleDepense = dtDepenses.NewRow();

                    nouvelleDepense["nomPlanete"] = this.planeteEnCours;
                    nouvelleDepense["numeroMission"] = this.numeroEnCours;
                    nouvelleDepense["dateD"] = dtpDateContact.Value.Date;
                    nouvelleDepense["montant"] = sommePayee;
                    nouvelleDepense["motif"] = "Paiement de l'informateur : " + cmbInformateur.Text;

                    nouvelleDepense["idTypeDepense"] = 2;

                    dtDepenses.Rows.Add(nouvelleDepense);
                }

                //barre chargement
                FormEcranChargement ecranSombre = new FormEcranChargement();
                ecranSombre.ShowDialog(this);

                ViderChampsContact();

                FormSucces.Afficher("Contact enregistré avec succès !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }


        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            ViderChampsContact();
        }

        private void btnNvContact_Click(object sender, EventArgs e)
        {
            gpbNvContact.Visible = true;
            gpbNvDepense.Visible = false;
            gpbNvEvenement.Visible = false;
            gpbEspece.Visible = false;
        }

        private void ViderChampsContact()
        {
            cmbInformateur.SelectedIndex = -1; 
            dtpDateContact.Value = DateTime.Now; 
            txtSomme.Clear();
            rtxtAppreciation.Clear();
        }

        private void btnNvDepense_Click(object sender, EventArgs e)
        {
            gpbNvDepense.Visible = true;
            gpbNvContact.Visible = false;
            gpbNvEvenement.Visible = false;
            gpbEspece.Visible = false;

        }

        private void btnValiderDepense_Click(object sender, EventArgs e)
        {
            try
            {
               
                DataTable dtDepenses = dataSetGlobal.Tables["Depense"];
                DataRow nouvelleDepense = dtDepenses.NewRow();

               
                nouvelleDepense["nomPlanete"] = this.planeteEnCours;
                nouvelleDepense["numeroMission"] = this.numeroEnCours;
                nouvelleDepense["dateD"] = dtpDateDepense.Value.Date;

                if (!string.IsNullOrWhiteSpace(txtMontantDepense.Text))
                {
                    nouvelleDepense["montant"] = Convert.ToDouble(txtMontantDepense.Text);
                }
                else
                {
                    nouvelleDepense["montant"] = 0;
                }

                nouvelleDepense["motif"] = rtxtMotifDepense.Text;

                if (cmbTypeDepense.SelectedValue != null)
                {
                    nouvelleDepense["idTypeDepense"] = Convert.ToInt32(cmbTypeDepense.SelectedValue);
                }
                else
                {
                    FormSucces.Afficher("Veuillez sélectionner un type de dépense.", true);
                    return;
                }
                dtDepenses.Rows.Add(nouvelleDepense);

                //ajout de la negociation 
                if (Convert.ToInt32(cmbTypeDepense.SelectedValue) == 1)
                {
                    DataTable dtNegocier = dataSetGlobal.Tables["Negocier"];

                    int quantiteObtenue = 0;
                    if (!string.IsNullOrWhiteSpace(txtQuantite.Text))
                    {
                        quantiteObtenue = Convert.ToInt32(txtQuantite.Text);
                    }

                    int idEspece = 0;
                    if (cmbEspeceAlliee.SelectedValue != null)
                    {
                        idEspece = Convert.ToInt32(cmbEspeceAlliee.SelectedValue);
                    }
                    else
                    {
                        FormSucces.Afficher("Veuillez sélectionner une espèce alliée.", true);
                        return; 
                    }

                    
                    string filtre = "numeroMission = " + this.numeroEnCours + " AND nomPlanete = '" + this.planeteEnCours + "' AND idEspeceAllie = " + idEspece;

                    DataRow[] negoExistante = dtNegocier.Select(filtre);

                    if (negoExistante.Length > 0)
                    {
                        int ancienneQte = Convert.ToInt32(negoExistante[0]["qteDataBaz"]);
                        negoExistante[0]["qteDataBaz"] = ancienneQte + quantiteObtenue;
                    }
                    else
                    {
                        DataRow nouvelleNego = dtNegocier.NewRow();
                        nouvelleNego["nomPlanete"] = this.planeteEnCours;
                        nouvelleNego["numeroMission"] = this.numeroEnCours;
                        nouvelleNego["idEspeceAllie"] = idEspece;
                        nouvelleNego["qteDataBaz"] = quantiteObtenue;

                        dtNegocier.Rows.Add(nouvelleNego);
                    }
                }

                //barre chargement
                FormEcranChargement ecranSombre = new FormEcranChargement();
                ecranSombre.ShowDialog(this);

                ViderChampsDepense();
                
                FormSucces.Afficher("Contact enregistré avec succès !");
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ajout de la dépense : " + ex.Message + "\n(Vérifiez que le montant est valide)", "Erreur");
            }
        }

        private void btnAnnulerDepense_Click(object sender, EventArgs e)
        {
            ViderChampsDepense();
        }

        private void ViderChampsDepense()
        {
            cmbTypeDepense.SelectedIndex = -1;
            dtpDateDepense.Value = DateTime.Now;
            txtMontantDepense.Clear();
            rtxtMotifDepense.Clear();
        }

        private void btnNvEvenement_Click(object sender, EventArgs e)
        {
            gpbNvDepense.Visible = false;
            gpbNvContact.Visible = false;
            gpbNvEvenement.Visible = true;
            gpbEspece.Visible = false;
        }

        private void btnValiderEvenement_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(rtxtCommentaireEvenement.Text))
                {
                    FormSucces.Afficher("Veuillez écrire un commentaire avant de valider l'événement.", true);
                    return;
                }

                DataTable dtJournal = dataSetGlobal.Tables["JournalDeBord"];
                DataRow nouvelEvenement = dtJournal.NewRow();


                nouvelEvenement["nomPlanete"] = this.planeteEnCours;
                nouvelEvenement["numero"] = this.numeroEnCours;
                nouvelEvenement["dateJ"] = dtpDateEvenement.Value.Date;
                nouvelEvenement["commentaires"] = rtxtCommentaireEvenement.Text;


                dtJournal.Rows.Add(nouvelEvenement);

                //barre chargement
                FormEcranChargement ecranSombre = new FormEcranChargement();
                ecranSombre.ShowDialog(this);

                ViderChampsEven();

                FormSucces.Afficher("Contact enregistré avec succès !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ajout au journal : " + ex.Message, "Erreur");
            }
            
        }

        private void btnAnnulerEvenement_Click(object sender, EventArgs e)
        {
            ViderChampsEven();
        }
        private void ViderChampsEven()
        {
            dtpDateEvenement.Value = DateTime.Now;
            rtxtCommentaireEvenement.Clear();
        }

        private void cmbTypeDepense_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idSelectionne;
            if (cmbTypeDepense.SelectedValue != null && int.TryParse(cmbTypeDepense.SelectedValue.ToString(), out idSelectionne))
            {
                // afficher le dataBaz
                if (idSelectionne == 1)
                {
                    lblQuantite.Visible = true;
                    txtQuantite.Visible = true;
                    lblEspece.Visible = true;
                    cmbEspeceAlliee.Visible = true;
                }
                else
                {
                    lblQuantite.Visible = false;
                    txtQuantite.Visible = false;
                    lblEspece.Visible = false;
                    cmbEspeceAlliee.Visible = false;
                    txtQuantite.Clear();
                    cmbEspeceAlliee.SelectedIndex = -1;

                }
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

        private void btnCapture_Click(object sender, EventArgs e)
        {
            gpbNvContact.Visible = false;
            gpbNvDepense.Visible = false;
            gpbNvEvenement.Visible = false;
            gpbEspece.Visible = true;
        }

        private void btnValiderCapture_Click(object sender, EventArgs e)
        {
            try
            {
                //verifie que l'utilisateur a mis plus que 0
                if (cmbEspece.SelectedValue == null || nudNombreCapture.Value <= 0)
                {
                    FormSucces.Afficher("Veuillez sélectionner une espèce et un nombre supérieur à 0.", true);
                    return; 
                }

                //récupère les valeurs
                int idEspeceSelectionnee = Convert.ToInt32(cmbEspece.SelectedValue);
                int nombreCapture = (int)nudNombreCapture.Value;

                //crée une nouvelle ligne vide pour la table "Capturer"
                DataRow nouvelleCapture = MesDatas.DsGlobal.Tables["Capturer"].NewRow();

                //remplit les cases de cette nouvelle ligne
                nouvelleCapture["numeroMission"] = numeroEnCours;
                nouvelleCapture["nomPlanete"] = planeteEnCours;
                nouvelleCapture["idEspeceEnnemi"] = idEspeceSelectionnee;
                nouvelleCapture["nombre"] = nombreCapture;

                //on ajoute la ligne dans le DataSet Global !
                MesDatas.DsGlobal.Tables["Capturer"].Rows.Add(nouvelleCapture);

                //barre chargement
                FormEcranChargement ecranSombre = new FormEcranChargement();
                ecranSombre.ShowDialog(this);

                ViderChampsCapture();

                FormSucces.Afficher("Contact enregistré avec succès !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ajout de la capture : " + ex.Message, "Erreur");
            }
        }

        private void btnAnnulerCapture_Click(object sender, EventArgs e)
        {
            ViderChampsCapture();
        }

        private void ViderChampsCapture()
        {
            cmbEspece.SelectedIndex = -1;
            nudNombreCapture.Value = 0;
        }


        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            if (e.KeyChar == ',' && (sender as TextBox).Text.Contains(","))
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
        }
    }
}
