using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserControlBoutonCirculaire;
using UserControlPinPlanete;

namespace Form_Sae24_Stargate
{
    public partial class FormNouvelleMission : Form
    {
        public FormNouvelleMission()
        {
            InitializeComponent();
        }
        private string planeteSelectionnee = null;
        private List<Point> positionsPlanetes = new List<Point>()
        {
            new Point(908, -1),
            new Point(1181, 372),
            new Point(1233, 148),
            new Point(649, 542),
            new Point(580, 320),
            new Point(423, 232),
            new Point(763, 352),
            new Point(1010, 474),
            new Point(412, 497),
            new Point(241, 400),
            new Point(94, 250),
            new Point(260, 71),
            new Point(897, 216),
            new Point(1091, 59),
            new Point(711, 92),
            new Point(1564, 234),
            new Point(1515, 488),
        };


        private void FormNouvelleMission_Load(object sender, EventArgs e)
        {
            label1.Font = FontHelper.GetOrbitron(16);
            label1.ForeColor = Color.White;
            label1.Text = "✦  CHOISISSEZ VOTRE DESTINATION  ✦";
            btnContinuer.Visible = false;
            btnContinuer.afficheur = btnContinuer_Click;
            btnHome.afficheur = btnHome_Click;


            if (MesDatas.DsGlobal.Tables.Contains("Planete"))
            {
                int i = 0;
                foreach (DataRow ligne in MesDatas.DsGlobal.Tables["Planete"].Rows)
                {
                    string nomPlanete = ligne["nom"].ToString();

                    UCPinPlanete nouveauPin = new UCPinPlanete();
                    nouveauPin.NomPlanete = nomPlanete;
                    string pathImage = System.IO.Path.Combine(Application.StartupPath, "Images", "Planetes", "bgr", nomPlanete + "-removebg-preview.png");
                    nouveauPin.PictureBoxPlanete = pathImage; 
                    this.Controls.Add(nouveauPin);
                    nouveauPin.NomFont = FontHelper.GetOrbitron(16);

                    if (i < positionsPlanetes.Count)
                    {
                        nouveauPin.Location = positionsPlanetes[i];
                    }
                    nouveauPin.afficheur = UnePlaneteAeteCliquee;
                    nouveauPin.BringToFront();
                    i++;

                }
            }
        }
        private void UnePlaneteAeteCliquee(object sender, EventArgs e)
        {
            UCPinPlanete planeteCliquee;
            if (sender is UCPinPlanete)
            {
                planeteCliquee = (UCPinPlanete)sender;
            }
            else
            {
                Control elementClique = (Control)sender;
                planeteCliquee = (UCPinPlanete)elementClique.Parent;
            }

            planeteSelectionnee = planeteCliquee.NomPlanete;

            btnContinuer.Visible = true;
            btnContinuer.Enabled = true;
            btnContinuer.PasserEnVert();
        }
        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnContinuer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(planeteSelectionnee))
            {
                ((UCBoutonCirculaire)sender).DeclencherErreur();
                return;
            }
            SessionMission.PlaneteSelectionnee = planeteSelectionnee;
            FormCalendar frmSuivant = new FormCalendar(this);
            this.Hide();
            frmSuivant.ShowDialog();
        }

        private void ucPinPlanete1_Load(object sender, EventArgs e)
        {

        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            FormAccueil frmSuivant = new FormAccueil();
            frmSuivant.Show();
            this.Close(); 
        }
    }
}
