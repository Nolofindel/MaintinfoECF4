namespace Maintinfo
{
    partial class FrmBonEntree
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
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.lblRefArticle = new System.Windows.Forms.Label();
            this.lblQuantite = new System.Windows.Forms.Label();
            this.numericUpDownQuantite = new System.Windows.Forms.NumericUpDown();
            this.txtBoxRefArticle = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantite)).BeginInit();
            this.SuspendLayout();
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(283, 12);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 0;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(283, 41);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 1;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // lblRefArticle
            // 
            this.lblRefArticle.AutoSize = true;
            this.lblRefArticle.Location = new System.Drawing.Point(10, 12);
            this.lblRefArticle.Name = "lblRefArticle";
            this.lblRefArticle.Size = new System.Drawing.Size(89, 13);
            this.lblRefArticle.TabIndex = 2;
            this.lblRefArticle.Text = "Réference Article";
            // 
            // lblQuantite
            // 
            this.lblQuantite.AutoSize = true;
            this.lblQuantite.Location = new System.Drawing.Point(136, 12);
            this.lblQuantite.Name = "lblQuantite";
            this.lblQuantite.Size = new System.Drawing.Size(47, 13);
            this.lblQuantite.TabIndex = 3;
            this.lblQuantite.Text = "Quantité";
            // 
            // numericUpDownQuantite
            // 
            this.numericUpDownQuantite.Location = new System.Drawing.Point(139, 28);
            this.numericUpDownQuantite.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownQuantite.Name = "numericUpDownQuantite";
            this.numericUpDownQuantite.Size = new System.Drawing.Size(79, 20);
            this.numericUpDownQuantite.TabIndex = 4;
            this.numericUpDownQuantite.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtBoxRefArticle
            // 
            this.txtBoxRefArticle.Location = new System.Drawing.Point(13, 29);
            this.txtBoxRefArticle.Name = "txtBoxRefArticle";
            this.txtBoxRefArticle.Size = new System.Drawing.Size(100, 20);
            this.txtBoxRefArticle.TabIndex = 5;
            // 
            // FrmBonEntree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 199);
            this.Controls.Add(this.txtBoxRefArticle);
            this.Controls.Add(this.numericUpDownQuantite);
            this.Controls.Add(this.lblQuantite);
            this.Controls.Add(this.lblRefArticle);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnValider);
            this.Name = "FrmBonEntree";
            this.Text = "FrmBonEntree";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Label lblRefArticle;
        private System.Windows.Forms.Label lblQuantite;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantite;
        private System.Windows.Forms.TextBox txtBoxRefArticle;
    }
}