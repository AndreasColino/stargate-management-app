namespace Form_Sae24_Stargate
{
    partial class FormPreparationVaisseau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPreparationVaisseau));
            this.lblPlanet = new System.Windows.Forms.Label();
            this.flpEquipage = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnContinuer = new UserControlBoutonCirculaire.UCBoutonCirculaire();
            this.btnHome = new UserControlBoutonCirculaire.UCBoutonCirculaire();
            this.btnRetour = new UserControlBoutonCirculaire.UCBoutonCirculaire();
            this.SuspendLayout();
            // 
            // lblPlanet
            // 
            this.lblPlanet.AutoSize = true;
            this.lblPlanet.BackColor = System.Drawing.Color.White;
            this.lblPlanet.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblPlanet.Location = new System.Drawing.Point(33, 15);
            this.lblPlanet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlanet.Name = "lblPlanet";
            this.lblPlanet.Size = new System.Drawing.Size(385, 39);
            this.lblPlanet.TabIndex = 1;
            this.lblPlanet.Text = "Vous avez sélectionné : ";
            // 
            // flpEquipage
            // 
            this.flpEquipage.AutoScroll = true;
            this.flpEquipage.BackColor = System.Drawing.Color.Transparent;
            this.flpEquipage.Location = new System.Drawing.Point(1093, 211);
            this.flpEquipage.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.flpEquipage.Name = "flpEquipage";
            this.flpEquipage.Padding = new System.Windows.Forms.Padding(4, 4, 0, 0);
            this.flpEquipage.Size = new System.Drawing.Size(485, 787);
            this.flpEquipage.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(33, 134);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(530, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sélectionnez le chef de la mission";
            // 
            // btnContinuer
            // 
            this.btnContinuer.BackColor = System.Drawing.Color.Transparent;
            this.btnContinuer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnContinuer.BackgroundImage")));
            this.btnContinuer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnContinuer.Location = new System.Drawing.Point(1734, 884);
            this.btnContinuer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnContinuer.Name = "btnContinuer";
            this.btnContinuer.Size = new System.Drawing.Size(178, 160);
            this.btnContinuer.TabIndex = 27;
            this.btnContinuer.TypeBouton = UserControlBoutonCirculaire.TypeDeBouton.Continuer;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHome.BackgroundImage")));
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.Location = new System.Drawing.Point(844, 884);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(178, 160);
            this.btnHome.TabIndex = 26;
            this.btnHome.TypeBouton = UserControlBoutonCirculaire.TypeDeBouton.Home;
            // 
            // btnRetour
            // 
            this.btnRetour.BackColor = System.Drawing.Color.Transparent;
            this.btnRetour.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRetour.BackgroundImage")));
            this.btnRetour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRetour.Location = new System.Drawing.Point(12, 884);
            this.btnRetour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(178, 160);
            this.btnRetour.TabIndex = 25;
            this.btnRetour.TypeBouton = UserControlBoutonCirculaire.TypeDeBouton.Retour;
            // 
            // FormPreparationVaisseau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.btnContinuer);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flpEquipage);
            this.Controls.Add(this.lblPlanet);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPreparationVaisseau";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selectionnez le/la chef";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPreparationVaisseau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlanet;
        private System.Windows.Forms.FlowLayoutPanel flpEquipage;
        private System.Windows.Forms.Label label1;
        private UserControlBoutonCirculaire.UCBoutonCirculaire btnContinuer;
        private UserControlBoutonCirculaire.UCBoutonCirculaire btnHome;
        private UserControlBoutonCirculaire.UCBoutonCirculaire btnRetour;
    }
}