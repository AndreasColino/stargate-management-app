using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControlMembreEquipageDetail
{
    public partial class UCEquipageDetail : UserControl
    {
        public UCEquipageDetail()
        {
            InitializeComponent();
        }

        public UCEquipageDetail(string matricule, string nomPrenom, string dateNaissance, string planete, string specialiteGrade)
        {
            InitializeComponent();

            lblMatricule.Text = matricule;
            lblNomMembreEquipage.Text = nomPrenom;
            lblDateDeNaissance.Text = dateNaissance;
            lblPlanete.Text = planete;
            lblSpecialiteGrade.Text = specialiteGrade;
        }
    }
}
