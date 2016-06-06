using System.Windows.Forms;
using MaintinfoBo;
using MaintinfoBll;
using System;

namespace Maintinfo
{
    public partial class FrmBonSortie : Form
    {
        public FrmBonSortie()
        {
            InitializeComponent();
            FrmCatalogue.OnCatalogueClosing += SelectionChange;
        }
        public delegate void CatalogueShow(object sender, EventArgs e);
        private Article article = new Article();

        void SelectionChange(object sender, EventArgs e, Article art)
        {
            txtboxCodeArt.Text = art.DesignationArticle.ToString();
            article = ArticleManager.SaisirArticle(txtboxCodeArt.Text);
            textBoxQuantiteStock.Text = article.QuantiteArticle.ToString();
        }

        //Affichage du catalogue pour choix
        private void buttonCatalogue_Click(object sender, EventArgs e)
        {
            FrmCatalogue Catalogue = new FrmCatalogue();
            Catalogue.Owner = this;
            Catalogue.Show();
            Catalogue.Focus();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
