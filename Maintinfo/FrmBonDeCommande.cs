using System.Windows.Forms;
using MaintinfoBo;
using MaintinfoBll;
using System;

namespace Maintinfo
{
    public partial class FrmBonDeCommande : Form
    {
        public FrmBonDeCommande()
        {
            InitializeComponent();
        }
        private void FrmBonDeCommande_FormClosing(object sender, FormClosingEventArgs e)
        {
            Methodes.Quitter(sender,e,"Quitter la création du Bon de Commande?");
        }

        private void buttonValider_Click(object sender, System.EventArgs e)
        {
            try
            {
                Article article = ArticleManager.SaisirArticle(textBoxArticle.Text);
            }
            catch (Exception)
            {
                //a faire
            }
        }

        private void buttonModifier_Click(object sender, System.EventArgs e)
        {

        }

        private void buttonCatalogue_Click(object sender, System.EventArgs e)
        {
            FrmCatalogue Catalogue = new FrmCatalogue();
            Catalogue.Owner = this;       
            Catalogue.Show();
            Catalogue.Focus();
        }

        private void buttonQuitter_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
