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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblQuantite = new System.Windows.Forms.Label();
            this.lblRefArticle = new System.Windows.Forms.Label();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.lblNumEnreg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 11;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(123, 161);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(79, 20);
            this.numericUpDown1.TabIndex = 10;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblQuantite
            // 
            this.lblQuantite.AutoSize = true;
            this.lblQuantite.Location = new System.Drawing.Point(120, 145);
            this.lblQuantite.Name = "lblQuantite";
            this.lblQuantite.Size = new System.Drawing.Size(47, 13);
            this.lblQuantite.TabIndex = 9;
            this.lblQuantite.Text = "Quantité";
            // 
            // lblRefArticle
            // 
            this.lblRefArticle.AutoSize = true;
            this.lblRefArticle.Location = new System.Drawing.Point(12, 145);
            this.lblRefArticle.Name = "lblRefArticle";
            this.lblRefArticle.Size = new System.Drawing.Size(89, 13);
            this.lblRefArticle.TabIndex = 8;
            this.lblRefArticle.Text = "Réference Article";
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
            // lblNumEnreg
            // 
            this.lblNumEnreg.AutoSize = true;
            this.lblNumEnreg.Location = new System.Drawing.Point(15, 9);
            this.lblNumEnreg.Name = "lblNumEnreg";
            this.lblNumEnreg.Size = new System.Drawing.Size(92, 13);
            this.lblNumEnreg.TabIndex = 12;
            this.lblNumEnreg.Text = "N° Enregistrement";
            // 
            // FrmBonSortie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 277);
            this.Controls.Add(this.lblNumEnreg);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lblQuantite);
            this.Controls.Add(this.lblRefArticle);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnValider);
            this.Name = "FrmBonSortie";
            this.Text = "FrmBonSortie";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lblQuantite;
        private System.Windows.Forms.Label lblRefArticle;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Label lblNumEnreg;
    }
}