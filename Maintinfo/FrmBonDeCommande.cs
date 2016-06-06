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
            FrmCatalogue.OnCatalogueClosing += SelectionChange;
        }
        public delegate void CatalogueShow(object sender, EventArgs e);
        public static event CatalogueShow OnCatalogueShow;
        private void FrmBonDeCommande_FormClosing(object sender, FormClosingEventArgs e)
        {
            Methodes.Quitter(sender, e, "Quitter la création du Bon de Commande?");
        }
        void SelectionChange(object sender, EventArgs e, Article art)
        {
            textBoxArticle.Text = art.DesignationArticle.ToString();
        }
        private void buttonValider_Click(object sender, System.EventArgs e)
        {
            Article article = new Article();
            try
            {
                 article = ArticleManager.SaisirArticle(textBoxArticle.Text);
            }
            catch (Exception se)
            {
                if (se.Message == "L'opération n'a pas été réalisée: \nInexistant")
                {
                    DialogResult Erreur = MessageBox.Show("Article non trouvé voulez vous afficher le catalogue? ","Erreur", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    if (Erreur == DialogResult.Yes)
                    {
                        this.buttonCatalogue_Click(sender, e);
                    }
                    return;
                }
                else
                {
                    Methodes.Erreur(se);
                }
            }
            BonDeCommande BdC= BonDeCommandeManager.CreerBonDeCommande(article);
            textBoxQuantiteStock.Text = article.QuantiteArticle.ToString();
            textBoxSeuilMinimal.Text = article.SeuilMinimal.ToString();
            int qte;
            if (textBoxQuantiteCommande.Text == string.Empty || !int.TryParse(textBoxQuantiteCommande.Text,out qte))
            {
                Methodes.Erreur("Veuillez entrez une quanitité");
                
            }
            else
            {
                BdC.QuantiteCommande = qte;
                if (!BonDeCommandeManager.TesterQuantiteSeuil(BdC))
                {
                    Methodes.Erreur("Veuillez entrez une quantité correct");
                }
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
