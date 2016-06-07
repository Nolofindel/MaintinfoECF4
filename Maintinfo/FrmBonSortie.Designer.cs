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
            this.components = new System.ComponentModel.Container();
            this.txtboxCodeArt = new System.Windows.Forms.TextBox();
            this.numericUpDownQte = new System.Windows.Forms.NumericUpDown();
            this.lblQuantite = new System.Windows.Forms.Label();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.lblCodeArt = new System.Windows.Forms.Label();
            this.buttonCatalogue = new System.Windows.Forms.Button();
            this.textBoxQuantiteStock = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboxDepanneur = new System.Windows.Forms.ComboBox();
            this.lblDepanneur = new System.Windows.Forms.Label();
            this.maintinfoDataSet = new Maintinfo.MaintinfoDataSet();
            this.recupererDepanneurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recupererDepanneurTableAdapter = new Maintinfo.MaintinfoDataSetTableAdapters.RecupererDepanneurTableAdapter();
            this.txtboxNomArticle = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintinfoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recupererDepanneurBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtboxCodeArt
            // 
            this.txtboxCodeArt.Location = new System.Drawing.Point(82, 40);
            this.txtboxCodeArt.Name = "txtboxCodeArt";
            this.txtboxCodeArt.Size = new System.Drawing.Size(38, 20);
            this.txtboxCodeArt.TabIndex = 11;
            // 
            // numericUpDownQte
            // 
            this.numericUpDownQte.Location = new System.Drawing.Point(82, 75);
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
            this.lblQuantite.Location = new System.Drawing.Point(29, 82);
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
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(285, 9);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 6;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // lblCodeArt
            // 
            this.lblCodeArt.AutoSize = true;
            this.lblCodeArt.Location = new System.Drawing.Point(12, 47);
            this.lblCodeArt.Name = "lblCodeArt";
            this.lblCodeArt.Size = new System.Drawing.Size(64, 13);
            this.lblCodeArt.TabIndex = 13;
            this.lblCodeArt.Text = "Code Article";
            // 
            // buttonCatalogue
            // 
            this.buttonCatalogue.Location = new System.Drawing.Point(285, 76);
            this.buttonCatalogue.Name = "buttonCatalogue";
            this.buttonCatalogue.Size = new System.Drawing.Size(75, 34);
            this.buttonCatalogue.TabIndex = 14;
            this.buttonCatalogue.Text = "Catalogue";
            this.buttonCatalogue.UseVisualStyleBackColor = true;
            this.buttonCatalogue.Click += new System.EventHandler(this.buttonCatalogue_Click);
            // 
            // textBoxQuantiteStock
            // 
            this.textBoxQuantiteStock.Location = new System.Drawing.Point(82, 110);
            this.textBoxQuantiteStock.Name = "textBoxQuantiteStock";
            this.textBoxQuantiteStock.ReadOnly = true;
            this.textBoxQuantiteStock.Size = new System.Drawing.Size(79, 20);
            this.textBoxQuantiteStock.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Stock";
            // 
            // cboxDepanneur
            // 
            this.cboxDepanneur.DataSource = this.recupererDepanneurBindingSource;
            this.cboxDepanneur.DisplayMember = "NOM_DEPANNEUR";
            this.cboxDepanneur.FormattingEnabled = true;
            this.cboxDepanneur.Location = new System.Drawing.Point(82, 145);
            this.cboxDepanneur.Name = "cboxDepanneur";
            this.cboxDepanneur.Size = new System.Drawing.Size(121, 21);
            this.cboxDepanneur.TabIndex = 17;
            this.cboxDepanneur.ValueMember = "NOM_DEPANNEUR";
            // 
            // lblDepanneur
            // 
            this.lblDepanneur.AutoSize = true;
            this.lblDepanneur.Location = new System.Drawing.Point(16, 153);
            this.lblDepanneur.Name = "lblDepanneur";
            this.lblDepanneur.Size = new System.Drawing.Size(60, 13);
            this.lblDepanneur.TabIndex = 18;
            this.lblDepanneur.Text = "Dépanneur";
            // 
            // maintinfoDataSet
            // 
            this.maintinfoDataSet.DataSetName = "MaintinfoDataSet";
            this.maintinfoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // recupererDepanneurBindingSource
            // 
            this.recupererDepanneurBindingSource.DataMember = "RecupererDepanneur";
            this.recupererDepanneurBindingSource.DataSource = this.maintinfoDataSet;
            // 
            // recupererDepanneurTableAdapter
            // 
            this.recupererDepanneurTableAdapter.ClearBeforeFill = true;
            // 
            // txtboxNomArticle
            // 
            this.txtboxNomArticle.Location = new System.Drawing.Point(124, 40);
            this.txtboxNomArticle.Name = "txtboxNomArticle";
            this.txtboxNomArticle.ReadOnly = true;
            this.txtboxNomArticle.Size = new System.Drawing.Size(79, 20);
            this.txtboxNomArticle.TabIndex = 19;
            // 
            // FrmBonSortie
            // 
            this.AcceptButton = this.btnValider;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 229);
            this.Controls.Add(this.txtboxNomArticle);
            this.Controls.Add(this.lblDepanneur);
            this.Controls.Add(this.cboxDepanneur);
            this.Controls.Add(this.textBoxQuantiteStock);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonCatalogue);
            this.Controls.Add(this.lblCodeArt);
            this.Controls.Add(this.txtboxCodeArt);
            this.Controls.Add(this.numericUpDownQte);
            this.Controls.Add(this.lblQuantite);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnValider);
            this.Name = "FrmBonSortie";
            this.Text = "Demande de Bon de Sortie";
            this.Load += new System.EventHandler(this.FrmBonSortie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintinfoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recupererDepanneurBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxCodeArt;
        private System.Windows.Forms.NumericUpDown numericUpDownQte;
        private System.Windows.Forms.Label lblQuantite;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Label lblCodeArt;
        private System.Windows.Forms.Button buttonCatalogue;
        private System.Windows.Forms.TextBox textBoxQuantiteStock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboxDepanneur;
        private System.Windows.Forms.Label lblDepanneur;
        private MaintinfoDataSet maintinfoDataSet;
        private System.Windows.Forms.BindingSource recupererDepanneurBindingSource;
        private MaintinfoDataSetTableAdapters.RecupererDepanneurTableAdapter recupererDepanneurTableAdapter;
        private System.Windows.Forms.TextBox txtboxNomArticle;
    }
}