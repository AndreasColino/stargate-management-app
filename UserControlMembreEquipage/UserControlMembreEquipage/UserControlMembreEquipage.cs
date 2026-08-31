using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;        // ← ajouter ceci
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControlMembreEquipage
{
    public delegate void afficherInfos(object sender, EventArgs e);

    public partial class UCTrombinoEquipage : UserControl
    {
        public afficherInfos afficheur;
        public afficherInfos selectionneur;

        private string m_matricule;

        public string MatriculeMembre
        {
            get { return m_matricule; }
            set
            {
                m_matricule = value;
                ChargerImage(value);
            }
        }

        public string NomPrenom
        {
            get { return lblNomMembreEquipage.Text; }
            set { lblNomMembreEquipage.Text = value; }
        }

        public UCTrombinoEquipage()
        {
            InitializeComponent();
            btnInfoEquipage.Click += btnInfo_Click;
            this.Click += ClicPourSelection;
            lblNomMembreEquipage.Click += ClicPourSelection;
            picMembreEquipage.Click += ClicPourSelection;
        }

        private void ChargerImage(string matricule)
        {
            string chemin = System.IO.Path.Combine(
                Application.StartupPath, "Images", "ImageMetier", matricule + ".png");

            if (System.IO.File.Exists(chemin))
            {
                picMembreEquipage.Image = Image.FromFile(chemin);
                picMembreEquipage.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            if (afficheur != null)
            {
                afficheur(this, e);
            }
        }

        private void ClicPourSelection(object sender, EventArgs e)
        {
            if (selectionneur != null)
            {
                selectionneur(this, e);
            }
        }
    }
}