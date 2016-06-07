namespace Maintinfo
{
    partial class FrmAcceuil
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStripAccueil = new System.Windows.Forms.MenuStrip();
            this.bonDentréeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bonDeSortieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bonDeCommandeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fenetreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horisontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripAccueil = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerDate = new System.Windows.Forms.Timer(this.components);
            this.menuStripAccueil.SuspendLayout();
            this.statusStripAccueil.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripAccueil
            // 
            this.menuStripAccueil.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bonDentréeToolStripMenuItem,
            this.bonDeSortieToolStripMenuItem,
            this.bonDeCommandeToolStripMenuItem,
            this.fenetreToolStripMenuItem});
            this.menuStripAccueil.Location = new System.Drawing.Point(0, 0);
            this.menuStripAccueil.Name = "menuStripAccueil";
            this.menuStripAccueil.Size = new System.Drawing.Size(740, 24);
            this.menuStripAccueil.TabIndex = 1;
            this.menuStripAccueil.Text = "menuStrip1";
            // 
            // bonDentréeToolStripMenuItem
            // 
            this.bonDentréeToolStripMenuItem.Name = "bonDentréeToolStripMenuItem";
            this.bonDentréeToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.bonDentréeToolStripMenuItem.Text = "Bon d\'entrée";
            this.bonDentréeToolStripMenuItem.Click += new System.EventHandler(this.bonDentréeToolStripMenuItem_Click);
            // 
            // bonDeSortieToolStripMenuItem
            // 
            this.bonDeSortieToolStripMenuItem.Name = "bonDeSortieToolStripMenuItem";
            this.bonDeSortieToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.bonDeSortieToolStripMenuItem.Text = "Bon de sortie";
            this.bonDeSortieToolStripMenuItem.Click += new System.EventHandler(this.bonDeSortieToolStripMenuItem_Click);
            // 
            // bonDeCommandeToolStripMenuItem
            // 
            this.bonDeCommandeToolStripMenuItem.Name = "bonDeCommandeToolStripMenuItem";
            this.bonDeCommandeToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.bonDeCommandeToolStripMenuItem.Text = "Bon de commande";
            this.bonDeCommandeToolStripMenuItem.Click += new System.EventHandler(this.bonDeCommandeToolStripMenuItem_Click);
            // 
            // fenetreToolStripMenuItem
            // 
            this.fenetreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeToolStripMenuItem,
            this.horisontalToolStripMenuItem,
            this.verticalToolStripMenuItem});
            this.fenetreToolStripMenuItem.Name = "fenetreToolStripMenuItem";
            this.fenetreToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.fenetreToolStripMenuItem.Text = "Fenêtres";
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.cascadeToolStripMenuItem.Text = "Cascade";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.cascadeToolStripMenuItem_Click);
            // 
            // horisontalToolStripMenuItem
            // 
            this.horisontalToolStripMenuItem.Name = "horisontalToolStripMenuItem";
            this.horisontalToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.horisontalToolStripMenuItem.Text = "Horizontal";
            this.horisontalToolStripMenuItem.Click += new System.EventHandler(this.horisontalToolStripMenuItem_Click);
            // 
            // verticalToolStripMenuItem
            // 
            this.verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            this.verticalToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.verticalToolStripMenuItem.Text = "Vertical";
            this.verticalToolStripMenuItem.Click += new System.EventHandler(this.verticalToolStripMenuItem_Click);
            // 
            // statusStripAccueil
            // 
            this.statusStripAccueil.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelDate});
            this.statusStripAccueil.Location = new System.Drawing.Point(0, 240);
            this.statusStripAccueil.Name = "statusStripAccueil";
            this.statusStripAccueil.Size = new System.Drawing.Size(740, 22);
            this.statusStripAccueil.TabIndex = 2;
            this.statusStripAccueil.Text = "statusStrip1";
            // 
            // toolStripStatusLabelDate
            // 
            this.toolStripStatusLabelDate.Name = "toolStripStatusLabelDate";
            this.toolStripStatusLabelDate.Size = new System.Drawing.Size(31, 17);
            this.toolStripStatusLabelDate.Text = "Date";
            // 
            // timerDate
            // 
            this.timerDate.Tick += new System.EventHandler(this.timerDate_Tick);
            // 
            // FrmAcceuil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 262);
            this.Controls.Add(this.statusStripAccueil);
            this.Controls.Add(this.menuStripAccueil);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripAccueil;
            this.Name = "FrmAcceuil";
            this.Text = "Gestion du stock";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAcceuil_FormClosing);
            this.menuStripAccueil.ResumeLayout(false);
            this.menuStripAccueil.PerformLayout();
            this.statusStripAccueil.ResumeLayout(false);
            this.statusStripAccueil.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripAccueil;
        private System.Windows.Forms.ToolStripMenuItem bonDentréeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bonDeSortieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bonDeCommandeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fenetreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horisontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStripAccueil;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelDate;
        private System.Windows.Forms.Timer timerDate;
    }
}

