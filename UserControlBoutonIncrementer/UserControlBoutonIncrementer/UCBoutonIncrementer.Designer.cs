namespace UserControlBoutonIncrementer
{
    partial class UCBoutonIncrementer
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
            this.components = new System.ComponentModel.Container();
            this.lblUnite = new System.Windows.Forms.Label();
            this.lblSymbole = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnMM = new System.Windows.Forms.Button();
            this.btnPP = new System.Windows.Forms.Button();
            this.btnM = new System.Windows.Forms.Button();
            this.btnP = new System.Windows.Forms.Button();
            this.txtVal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUnite
            // 
            this.lblUnite.AutoSize = true;
            this.lblUnite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnite.ForeColor = System.Drawing.Color.White;
            this.lblUnite.Location = new System.Drawing.Point(124, -2);
            this.lblUnite.Name = "lblUnite";
            this.lblUnite.Size = new System.Drawing.Size(48, 20);
            this.lblUnite.TabIndex = 5;
            this.lblUnite.Text = "Unité";
            // 
            // lblSymbole
            // 
            this.lblSymbole.AutoSize = true;
            this.lblSymbole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSymbole.ForeColor = System.Drawing.Color.White;
            this.lblSymbole.Location = new System.Drawing.Point(124, 48);
            this.lblSymbole.Name = "lblSymbole";
            this.lblSymbole.Size = new System.Drawing.Size(73, 20);
            this.lblSymbole.TabIndex = 6;
            this.lblSymbole.Text = "Symbole";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // btnMM
            // 
            this.btnMM.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMM.Location = new System.Drawing.Point(0, 12);
            this.btnMM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMM.Name = "btnMM";
            this.btnMM.Size = new System.Drawing.Size(43, 39);
            this.btnMM.TabIndex = 4;
            this.btnMM.Text = "- -";
            this.btnMM.UseVisualStyleBackColor = true;
            this.btnMM.Click += new System.EventHandler(this.btnMM_Click);
            // 
            // btnPP
            // 
            this.btnPP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPP.Location = new System.Drawing.Point(393, 12);
            this.btnPP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPP.Name = "btnPP";
            this.btnPP.Size = new System.Drawing.Size(43, 39);
            this.btnPP.TabIndex = 2;
            this.btnPP.Text = "++";
            this.btnPP.UseVisualStyleBackColor = true;
            this.btnPP.Click += new System.EventHandler(this.btnPP_Click);
            // 
            // btnM
            // 
            this.btnM.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnM.Location = new System.Drawing.Point(61, 12);
            this.btnM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnM.Name = "btnM";
            this.btnM.Size = new System.Drawing.Size(43, 39);
            this.btnM.TabIndex = 3;
            this.btnM.Text = "-";
            this.btnM.UseVisualStyleBackColor = true;
            this.btnM.Click += new System.EventHandler(this.btnM_Click);
            // 
            // btnP
            // 
            this.btnP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnP.Location = new System.Drawing.Point(322, 12);
            this.btnP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnP.Name = "btnP";
            this.btnP.Size = new System.Drawing.Size(43, 39);
            this.btnP.TabIndex = 1;
            this.btnP.Text = "+";
            this.btnP.UseVisualStyleBackColor = true;
            this.btnP.Click += new System.EventHandler(this.btnP_Click);
            // 
            // txtVal
            // 
            this.txtVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVal.Location = new System.Drawing.Point(121, 20);
            this.txtVal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVal.Name = "txtVal";
            this.txtVal.Size = new System.Drawing.Size(178, 26);
            this.txtVal.TabIndex = 0;
            this.txtVal.TextChanged += new System.EventHandler(this.txtVal_TextChanged);
            this.txtVal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVal_KeyPress);
            // 
            // UCBoutonIncrementer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnMM);
            this.Controls.Add(this.btnPP);
            this.Controls.Add(this.btnM);
            this.Controls.Add(this.btnP);
            this.Controls.Add(this.txtVal);
            this.Controls.Add(this.lblSymbole);
            this.Controls.Add(this.lblUnite);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UCBoutonIncrementer";
            this.Size = new System.Drawing.Size(447, 73);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblUnite;
        private System.Windows.Forms.Label lblSymbole;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Button btnMM;
        private System.Windows.Forms.Button btnPP;
        private System.Windows.Forms.Button btnM;
        private System.Windows.Forms.Button btnP;
        private System.Windows.Forms.TextBox txtVal;
    }
}
