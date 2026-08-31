namespace Form_Sae24_Stargate
{
    partial class FromTrombino
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FromTrombino));
            this.flpEquipage = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTitre = new System.Windows.Forms.Label();
            this.btnContinuer = new UserControlBoutonCirculaire.UCBoutonCirculaire();
            this.btnHome = new UserControlBoutonCirculaire.UCBoutonCirculaire();
            this.btnRetour = new UserControlBoutonCirculaire.UCBoutonCirculaire();
            this.SuspendLayout();
            // 
            // flpEquipage
            // 
            this.flpEquipage.AutoScroll = true;
            this.flpEquipage.BackColor = System.Drawing.Color.Transparent;
            this.flpEquipage.Location = new System.Drawing.Point(523, 292);
            this.flpEquipage.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.flpEquipage.Name = "flpEquipage";
            this.flpEquipage.Padding = new System.Windows.Forms.Padding(4, 4, 0, 0);
            this.flpEquipage.Size = new System.Drawing.Size(889, 584);
            this.flpEquipage.TabIndex = 3;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Location = new System.Drawing.Point(633, 174);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(44, 16);
            this.lblTitre.TabIndex = 25;
            this.lblTitre.Text = "label1";
            // 
            // btnContinuer
            // 
            this.btnContinuer.BackColor = System.Drawing.Color.Transparent;
            this.btnContinuer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnContinuer.BackgroundImage")));
            this.btnContinuer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnContinuer.Location = new System.Drawing.Point(1727, 879);
            this.btnContinuer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnContinuer.Name = "btnContinuer";
            this.btnContinuer.Size = new System.Drawing.Size(178, 160);
            this.btnContinuer.TabIndex = 30;
            this.btnContinuer.TypeBouton = UserControlBoutonCirculaire.TypeDeBouton.Continuer;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHome.BackgroundImage")));
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.Location = new System.Drawing.Point(926, 879);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(178, 160);
            this.btnHome.TabIndex = 29;
            this.btnHome.TypeBouton = UserControlBoutonCirculaire.TypeDeBouton.Home;
            // 
            // btnRetour
            // 
            this.btnRetour.BackColor = System.Drawing.Color.Transparent;
            this.btnRetour.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRetour.BackgroundImage")));
            this.btnRetour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRetour.Location = new System.Drawing.Point(0, 879);
            this.btnRetour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(178, 160);
            this.btnRetour.TabIndex = 28;
            this.btnRetour.TypeBouton = UserControlBoutonCirculaire.TypeDeBouton.Retour;
            // 
            // FromTrombino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.btnContinuer);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.flpEquipage);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FromTrombino";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Selectionnez le(s) membre(s)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FromTrombino_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpEquipage;
        private System.Windows.Forms.Label lblTitre;
        private UserControlBoutonCirculaire.UCBoutonCirculaire btnContinuer;
        private UserControlBoutonCirculaire.UCBoutonCirculaire btnHome;
        private UserControlBoutonCirculaire.UCBoutonCirculaire btnRetour;
    }
}