namespace Form_Sae24_Stargate
{
    partial class FormCalendar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCalendar));
            this.calAvant = new System.Windows.Forms.MonthCalendar();
            this.lblPlanet = new System.Windows.Forms.Label();
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblDepart = new System.Windows.Forms.Label();
            this.lblRetour = new System.Windows.Forms.Label();
            this.calApres = new System.Windows.Forms.MonthCalendar();
            this.btnContinuer = new UserControlBoutonCirculaire.UCBoutonCirculaire();
            this.btnHome = new UserControlBoutonCirculaire.UCBoutonCirculaire();
            this.btnRetour = new UserControlBoutonCirculaire.UCBoutonCirculaire();
            this.SuspendLayout();
            // 
            // calAvant
            // 
            this.calAvant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.calAvant.CalendarDimensions = new System.Drawing.Size(2, 2);
            this.calAvant.Location = new System.Drawing.Point(62, 477);
            this.calAvant.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.calAvant.Name = "calAvant";
            this.calAvant.TabIndex = 0;
            this.calAvant.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calAvant_DateChanged);
            // 
            // lblPlanet
            // 
            this.lblPlanet.AutoSize = true;
            this.lblPlanet.BackColor = System.Drawing.Color.White;
            this.lblPlanet.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblPlanet.Location = new System.Drawing.Point(55, 7);
            this.lblPlanet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlanet.Name = "lblPlanet";
            this.lblPlanet.Size = new System.Drawing.Size(402, 39);
            this.lblPlanet.TabIndex = 2;
            this.lblPlanet.Text = "Vous avez sélectionnez : ";
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.BackColor = System.Drawing.Color.White;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblTitre.Location = new System.Drawing.Point(719, 117);
            this.lblTitre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(402, 39);
            this.lblTitre.TabIndex = 15;
            this.lblTitre.Text = "Vous avez sélectionnez : ";
            // 
            // lblDepart
            // 
            this.lblDepart.AutoSize = true;
            this.lblDepart.BackColor = System.Drawing.Color.White;
            this.lblDepart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblDepart.Location = new System.Drawing.Point(70, 421);
            this.lblDepart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepart.Name = "lblDepart";
            this.lblDepart.Size = new System.Drawing.Size(402, 39);
            this.lblDepart.TabIndex = 16;
            this.lblDepart.Text = "Vous avez sélectionnez : ";
            // 
            // lblRetour
            // 
            this.lblRetour.AutoSize = true;
            this.lblRetour.BackColor = System.Drawing.Color.White;
            this.lblRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblRetour.Location = new System.Drawing.Point(1374, 421);
            this.lblRetour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRetour.Name = "lblRetour";
            this.lblRetour.Size = new System.Drawing.Size(402, 39);
            this.lblRetour.TabIndex = 17;
            this.lblRetour.Text = "Vous avez sélectionnez : ";
            // 
            // calApres
            // 
            this.calApres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.calApres.CalendarDimensions = new System.Drawing.Size(2, 2);
            this.calApres.Location = new System.Drawing.Point(1369, 484);
            this.calApres.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.calApres.Name = "calApres";
            this.calApres.TabIndex = 21;
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
            this.btnContinuer.TabIndex = 24;
            this.btnContinuer.TypeBouton = UserControlBoutonCirculaire.TypeDeBouton.Continuer;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHome.BackgroundImage")));
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.Location = new System.Drawing.Point(875, 884);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(178, 160);
            this.btnHome.TabIndex = 23;
            this.btnHome.TypeBouton = UserControlBoutonCirculaire.TypeDeBouton.Home;
            // 
            // btnRetour
            // 
            this.btnRetour.BackColor = System.Drawing.Color.Transparent;
            this.btnRetour.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRetour.BackgroundImage")));
            this.btnRetour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRetour.Location = new System.Drawing.Point(0, 884);
            this.btnRetour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(178, 160);
            this.btnRetour.TabIndex = 22;
            this.btnRetour.TypeBouton = UserControlBoutonCirculaire.TypeDeBouton.Retour;
            // 
            // FormCalendar
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
            this.Controls.Add(this.calApres);
            this.Controls.Add(this.lblRetour);
            this.Controls.Add(this.lblDepart);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.lblPlanet);
            this.Controls.Add(this.calAvant);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.Name = "FormCalendar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selectionnez les dates";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormCalendar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar calAvant;
        private System.Windows.Forms.Label lblPlanet;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblDepart;
        private System.Windows.Forms.Label lblRetour;
        private System.Windows.Forms.MonthCalendar calApres;
        private UserControlBoutonCirculaire.UCBoutonCirculaire btnContinuer;
        private UserControlBoutonCirculaire.UCBoutonCirculaire btnHome;
        private UserControlBoutonCirculaire.UCBoutonCirculaire btnRetour;
    }
}