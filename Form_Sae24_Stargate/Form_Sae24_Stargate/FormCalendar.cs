using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Sae24_Stargate
{
    public partial class FormCalendar : Form
    {
        string m_planete;
        Form m_formParent;
        public FormCalendar(Form formParent = null)
        {
            InitializeComponent();
            m_formParent = formParent;
            m_planete = SessionMission.PlaneteSelectionnee;
            calAvant.MinDate = DateTime.Today;
            calApres.MinDate = DateTime.Today;
            lblPlanet.Font = FontHelper.GetOrbitron(16);
            lblTitre.Font = FontHelper.GetOrbitron(16);
            lblDepart.Font = FontHelper.GetOrbitron(16);
            lblRetour.Font = FontHelper.GetOrbitron(16);

            lblPlanet.Text = "MISSION SUR LA PLANÈTE : " + m_planete.ToUpper();
            btnRetour.afficheur = btnRetour_Click;
            btnContinuer.afficheur = btnContinuer_Click;
            btnHome.afficheur = btnHome_Click;
            lblTitre.Text = "✦  CHOISISSEZ LES DATES DE LA MISSION  ✦";
            lblDepart.Text = "DATE DE DEPART";
            lblRetour.Text = "DATE DE RETOUR";
        }

        private void FormCalendar_Load(object sender, EventArgs e)
        {
            btnContinuer.PasserEnVert();
        }

        private void calAvant_DateChanged(object sender, DateRangeEventArgs e)
        {
            calApres.MinDate = calAvant.SelectionStart;
        }
        private void btnRetour_Click(object sender, EventArgs e)
        {
            if (m_formParent != null)
            {
                m_formParent.Show();
            }
            this.Close();
        }
        private void btnContinuer_Click(object sender, EventArgs e)
        {
            SessionMission.DateDepart = calAvant.SelectionStart.ToString("yyyy-MM-dd");
            SessionMission.DateRetour = calApres.SelectionStart.ToString("yyyy-MM-dd");
            FormPreparationVaisseau frmSuivant = new FormPreparationVaisseau(this);
            this.Hide();
            frmSuivant.ShowDialog();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            FormAccueil frmSuivant = new FormAccueil();
            frmSuivant.Show();
            this.Close();

        }
    }
}
