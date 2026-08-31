namespace Form_Sae24_Stargate
{
    partial class FormParametreMission
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormParametreMission));
            this.lblPlanet = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grp = new System.Windows.Forms.GroupBox();
            this.txtFeuilleRoute = new System.Windows.Forms.TextBox();
            this.ucBoutonIncrementer3 = new UserControlBoutonIncrementer.UCBoutonIncrementer();
            this.ucBoutonIncrementer2 = new UserControlBoutonIncrementer.UCBoutonIncrementer();
            this.ucBoutonIncrementer1 = new UserControlBoutonIncrementer.UCBoutonIncrementer();
            this.cmbEspeces = new System.Windows.Forms.ComboBox();
            this.nudObjectifCapture = new System.Windows.Forms.NumericUpDown();
            this.btnSupprimerCapture = new System.Windows.Forms.Button();
            this.btnAjouterCapture = new System.Windows.Forms.Button();
            this.lstObjectifsCaptures = new System.Windows.Forms.ListBox();
            this.grbCaptures = new System.Windows.Forms.GroupBox();
            this.btnContinuer = new UserControlBoutonCirculaire.UCBoutonCirculaire();
            this.btnHome = new UserControlBoutonCirculaire.UCBoutonCirculaire();
            this.btnRetour = new UserControlBoutonCirculaire.UCBoutonCirculaire();
            this.grp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudObjectifCapture)).BeginInit();
            this.grbCaptures.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPlanet
            // 
            this.lblPlanet.AutoSize = true;
            this.lblPlanet.BackColor = System.Drawing.Color.White;
            this.lblPlanet.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblPlanet.Location = new System.Drawing.Point(12, 7);
            this.lblPlanet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlanet.Name = "lblPlanet";
            this.lblPlanet.Size = new System.Drawing.Size(385, 39);
            this.lblPlanet.TabIndex = 2;
            this.lblPlanet.Text = "Vous avez sélectionné : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(689, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(494, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sélection des paramètres :";
            // 
            // grp
            // 
            this.grp.BackColor = System.Drawing.Color.Transparent;
            this.grp.Controls.Add(this.txtFeuilleRoute);
            this.grp.ForeColor = System.Drawing.Color.White;
            this.grp.Location = new System.Drawing.Point(589, 555);
            this.grp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grp.Name = "grp";
            this.grp.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grp.Size = new System.Drawing.Size(793, 204);
            this.grp.TabIndex = 21;
            this.grp.TabStop = false;
            this.grp.Text = "Feuille de route";
            // 
            // txtFeuilleRoute
            // 
            this.txtFeuilleRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFeuilleRoute.Location = new System.Drawing.Point(26, 36);
            this.txtFeuilleRoute.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFeuilleRoute.Multiline = true;
            this.txtFeuilleRoute.Name = "txtFeuilleRoute";
            this.txtFeuilleRoute.Size = new System.Drawing.Size(751, 147);
            this.txtFeuilleRoute.TabIndex = 0;
            // 
            // ucBoutonIncrementer3
            // 
            this.ucBoutonIncrementer3.BackColor = System.Drawing.Color.Transparent;
            this.ucBoutonIncrementer3.Location = new System.Drawing.Point(598, 279);
            this.ucBoutonIncrementer3.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.ucBoutonIncrementer3.Name = "ucBoutonIncrementer3";
            this.ucBoutonIncrementer3.PasMoins = 1000;
            this.ucBoutonIncrementer3.PasMoinsMoins = 10000;
            this.ucBoutonIncrementer3.PasPlus = 1000;
            this.ucBoutonIncrementer3.PasPlusPlus = 10000;
            this.ucBoutonIncrementer3.Size = new System.Drawing.Size(448, 79);
            this.ucBoutonIncrementer3.TabIndex = 5;
            this.ucBoutonIncrementer3.TexteSymbole = "€";
            this.ucBoutonIncrementer3.TexteUnite = "Budget";
            this.ucBoutonIncrementer3.Valeur = 0;
            this.ucBoutonIncrementer3.ValeurMin = 0;
            // 
            // ucBoutonIncrementer2
            // 
            this.ucBoutonIncrementer2.BackColor = System.Drawing.Color.Transparent;
            this.ucBoutonIncrementer2.Location = new System.Drawing.Point(598, 209);
            this.ucBoutonIncrementer2.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.ucBoutonIncrementer2.Name = "ucBoutonIncrementer2";
            this.ucBoutonIncrementer2.PasMoins = 1;
            this.ucBoutonIncrementer2.PasMoinsMoins = 10;
            this.ucBoutonIncrementer2.PasPlus = 1;
            this.ucBoutonIncrementer2.PasPlusPlus = 10;
            this.ucBoutonIncrementer2.Size = new System.Drawing.Size(476, 68);
            this.ucBoutonIncrementer2.TabIndex = 4;
            this.ucBoutonIncrementer2.TexteSymbole = "tonne(s)";
            this.ucBoutonIncrementer2.TexteUnite = "Objectif de DataBaz";
            this.ucBoutonIncrementer2.Valeur = 0;
            this.ucBoutonIncrementer2.ValeurMin = 0;
            // 
            // ucBoutonIncrementer1
            // 
            this.ucBoutonIncrementer1.BackColor = System.Drawing.Color.Transparent;
            this.ucBoutonIncrementer1.Location = new System.Drawing.Point(598, 137);
            this.ucBoutonIncrementer1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.ucBoutonIncrementer1.Name = "ucBoutonIncrementer1";
            this.ucBoutonIncrementer1.PasMoins = 1;
            this.ucBoutonIncrementer1.PasMoinsMoins = 10;
            this.ucBoutonIncrementer1.PasPlus = 1;
            this.ucBoutonIncrementer1.PasPlusPlus = 10;
            this.ucBoutonIncrementer1.Size = new System.Drawing.Size(477, 70);
            this.ucBoutonIncrementer1.TabIndex = 0;
            this.ucBoutonIncrementer1.TexteSymbole = "membre(s)";
            this.ucBoutonIncrementer1.TexteUnite = "Nombre de membre(s)";
            this.ucBoutonIncrementer1.Valeur = 1;
            this.ucBoutonIncrementer1.ValeurMin = 1;
            // 
            // cmbEspeces
            // 
            this.cmbEspeces.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEspeces.FormattingEnabled = true;
            this.cmbEspeces.Location = new System.Drawing.Point(20, 126);
            this.cmbEspeces.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEspeces.Name = "cmbEspeces";
            this.cmbEspeces.Size = new System.Drawing.Size(388, 28);
            this.cmbEspeces.TabIndex = 22;
            // 
            // nudObjectifCapture
            // 
            this.nudObjectifCapture.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudObjectifCapture.Location = new System.Drawing.Point(416, 128);
            this.nudObjectifCapture.Margin = new System.Windows.Forms.Padding(4);
            this.nudObjectifCapture.Name = "nudObjectifCapture";
            this.nudObjectifCapture.Size = new System.Drawing.Size(58, 26);
            this.nudObjectifCapture.TabIndex = 23;
            // 
            // btnSupprimerCapture
            // 
            this.btnSupprimerCapture.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimerCapture.ForeColor = System.Drawing.Color.Black;
            this.btnSupprimerCapture.Location = new System.Drawing.Point(672, 34);
            this.btnSupprimerCapture.Margin = new System.Windows.Forms.Padding(4);
            this.btnSupprimerCapture.Name = "btnSupprimerCapture";
            this.btnSupprimerCapture.Size = new System.Drawing.Size(112, 58);
            this.btnSupprimerCapture.TabIndex = 24;
            this.btnSupprimerCapture.Text = "Supprimer";
            this.btnSupprimerCapture.UseVisualStyleBackColor = true;
            this.btnSupprimerCapture.Click += new System.EventHandler(this.btnSupprimerCapture_Click);
            // 
            // btnAjouterCapture
            // 
            this.btnAjouterCapture.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterCapture.Location = new System.Drawing.Point(672, 100);
            this.btnAjouterCapture.Margin = new System.Windows.Forms.Padding(4);
            this.btnAjouterCapture.Name = "btnAjouterCapture";
            this.btnAjouterCapture.Size = new System.Drawing.Size(114, 54);
            this.btnAjouterCapture.TabIndex = 25;
            this.btnAjouterCapture.Text = "Ajouter";
            this.btnAjouterCapture.UseVisualStyleBackColor = true;
            this.btnAjouterCapture.Click += new System.EventHandler(this.btnAjouterCapture_Click);
            // 
            // lstObjectifsCaptures
            // 
            this.lstObjectifsCaptures.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstObjectifsCaptures.FormattingEnabled = true;
            this.lstObjectifsCaptures.ItemHeight = 20;
            this.lstObjectifsCaptures.Location = new System.Drawing.Point(20, 34);
            this.lstObjectifsCaptures.Margin = new System.Windows.Forms.Padding(4);
            this.lstObjectifsCaptures.Name = "lstObjectifsCaptures";
            this.lstObjectifsCaptures.Size = new System.Drawing.Size(644, 84);
            this.lstObjectifsCaptures.TabIndex = 26;
            // 
            // grbCaptures
            // 
            this.grbCaptures.BackColor = System.Drawing.Color.Transparent;
            this.grbCaptures.Controls.Add(this.btnAjouterCapture);
            this.grbCaptures.Controls.Add(this.btnSupprimerCapture);
            this.grbCaptures.Controls.Add(this.lstObjectifsCaptures);
            this.grbCaptures.Controls.Add(this.cmbEspeces);
            this.grbCaptures.Controls.Add(this.nudObjectifCapture);
            this.grbCaptures.ForeColor = System.Drawing.Color.White;
            this.grbCaptures.Location = new System.Drawing.Point(589, 361);
            this.grbCaptures.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbCaptures.Name = "grbCaptures";
            this.grbCaptures.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbCaptures.Size = new System.Drawing.Size(793, 177);
            this.grbCaptures.TabIndex = 22;
            this.grbCaptures.TabStop = false;
            this.grbCaptures.Text = "✦ Liste des captures ✦";
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
            this.btnContinuer.TabIndex = 30;
            this.btnContinuer.TypeBouton = UserControlBoutonCirculaire.TypeDeBouton.Continuer;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHome.BackgroundImage")));
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.Location = new System.Drawing.Point(885, 884);
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
            this.btnRetour.Location = new System.Drawing.Point(12, 884);
            this.btnRetour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(178, 160);
            this.btnRetour.TabIndex = 28;
            this.btnRetour.TypeBouton = UserControlBoutonCirculaire.TypeDeBouton.Retour;
            // 
            // FormParametreMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.btnContinuer);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.grbCaptures);
            this.Controls.Add(this.grp);
            this.Controls.Add(this.ucBoutonIncrementer3);
            this.Controls.Add(this.ucBoutonIncrementer2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPlanet);
            this.Controls.Add(this.ucBoutonIncrementer1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.Name = "FormParametreMission";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configurez les paramètres";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormParametreMission_Load);
            this.grp.ResumeLayout(false);
            this.grp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudObjectifCapture)).EndInit();
            this.grbCaptures.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControlBoutonIncrementer.UCBoutonIncrementer ucBoutonIncrementer1;
        private System.Windows.Forms.Label lblPlanet;
        private System.Windows.Forms.Label label1;
        private UserControlBoutonIncrementer.UCBoutonIncrementer ucBoutonIncrementer2;
        private UserControlBoutonIncrementer.UCBoutonIncrementer ucBoutonIncrementer3;
        private System.Windows.Forms.GroupBox grp;
        private System.Windows.Forms.TextBox txtFeuilleRoute;
        private System.Windows.Forms.ComboBox cmbEspeces;
        private System.Windows.Forms.NumericUpDown nudObjectifCapture;
        private System.Windows.Forms.Button btnSupprimerCapture;
        private System.Windows.Forms.Button btnAjouterCapture;
        private System.Windows.Forms.ListBox lstObjectifsCaptures;
        private System.Windows.Forms.GroupBox grbCaptures;
        private UserControlBoutonCirculaire.UCBoutonCirculaire btnContinuer;
        private UserControlBoutonCirculaire.UCBoutonCirculaire btnHome;
        private UserControlBoutonCirculaire.UCBoutonCirculaire btnRetour;
    }
}