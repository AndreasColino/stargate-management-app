namespace Form_Sae24_Stargate
{
    partial class FormAccueil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAccueil));
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnUCNouvelleMission = new UserControlBoutonAvecImage.UCBoutonImage();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(84, 19);
            this.picLogo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(624, 458);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 10;
            this.picLogo.TabStop = false;
            // 
            // btnUCNouvelleMission
            // 
            this.btnUCNouvelleMission.BackColor = System.Drawing.Color.Transparent;
            this.btnUCNouvelleMission.imageBouton = ((System.Drawing.Image)(resources.GetObject("btnUCNouvelleMission.imageBouton")));
            this.btnUCNouvelleMission.Location = new System.Drawing.Point(94, 520);
            this.btnUCNouvelleMission.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.btnUCNouvelleMission.Name = "btnUCNouvelleMission";
            this.btnUCNouvelleMission.Size = new System.Drawing.Size(458, 117);
            this.btnUCNouvelleMission.TabIndex = 7;
            this.btnUCNouvelleMission.texteBouton = "Nouvelle mission";
            // 
            // FormAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(2616, 1589);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.btnUCNouvelleMission);
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.MaximizeBox = false;
            this.Name = "FormAccueil";
            this.Text = "Stargate";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private UserControlBoutonAvecImage.UCBoutonImage btnUCNouvelleMission;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblAucuneMissionTerminee;
    }
}

