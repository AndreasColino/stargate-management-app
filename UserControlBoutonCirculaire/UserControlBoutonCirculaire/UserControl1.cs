using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControlBoutonCirculaire
{
    public delegate void afficherInfos(object sender, EventArgs e);

    public enum TypeDeBouton
    {
        Continuer,
        Retour,
        Home
    }

    public partial class UCBoutonCirculaire : UserControl
    {
        public afficherInfos afficheur;

        private TypeDeBouton _typeBouton = TypeDeBouton.Continuer;
        public TypeDeBouton TypeBouton
        {
            get
            {
                return _typeBouton;
            }
            set
            {
                _typeBouton = value;
                ChargerImages();
            }
        }

        public UCBoutonCirculaire()
        {
            InitializeComponent();
            this.BackColor = Color.Transparent;
            pic1.BackColor = Color.Transparent;
            pic1.SizeMode = PictureBoxSizeMode.Zoom;
            this.MouseEnter += Bouton_MouseEnter;
            this.MouseLeave += Bouton_MouseLeave;
            pic1.MouseEnter += Bouton_MouseEnter;
            pic1.MouseLeave += Bouton_MouseLeave;
            this.Click += Zone_Click;
            pic1.Click += Zone_Click;
        }

        private void UCBoutonCirculaire_Load(object sender, EventArgs e)
        {
            ChargerImages();
        }

        private void ChargerImages()
        {
            if (this.DesignMode)
            {
                return;
            }

            try
            {
                string cheminDossier = Path.Combine(Application.StartupPath, "Images", "Boutons");
                string cheminRond = Path.Combine(cheminDossier, "Rond.png");

                if (File.Exists(cheminRond))
                {
                    this.BackgroundImage = Image.FromFile(cheminRond);
                }
                string nomIcone = "";

                switch (TypeBouton)
                {
                    case TypeDeBouton.Continuer:
                        nomIcone = "Fleche droite.png";
                        break;

                    case TypeDeBouton.Retour:
                        nomIcone = "Fleche gauche.png";
                        break;

                    case TypeDeBouton.Home:
                        nomIcone = "Home.png";
                        break;
                }

                string cheminIcone = Path.Combine(cheminDossier, nomIcone);

                if (File.Exists(cheminIcone))
                {
                    pic1.Image = Image.FromFile(cheminIcone);
                }
            }
            catch
            {
            }
        }

        private void Bouton_MouseEnter(object sender, EventArgs e)
        {
            if (this.DesignMode)
            {
                return;
            }

            string cheminGris = Path.Combine(Application.StartupPath, "Images", "Boutons", "Rond_Gris.png");

            if (File.Exists(cheminGris))
            {
                this.BackgroundImage = Image.FromFile(cheminGris);
            }
        }

        private void Bouton_MouseLeave(object sender, EventArgs e)
        {
            if (this.DesignMode)
            {
                return;
            }
            string nomImage;

            if (_estVert == true)
            {
                nomImage = "Rond_Vert.png";
            }
            else
            {
                nomImage = "Rond.png";
            }
            string cheminRond = Path.Combine(Application.StartupPath, "Images", "Boutons", nomImage);

            if (File.Exists(cheminRond))
            {
                this.BackgroundImage = Image.FromFile(cheminRond);
            }
        }

        private void Zone_Click(object sender, EventArgs e)
        {
            if (this.afficheur != null)
            {
                this.afficheur(this, e);
            }
        }
        private bool _estVert = false;
        public void PasserEnVert()
        {
            _estVert = true;
            string cheminVert = Path.Combine(Application.StartupPath, "Images", "Boutons", "Rond_Vert.png");

            if (File.Exists(cheminVert))
            {
                this.BackgroundImage = Image.FromFile(cheminVert);
            }
        }

        public async void DeclencherErreur()
        {
            string cheminRouge = Path.Combine(Application.StartupPath, "Images", "Boutons", "Rond_Rouge.png");
            string cheminRond = Path.Combine(Application.StartupPath, "Images", "Boutons", "Rond.png");

            if (File.Exists(cheminRouge))
            {
                this.BackgroundImage = Image.FromFile(cheminRouge);
            }

            Point positionInitiale = this.Location;
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    this.Left += 5; 
                }
                else
                {
                    this.Left -= 5;
                }

                await Task.Delay(30);
            }

            this.Location = positionInitiale;
            if (File.Exists(cheminRond))
            {
                this.BackgroundImage = Image.FromFile(cheminRond);
            }
        }
    }
}