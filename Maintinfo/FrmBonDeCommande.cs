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
        private bool Valide = false;
        private Article article = new Article();
        private BonDeCommande BdC;
        private void FrmBonDeCommande_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Valide)
            {
                Methodes.Quitter(sender, e, "Quitter la création du Bon de Commande?");
            }
        }
        void SelectionChange(object sender, EventArgs e, Article art)
        {
            textBoxArticle.Text = art.DesignationArticle.ToString();
        }
        private void buttonValider_Click(object sender, System.EventArgs e)
        {
            if (!Valide)
            {
                try
                {
                    article = ArticleManager.SaisirArticle(textBoxArticle.Text);
                }
                catch (Exception se)
                {
                    if (se.Message == "L'opération n'a pas été réalisée: \nInexistant")
                    {
                        DialogResult Erreur = MessageBox.Show("Article non trouvé voulez vous afficher le catalogue? ", "Erreur", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
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
                BdC = BonDeCommandeManager.CreerBonDeCommande(article);
                textBoxQuantiteStock.Text = article.QuantiteArticle.ToString();
                textBoxSeuilMinimal.Text = article.SeuilMinimal.ToString();
                int qte;
                if (textBoxQuantiteCommande.Text == string.Empty || !int.TryParse(textBoxQuantiteCommande.Text, out qte))
                {
                    Methodes.Erreur("Veuillez entrez une quanitité");

                }
                else
                {
                    BdC.QuantiteCommande = qte;
                    if (BonDeCommandeManager.TesterQuantiteSeuil(BdC))
                    {
                        Methodes.Apercu(BdC);
                        panelArticle.Enabled = false;
                        buttonCatalogue.Enabled = false;
                        Valide = true;
                    }
                    else
                    {
                        Methodes.Erreur("Veuillez entrez une quantité correct");
                    }
                }
            }
            else
            {
                try
                {
                    BonDeCommandeManager.EnregistrerBonDeCommande(BdC);
                    DialogResult Reussi = MessageBox.Show("Envoie Réussi", "Envoie", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    this.Close();
                }
                catch (Exception se)
                {
                    Methodes.Erreur(se);
                }
            }
        }

        private void buttonModifier_Click(object sender, System.EventArgs e)
        {
            panelArticle.Enabled = true;
            Valide = false;
            buttonCatalogue.Enabled = true;
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
