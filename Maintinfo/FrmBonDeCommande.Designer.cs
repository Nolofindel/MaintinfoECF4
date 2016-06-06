namespace Maintinfo
{
    partial class FrmBonDeCommande
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
            this.buttonValider = new System.Windows.Forms.Button();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.buttonCatalogue = new System.Windows.Forms.Button();
            this.buttonQuitter = new System.Windows.Forms.Button();
            this.panelArticle = new System.Windows.Forms.Panel();
            this.textBoxQuantiteStock = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSeuilMinimal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxQuantiteCommande = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxArticle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelArticle.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonValider
            // 
            this.buttonValider.Location = new System.Drawing.Point(289, 12);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(89, 35);
            this.buttonValider.TabIndex = 0;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // buttonModifier
            // 
            this.buttonModifier.Location = new System.Drawing.Point(289, 53);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(89, 34);
            this.buttonModifier.TabIndex = 1;
            this.buttonModifier.Text = "Modifier";
            this.buttonModifier.UseVisualStyleBackColor = true;
            this.buttonModifier.Click += new System.EventHandler(this.buttonModifier_Click);
            // 
            // buttonCatalogue
            // 
            this.buttonCatalogue.Location = new System.Drawing.Point(289, 93);
            this.buttonCatalogue.Name = "buttonCatalogue";
            this.buttonCatalogue.Size = new System.Drawing.Size(89, 34);
            this.buttonCatalogue.TabIndex = 2;
            this.buttonCatalogue.Text = "Catalogue";
            this.buttonCatalogue.UseVisualStyleBackColor = true;
            this.buttonCatalogue.Click += new System.EventHandler(this.buttonCatalogue_Click);
            // 
            // buttonQuitter
            // 
            this.buttonQuitter.Location = new System.Drawing.Point(289, 133);
            this.buttonQuitter.Name = "buttonQuitter";
            this.buttonQuitter.Size = new System.Drawing.Size(89, 34);
            this.buttonQuitter.TabIndex = 3;
            this.buttonQuitter.Text = "Quitter";
            this.buttonQuitter.UseVisualStyleBackColor = true;
            this.buttonQuitter.Click += new System.EventHandler(this.buttonQuitter_Click);
            // 
            // panelArticle
            // 
            this.panelArticle.Controls.Add(this.textBoxQuantiteStock);
            this.panelArticle.Controls.Add(this.label4);
            this.panelArticle.Controls.Add(this.textBoxSeuilMinimal);
            this.panelArticle.Controls.Add(this.label3);
            this.panelArticle.Controls.Add(this.textBoxQuantiteCommande);
            this.panelArticle.Controls.Add(this.label2);
            this.panelArticle.Controls.Add(this.textBoxArticle);
            this.panelArticle.Controls.Add(this.label1);
            this.panelArticle.Location = new System.Drawing.Point(12, 12);
            this.panelArticle.Name = "panelArticle";
            this.panelArticle.Size = new System.Drawing.Size(248, 155);
            this.panelArticle.TabIndex = 4;
            // 
            // textBoxQuantiteStock
            // 
            this.textBoxQuantiteStock.Location = new System.Drawing.Point(145, 34);
            this.textBoxQuantiteStock.Name = "textBoxQuantiteStock";
            this.textBoxQuantiteStock.ReadOnly = true;
            this.textBoxQuantiteStock.Size = new System.Drawing.Size(100, 20);
            this.textBoxQuantiteStock.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Quantité en Stock";
            // 
            // textBoxSeuilMinimal
            // 
            this.textBoxSeuilMinimal.Location = new System.Drawing.Point(145, 60);
            this.textBoxSeuilMinimal.Name = "textBoxSeuilMinimal";
            this.textBoxSeuilMinimal.ReadOnly = true;
            this.textBoxSeuilMinimal.Size = new System.Drawing.Size(100, 20);
            this.textBoxSeuilMinimal.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "SeuilMinimal";
            // 
            // textBoxQuantiteCommande
            // 
            this.textBoxQuantiteCommande.Location = new System.Drawing.Point(145, 89);
            this.textBoxQuantiteCommande.Name = "textBoxQuantiteCommande";
            this.textBoxQuantiteCommande.Size = new System.Drawing.Size(100, 20);
            this.textBoxQuantiteCommande.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Quantité à Commander";
            // 
            // textBoxArticle
            // 
            this.textBoxArticle.Location = new System.Drawing.Point(145, 8);
            this.textBoxArticle.Name = "textBoxArticle";
            this.textBoxArticle.Size = new System.Drawing.Size(100, 20);
            this.textBoxArticle.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Article";
            // 
            // FrmBonDeCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 202);
            this.Controls.Add(this.panelArticle);
            this.Controls.Add(this.buttonQuitter);
            this.Controls.Add(this.buttonCatalogue);
            this.Controls.Add(this.buttonModifier);
            this.Controls.Add(this.buttonValider);
            this.Name = "FrmBonDeCommande";
            this.Text = "FrmBonDeCommande";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBonDeCommande_FormClosing);
            this.panelArticle.ResumeLayout(false);
            this.panelArticle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.Button buttonModifier;
        private System.Windows.Forms.Button buttonCatalogue;
        private System.Windows.Forms.Button buttonQuitter;
        private System.Windows.Forms.Panel panelArticle;
        private System.Windows.Forms.TextBox textBoxArticle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxQuantiteStock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSeuilMinimal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxQuantiteCommande;
        private System.Windows.Forms.Label label2;
    }
}