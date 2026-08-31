namespace UserControlMembreEquipage
{
    partial class UCTrombinoEquipage
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

        #region Code généré par le Concepteur de composants

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnInfoEquipage = new System.Windows.Forms.Button();
            this.picMembreEquipage = new System.Windows.Forms.PictureBox();
            this.lblNomMembreEquipage = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMembreEquipage)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnInfoEquipage);
            this.groupBox1.Controls.Add(this.picMembreEquipage);
            this.groupBox1.Controls.Add(this.lblNomMembreEquipage);
            this.groupBox1.Location = new System.Drawing.Point(3, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(214, 294);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // btnInfoEquipage
            // 
            this.btnInfoEquipage.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfoEquipage.Location = new System.Drawing.Point(166, 242);
            this.btnInfoEquipage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInfoEquipage.Name = "btnInfoEquipage";
            this.btnInfoEquipage.Size = new System.Drawing.Size(40, 44);
            this.btnInfoEquipage.TabIndex = 8;
            this.btnInfoEquipage.Text = "i";
            this.btnInfoEquipage.UseVisualStyleBackColor = true;
            this.btnInfoEquipage.Visible = false;
            // 
            // picMembreEquipage
            // 
            this.picMembreEquipage.Location = new System.Drawing.Point(17, 14);
            this.picMembreEquipage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picMembreEquipage.Name = "picMembreEquipage";
            this.picMembreEquipage.Size = new System.Drawing.Size(178, 182);
            this.picMembreEquipage.TabIndex = 0;
            this.picMembreEquipage.TabStop = false;
            // 
            // lblNomMembreEquipage
            // 
            this.lblNomMembreEquipage.AutoSize = true;
            this.lblNomMembreEquipage.Location = new System.Drawing.Point(26, 212);
            this.lblNomMembreEquipage.Name = "lblNomMembreEquipage";
            this.lblNomMembreEquipage.Size = new System.Drawing.Size(101, 20);
            this.lblNomMembreEquipage.TabIndex = 1;
            this.lblNomMembreEquipage.Text = "Nom Prénom";
            // 
            // UCTrombinoEquipage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UCTrombinoEquipage";
            this.Size = new System.Drawing.Size(225, 304);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMembreEquipage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnInfoEquipage;
        private System.Windows.Forms.PictureBox picMembreEquipage;
        private System.Windows.Forms.Label lblNomMembreEquipage;
    }
}
