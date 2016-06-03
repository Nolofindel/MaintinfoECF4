namespace Maintinfo
{
    partial class FrmBonSortie
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
            this.txtboxCodeArt = new System.Windows.Forms.TextBox();
            this.numericUpDownQte = new System.Windows.Forms.NumericUpDown();
            this.lblQuantite = new System.Windows.Forms.Label();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.lblSortieArt = new System.Windows.Forms.Label();
            this.lblCodeArt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQte)).BeginInit();
            this.SuspendLayout();
            // 
            // txtboxCodeArt
            // 
            this.txtboxCodeArt.Location = new System.Drawing.Point(123, 38);
            this.txtboxCodeArt.Name = "txtboxCodeArt";
            this.txtboxCodeArt.Size = new System.Drawing.Size(79, 20);
            this.txtboxCodeArt.TabIndex = 11;
            // 
            // numericUpDownQte
            // 
            this.numericUpDownQte.Location = new System.Drawing.Point(123, 64);
            this.numericUpDownQte.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownQte.Name = "numericUpDownQte";
            this.numericUpDownQte.Size = new System.Drawing.Size(79, 20);
            this.numericUpDownQte.TabIndex = 10;
            this.numericUpDownQte.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblQuantite
            // 
            this.lblQuantite.AutoSize = true;
            this.lblQuantite.Location = new System.Drawing.Point(70, 71);
            this.lblQuantite.Name = "lblQuantite";
            this.lblQuantite.Size = new System.Drawing.Size(47, 13);
            this.lblQuantite.TabIndex = 9;
            this.lblQuantite.Text = "Quantité";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(285, 38);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 7;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(285, 9);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 6;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            // 
            // lblSortieArt
            // 
            this.lblSortieArt.AutoSize = true;
            this.lblSortieArt.Location = new System.Drawing.Point(15, 9);
            this.lblSortieArt.Name = "lblSortieArt";
            this.lblSortieArt.Size = new System.Drawing.Size(135, 13);
            this.lblSortieArt.TabIndex = 12;
            this.lblSortieArt.Text = "Demande de sortie d\'article";
            // 
            // lblCodeArt
            // 
            this.lblCodeArt.AutoSize = true;
            this.lblCodeArt.Location = new System.Drawing.Point(53, 41);
            this.lblCodeArt.Name = "lblCodeArt";
            this.lblCodeArt.Size = new System.Drawing.Size(64, 13);
            this.lblCodeArt.TabIndex = 13;
            this.lblCodeArt.Text = "Code Article";
            // 
            // FrmBonSortie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 277);
            this.Controls.Add(this.lblCodeArt);
            this.Controls.Add(this.lblSortieArt);
            this.Controls.Add(this.txtboxCodeArt);
            this.Controls.Add(this.numericUpDownQte);
            this.Controls.Add(this.lblQuantite);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnValider);
            this.Name = "FrmBonSortie";
            this.Text = "FrmBonSortie";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxCodeArt;
        private System.Windows.Forms.NumericUpDown numericUpDownQte;
        private System.Windows.Forms.Label lblQuantite;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Label lblSortieArt;
        private System.Windows.Forms.Label lblCodeArt;
    }
}