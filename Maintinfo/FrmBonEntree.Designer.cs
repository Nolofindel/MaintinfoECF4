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
            this.bonEntreeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.errorProviderBonEntree = new System.Windows.Forms.ErrorProvider(this.components);
            this.articleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.articleEntreeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.quantiteEntreeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateEntreeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBonEntree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bonEntreeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBonEntree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articleBindingSource)).BeginInit();
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
            this.dataGridViewBonEntree.AutoGenerateColumns = false;
            this.dataGridViewBonEntree.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBonEntree.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.articleEntreeDataGridViewTextBoxColumn,
            this.quantiteEntreeDataGridViewTextBoxColumn,
            this.dateEntreeDataGridViewTextBoxColumn});
            this.dataGridViewBonEntree.DataSource = this.bonEntreeBindingSource;
            this.dataGridViewBonEntree.Location = new System.Drawing.Point(12, 60);
            this.dataGridViewBonEntree.Name = "dataGridViewBonEntree";
            this.dataGridViewBonEntree.ReadOnly = true;
            this.dataGridViewBonEntree.Size = new System.Drawing.Size(346, 150);
            this.dataGridViewBonEntree.TabIndex = 6;
            // 
            // bonEntreeBindingSource
            // 
            this.bonEntreeBindingSource.DataSource = typeof(MaintinfoBo.BonEntree);
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Location = new System.Drawing.Point(283, 221);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmer.TabIndex = 7;
            this.btnConfirmer.Text = "Confirmer";
            this.btnConfirmer.UseVisualStyleBackColor = true;
            // 
            // errorProviderBonEntree
            // 
            this.errorProviderBonEntree.ContainerControl = this;
            // 
            // articleBindingSource
            // 
            this.articleBindingSource.DataSource = typeof(MaintinfoBo.Article);
            // 
            // articleEntreeDataGridViewTextBoxColumn
            // 
            this.articleEntreeDataGridViewTextBoxColumn.DataPropertyName = "ArticleEntree";
            this.articleEntreeDataGridViewTextBoxColumn.DataSource = this.articleBindingSource;
            this.articleEntreeDataGridViewTextBoxColumn.DisplayMember = "DesignationArticle";
            this.articleEntreeDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.articleEntreeDataGridViewTextBoxColumn.HeaderText = "ArticleEntree";
            this.articleEntreeDataGridViewTextBoxColumn.Name = "articleEntreeDataGridViewTextBoxColumn";
            this.articleEntreeDataGridViewTextBoxColumn.ReadOnly = true;
            this.articleEntreeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.articleEntreeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.articleEntreeDataGridViewTextBoxColumn.ValueMember = "DesignationArticle";
            // 
            // quantiteEntreeDataGridViewTextBoxColumn
            // 
            this.quantiteEntreeDataGridViewTextBoxColumn.DataPropertyName = "QuantiteEntree";
            this.quantiteEntreeDataGridViewTextBoxColumn.HeaderText = "QuantiteEntree";
            this.quantiteEntreeDataGridViewTextBoxColumn.Name = "quantiteEntreeDataGridViewTextBoxColumn";
            this.quantiteEntreeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateEntreeDataGridViewTextBoxColumn
            // 
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
            this.Controls.Add(this.btnConfirmer);
            this.Controls.Add(this.dataGridViewBonEntree);
            this.Controls.Add(this.txtBoxRefArticle);
            this.Controls.Add(this.numericUpDownQuantite);
            this.Controls.Add(this.lblQuantite);
            this.Controls.Add(this.lblRefArticle);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnValider);
            this.Name = "FrmBonEntree";
            this.Text = "FrmBonEntree";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBonEntree_FormClosing);
            this.Load += new System.EventHandler(this.FrmBonEntree_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBonEntree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bonEntreeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBonEntree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articleBindingSource)).EndInit();
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
        private System.Windows.Forms.Button btnConfirmer;
        private System.Windows.Forms.ErrorProvider errorProviderBonEntree;
        private System.Windows.Forms.BindingSource bonEntreeBindingSource;
        private System.Windows.Forms.BindingSource articleBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn articleEntreeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantiteEntreeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateEntreeDataGridViewTextBoxColumn;
    }
}