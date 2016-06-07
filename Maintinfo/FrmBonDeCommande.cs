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
            //Ecoute l'évenement dans le formulaire Catalogue
            FrmCatalogue.OnCatalogueClosing += SelectionChange;
        }
        private bool Valide = false;
        private Article article = new Article();
        private BonDeCommande BdC;
        private void FrmBonDeCommande_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Test si Valide pour quitter le formulaire sans demande de confirmation
            if (!Valide)
            {
                Methodes.Quitter(sender, e, "Quitter la création du Bon de Commande?");
            }
        }
        //Méthode appelé par l'écouteur
        void SelectionChange(object sender, EventArgs e, Article art)
        {
            textBoxArticle.Text = art.DesignationArticle.ToString();
            article= ArticleManager.SaisirArticle(textBoxArticle.Text);
            RemplirTextes(true);
        }

        //Valide la quantité entrée puis l'envoie du bon de commande après aperçu
        private void buttonValider_Click(object sender, System.EventArgs e)
        {
            if (!Valide)
            {
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
                    //Envoie du Bon de Commande
                    BonDeCommandeManager.EnregistrerBonDeCommande(BdC);
                    DepartementFabrication implementation = new ImplementationDepartementFabrication();
                    implementation.EnvoyerBondeCommande(BdC);
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

        //Crée un formulaire Catalogue
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

        private void textBoxArticle_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                article = ArticleManager.SaisirArticle(textBoxArticle.Text);
            }
            catch (Exception se)
            {
                if (se.Message == "L'opération n'a pas été réalisée: \nInexistant")
                {
                    article = null;
                    Valide = false;
                    RemplirTextes(false);
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
            RemplirTextes(true);
        }
        //Remplit les champs du formuaire et initialise le bon de commande
        private void RemplirTextes(bool b)
        {
            if (b) {
            BdC = BonDeCommandeManager.CreerBonDeCommande(article);
            textBoxQuantiteStock.Text = article.QuantiteArticle.ToString();
            textBoxSeuilMinimal.Text = article.SeuilMinimal.ToString();
            }
            else
            {
                BdC = null;
                textBoxQuantiteStock.Text = string.Empty;
                textBoxSeuilMinimal.Text = string.Empty;
            }
        }

    }
}
