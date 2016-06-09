using System;

using System.Windows.Forms;
using MaintinfoBll;
using MaintinfoBo;
namespace Maintinfo
{
    public partial class FrmBonEntree : Form
    {
        public FrmBonEntree()
        {
            InitializeComponent();
            FrmCatalogue.OnCatalogueClosing += SelectionChange;
        }
        private void FrmBonEntree_Load(object sender, EventArgs e)
        {            
            
        }
        void SelectionChange(object sender, EventArgs e, Article art)
        {
            txtBoxRefArticle.Text = art.DesignationArticle.ToString();
        }
        private void btnValider_Click(object sender,EventArgs e)
        {
            if (Methodes.IsValideArticleSaisi(txtBoxRefArticle,errorProviderBonEntree))
            {
                string refArt = txtBoxRefArticle.Text;
                int quant = (int)numericUpDownQuantite.Value;
                BonEntree newBE = new BonEntree();
                BonEntreeManager newBeM = new BonEntreeManager();
                try
                {
                    newBE = newBeM.CreerBonEntree(refArt,quant);
                    if (newBeM.EnregistrerBonEntree(newBE))
                    {
                        MessageBox.Show("Article " + newBE.ArticleEntree.DesignationArticle + " : " + newBE.ArticleEntree.NomArticle + " Ajouter au stock", "Bon d'entrée ajouter", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        articleBindingSource.Add(newBE.ArticleEntree);
                        bonEntreeBindingSource.Add(newBE);
                        ResetBox();
                    }

                }
                catch (Exception ex)
                {
                    if (ex.Message == "L'opération n'a pas été réalisée: \nInexistant")
                    {
                        DialogResult Erreur = MessageBox.Show("Article non trouvé voulez vous afficher le catalogue? ", "Erreur", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        if (Erreur == DialogResult.Yes)
                        {
                            this.btnCatalogue_Click(sender, e);
                        }
                        return;
                    }
                    else
                    {
                        Methodes.Erreur(ex);
                    }
                    Methodes.Erreur("Article " + newBE.ArticleEntree.DesignationArticle + " : " + newBE.ArticleEntree.NomArticle + " Non ajouter au stock");
                    Methodes.Erreur(ex);
                }

            }

        }

        private void btnAnnuler_Click(object sender, System.EventArgs e)
        {
            ResetBox();
        }
        private void ResetBox()
        {
            txtBoxRefArticle.Clear();
            numericUpDownQuantite.Value = numericUpDownQuantite.Minimum;
            errorProviderBonEntree.Clear();
        }


        private void FrmBonEntree_FormClosing(object sender, FormClosingEventArgs e)
        {
            Methodes.Quitter(sender, e, "Fin des entrées articles?");
        }

        private void btnCatalogue_Click(object sender, EventArgs e)
        {
            FrmCatalogue Catalogue = new FrmCatalogue();
            Catalogue.Owner = this;
            Catalogue.Show();
            Catalogue.Focus();
        }
    }
}
