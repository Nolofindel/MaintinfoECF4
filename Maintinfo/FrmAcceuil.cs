using System;
using System.Windows.Forms;


namespace Maintinfo
{
    public partial class FrmAcceuil : Form
    {
        public FrmAcceuil()
        {
            InitializeComponent();
        }
        #region Fenêtre

        
        private void cascadeToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
        }

        private void horisontalToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical);
        }
        #endregion

        private void bonDentréeToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
           FrmBonEntree BonEntree = new FrmBonEntree();
            BonEntree.MdiParent = this;
            BonEntree.Show();
        }

        private void bonDeSortieToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FrmBonSortie BonSortie = new FrmBonSortie();
            BonSortie.MdiParent = this;
            BonSortie.Show();
        }

        private void bonDeCommandeToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FrmBonDeCommande BonDeCommande = new FrmBonDeCommande();
            BonDeCommande.MdiParent = this;
            BonDeCommande.Show();
        }

        private void timerDate_Tick(object sender, System.EventArgs e)
        {
            toolStripStatusLabelDate.Text = DateTime.Now.ToString();
        }
    }
}
