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
            this.components = new System.ComponentModel.Container();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.lblRefArticle = new System.Windows.Forms.Label();
            this.lblQuantite = new System.Windows.Forms.Label();
            this.numericUpDownQuantite = new System.Windows.Forms.NumericUpDown();
            this.txtBoxRefArticle = new System.Windows.Forms.TextBox();
            this.dataGridViewBonEntree = new System.Windows.Forms.DataGridView();
            this.btnCatalogue = new System.Windows.Forms.Button();
            this.errorProviderBonEntree = new System.Windows.Forms.ErrorProvider(this.components);
            this.sousEnsembleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewComboBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.articleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bonEntreeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RefArticle = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.NomArticle = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.quantiteEntreeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateEntreeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBonEntree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBonEntree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sousEnsembleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bonEntreeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(283, 26);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 0;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(12, 221);
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
            this.lblRefArticle.Location = new System.Drawing.Point(33, 13);
            this.lblRefArticle.Name = "lblRefArticle";
            this.lblRefArticle.Size = new System.Drawing.Size(89, 13);
            this.lblRefArticle.TabIndex = 2;
            this.lblRefArticle.Text = "Réference Article";
            // 
            // lblQuantite
            // 
            this.lblQuantite.AutoSize = true;
            this.lblQuantite.Location = new System.Drawing.Point(158, 13);
            this.lblQuantite.Name = "lblQuantite";
            this.lblQuantite.Size = new System.Drawing.Size(47, 13);
            this.lblQuantite.TabIndex = 3;
            this.lblQuantite.Text = "Quantité";
            // 
            // numericUpDownQuantite
            // 
            this.numericUpDownQuantite.Location = new System.Drawing.Point(161, 29);
            this.numericUpDownQuantite.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
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
            this.txtBoxRefArticle.Location = new System.Drawing.Point(36, 29);
            this.txtBoxRefArticle.Name = "txtBoxRefArticle";
            this.txtBoxRefArticle.Size = new System.Drawing.Size(100, 20);
            this.txtBoxRefArticle.TabIndex = 5;
            // 
            // dataGridViewBonEntree
            // 
            this.dataGridViewBonEntree.AllowUserToAddRows = false;
            this.dataGridViewBonEntree.AllowUserToDeleteRows = false;
            this.dataGridViewBonEntree.AllowUserToResizeRows = false;
            this.dataGridViewBonEntree.AutoGenerateColumns = false;
            this.dataGridViewBonEntree.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.dataGridViewBonEntree.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridViewBonEntree.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBonEntree.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RefArticle,
            this.NomArticle,
            this.quantiteEntreeDataGridViewTextBoxColumn,
            this.dateEntreeDataGridViewTextBoxColumn});
            this.dataGridViewBonEntree.DataSource = this.bonEntreeBindingSource;
            this.dataGridViewBonEntree.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.dataGridViewBonEntree.Location = new System.Drawing.Point(12, 60);
            this.dataGridViewBonEntree.MultiSelect = false;
            this.dataGridViewBonEntree.Name = "dataGridViewBonEntree";
            this.dataGridViewBonEntree.ReadOnly = true;
            this.dataGridViewBonEntree.RowHeadersVisible = false;
            this.dataGridViewBonEntree.Size = new System.Drawing.Size(346, 150);
            this.dataGridViewBonEntree.TabIndex = 6;
            // 
            // btnCatalogue
            // 
            this.btnCatalogue.Location = new System.Drawing.Point(283, 221);
            this.btnCatalogue.Name = "btnCatalogue";
            this.btnCatalogue.Size = new System.Drawing.Size(75, 23);
            this.btnCatalogue.TabIndex = 7;
            this.btnCatalogue.Text = "Catalogue";
            this.btnCatalogue.UseVisualStyleBackColor = true;
            this.btnCatalogue.Click += new System.EventHandler(this.btnCatalogue_Click);
            // 
            // errorProviderBonEntree
            // 
            this.errorProviderBonEntree.ContainerControl = this;
            // 
            // sousEnsembleBindingSource
            // 
            this.sousEnsembleBindingSource.DataMember = "SousEnsemble";
            this.sousEnsembleBindingSource.DataSource = this.articleBindingSource;
            // 
            // dataGridViewComboBoxColumn1
            // 
            this.dataGridViewComboBoxColumn1.DataPropertyName = "ArticleEntree";
            this.dataGridViewComboBoxColumn1.HeaderText = "Réf article";
            this.dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            this.dataGridViewComboBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewComboBoxColumn2
            // 
            this.dataGridViewComboBoxColumn2.DataPropertyName = "ArticleEntree";
            this.dataGridViewComboBoxColumn2.DataSource = this.sousEnsembleBindingSource;
            this.dataGridViewComboBoxColumn2.DisplayMember = "NomArticle";
            this.dataGridViewComboBoxColumn2.HeaderText = "Nom article";
            this.dataGridViewComboBoxColumn2.Name = "dataGridViewComboBoxColumn2";
            this.dataGridViewComboBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewComboBoxColumn2.ValueMember = "DesignationArticle";
            // 
            // articleBindingSource
            // 
            this.articleBindingSource.DataSource = typeof(MaintinfoBo.Article);
            // 
            // bonEntreeBindingSource
            // 
            this.bonEntreeBindingSource.DataSource = typeof(MaintinfoBo.BonEntree);
            // 
            // RefArticle
            // 
            this.RefArticle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RefArticle.DataPropertyName = "ArticleEntree";
            this.RefArticle.DataSource = this.articleBindingSource;
            this.RefArticle.DisplayMember = "DesignationArticle";
            this.RefArticle.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.RefArticle.HeaderText = "Réf article";
            this.RefArticle.Name = "RefArticle";
            this.RefArticle.ReadOnly = true;
            this.RefArticle.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.RefArticle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.RefArticle.ValueMember = "Self";
            // 
            // NomArticle
            // 
            this.NomArticle.DataPropertyName = "ArticleEntree";
            this.NomArticle.DataSource = this.articleBindingSource;
            this.NomArticle.DisplayMember = "NomArticle";
            this.NomArticle.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.NomArticle.HeaderText = "Nom article";
            this.NomArticle.Name = "NomArticle";
            this.NomArticle.ReadOnly = true;
            this.NomArticle.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NomArticle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.NomArticle.ValueMember = "Self";
            // 
            // quantiteEntreeDataGridViewTextBoxColumn
            // 
            this.quantiteEntreeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quantiteEntreeDataGridViewTextBoxColumn.DataPropertyName = "QuantiteEntree";
            this.quantiteEntreeDataGridViewTextBoxColumn.HeaderText = "QuantiteEntree";
            this.quantiteEntreeDataGridViewTextBoxColumn.Name = "quantiteEntreeDataGridViewTextBoxColumn";
            this.quantiteEntreeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateEntreeDataGridViewTextBoxColumn
            // 
            this.dateEntreeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateEntreeDataGridViewTextBoxColumn.DataPropertyName = "DateEntree";
            this.dateEntreeDataGridViewTextBoxColumn.HeaderText = "DateEntree";
            this.dateEntreeDataGridViewTextBoxColumn.Name = "dateEntreeDataGridViewTextBoxColumn";
            this.dateEntreeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FrmBonEntree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 256);
            this.Controls.Add(this.btnCatalogue);
            this.Controls.Add(this.dataGridViewBonEntree);
            this.Controls.Add(this.txtBoxRefArticle);
            this.Controls.Add(this.numericUpDownQuantite);
            this.Controls.Add(this.lblQuantite);
            this.Controls.Add(this.lblRefArticle);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnValider);
            this.Name = "FrmBonEntree";
            this.Text = "Entree stock";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBonEntree_FormClosing);
            this.Load += new System.EventHandler(this.FrmBonEntree_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBonEntree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBonEntree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sousEnsembleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bonEntreeBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridViewBonEntree;
        private System.Windows.Forms.Button btnCatalogue;
        private System.Windows.Forms.ErrorProvider errorProviderBonEntree;
        private System.Windows.Forms.BindingSource bonEntreeBindingSource;
        private System.Windows.Forms.BindingSource articleBindingSource;
        private System.Windows.Forms.BindingSource sousEnsembleBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn RefArticle;
        private System.Windows.Forms.DataGridViewComboBoxColumn NomArticle;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantiteEntreeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateEntreeDataGridViewTextBoxColumn;
    }
}