namespace Form_Sae24_Stargate
{
    partial class FormConfirmation
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
            this.lblRecapPlanete = new System.Windows.Forms.Label();
            this.lblRecapDates = new System.Windows.Forms.Label();
            this.lblRecapChef = new System.Windows.Forms.Label();
            this.lblRecapBudget = new System.Windows.Forms.Label();
            this.lblRecapDataBaz = new System.Windows.Forms.Label();
            this.lstRecapEquipe = new System.Windows.Forms.ListBox();
            this.btnRefuser = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.lstRecapCaptures = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblRecapPlanete
            // 
            this.lblRecapPlanete.AutoSize = true;
            this.lblRecapPlanete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecapPlanete.Location = new System.Drawing.Point(53, 25);
            this.lblRecapPlanete.Name = "lblRecapPlanete";
            this.lblRecapPlanete.Size = new System.Drawing.Size(79, 29);
            this.lblRecapPlanete.TabIndex = 0;
            this.lblRecapPlanete.Text = "label1";
            // 
            // lblRecapDates
            // 
            this.lblRecapDates.AutoSize = true;
            this.lblRecapDates.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecapDates.Location = new System.Drawing.Point(53, 143);
            this.lblRecapDates.Name = "lblRecapDates";
            this.lblRecapDates.Size = new System.Drawing.Size(79, 29);
            this.lblRecapDates.TabIndex = 1;
            this.lblRecapDates.Text = "label1";
            // 
            // lblRecapChef
            // 
            this.lblRecapChef.AutoSize = true;
            this.lblRecapChef.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecapChef.Location = new System.Drawing.Point(53, 113);
            this.lblRecapChef.Name = "lblRecapChef";
            this.lblRecapChef.Size = new System.Drawing.Size(79, 29);
            this.lblRecapChef.TabIndex = 2;
            this.lblRecapChef.Text = "label1";
            // 
            // lblRecapBudget
            // 
            this.lblRecapBudget.AutoSize = true;
            this.lblRecapBudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecapBudget.Location = new System.Drawing.Point(53, 84);
            this.lblRecapBudget.Name = "lblRecapBudget";
            this.lblRecapBudget.Size = new System.Drawing.Size(79, 29);
            this.lblRecapBudget.TabIndex = 3;
            this.lblRecapBudget.Text = "label1";
            // 
            // lblRecapDataBaz
            // 
            this.lblRecapDataBaz.AutoSize = true;
            this.lblRecapDataBaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecapDataBaz.Location = new System.Drawing.Point(53, 54);
            this.lblRecapDataBaz.Name = "lblRecapDataBaz";
            this.lblRecapDataBaz.Size = new System.Drawing.Size(79, 29);
            this.lblRecapDataBaz.TabIndex = 4;
            this.lblRecapDataBaz.Text = "label1";
            // 
            // lstRecapEquipe
            // 
            this.lstRecapEquipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstRecapEquipe.FormattingEnabled = true;
            this.lstRecapEquipe.ItemHeight = 29;
            this.lstRecapEquipe.Location = new System.Drawing.Point(59, 175);
            this.lstRecapEquipe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstRecapEquipe.Name = "lstRecapEquipe";
            this.lstRecapEquipe.Size = new System.Drawing.Size(763, 352);
            this.lstRecapEquipe.TabIndex = 5;
            // 
            // btnRefuser
            // 
            this.btnRefuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefuser.ForeColor = System.Drawing.Color.Black;
            this.btnRefuser.Location = new System.Drawing.Point(416, 853);
            this.btnRefuser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefuser.Name = "btnRefuser";
            this.btnRefuser.Size = new System.Drawing.Size(201, 34);
            this.btnRefuser.TabIndex = 6;
            this.btnRefuser.Text = "Annuler";
            this.btnRefuser.UseVisualStyleBackColor = true;
            this.btnRefuser.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnValider
            // 
            this.btnValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.ForeColor = System.Drawing.Color.Black;
            this.btnValider.Location = new System.Drawing.Point(640, 853);
            this.btnValider.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(201, 34);
            this.btnValider.TabIndex = 7;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // lstRecapCaptures
            // 
            this.lstRecapCaptures.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstRecapCaptures.FormattingEnabled = true;
            this.lstRecapCaptures.ItemHeight = 29;
            this.lstRecapCaptures.Location = new System.Drawing.Point(59, 554);
            this.lstRecapCaptures.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstRecapCaptures.Name = "lstRecapCaptures";
            this.lstRecapCaptures.Size = new System.Drawing.Size(763, 236);
            this.lstRecapCaptures.TabIndex = 8;
            // 
            // FormConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(849, 901);
            this.Controls.Add(this.lstRecapCaptures);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnRefuser);
            this.Controls.Add(this.lstRecapEquipe);
            this.Controls.Add(this.lblRecapDataBaz);
            this.Controls.Add(this.lblRecapBudget);
            this.Controls.Add(this.lblRecapChef);
            this.Controls.Add(this.lblRecapDates);
            this.Controls.Add(this.lblRecapPlanete);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormConfirmation";
            this.ShowIcon = false;
            this.Text = "Recapitulatif";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormConfirmation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRecapPlanete;
        private System.Windows.Forms.Label lblRecapDates;
        private System.Windows.Forms.Label lblRecapChef;
        private System.Windows.Forms.Label lblRecapBudget;
        private System.Windows.Forms.Label lblRecapDataBaz;
        private System.Windows.Forms.ListBox lstRecapEquipe;
        private System.Windows.Forms.Button btnRefuser;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.ListBox lstRecapCaptures;
    }
}