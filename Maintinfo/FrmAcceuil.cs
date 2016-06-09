using System;
using System.Windows.Forms;


namespace Maintinfo
{
    public partial class FrmAcceuil : Form
    {
        FrmBonDeCommande BonDeCommande;
        FrmBonEntree BonEntree;
        FrmBonSortie BonSortie;
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

        private void bonDentreeToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
                BonEntree = new FrmBonEntree();
                BonEntree.MdiParent = this;
                BonEntree.Show();
        }

        private void bonDeSortieToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            BonSortie = new FrmBonSortie();
            BonSortie.MdiParent = this;
            BonSortie.Show();
        }

        private void bonDeCommandeToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            BonDeCommande = new FrmBonDeCommande();
            BonDeCommande.MdiParent = this;
            BonDeCommande.Show();
        }

        private void timerDate_Tick(object sender, System.EventArgs e)
        {
            toolStripStatusLabelDate.Text = DateTime.Now.ToString();
        }

        private void FrmAcceuil_FormClosing(object sender, FormClosingEventArgs e)
        {
            Methodes.Quitter(sender, e,"Fin de la gestion?");
        }

        private void gestionDuStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BonEntree != null && BonEntree.Visible)
            {
                bonDentreeToolStripMenuItem.Enabled = false;
            }
            else
            {
                bonDentreeToolStripMenuItem.Enabled = true;
            }
            if (BonSortie != null && BonSortie.Visible)
            {
                bonDeSortieToolStripMenuItem.Enabled = false;
            }
            else
            {
                bonDeSortieToolStripMenuItem.Enabled = true;
            }
            if (BonDeCommande != null && BonDeCommande.Visible)
            {
                bonDeCommandeToolStripMenuItem.Enabled = false;
            }
            else
            {
                bonDeCommandeToolStripMenuItem.Enabled = true;
            }

        }


    }
}
