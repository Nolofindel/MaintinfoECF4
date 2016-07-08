using System.Windows.Forms;
using MaintinfoBo;
using MaintinfoBll;
using System;

namespace Maintinfo
{
    public partial class FrmBonSortie : Form
    {
        public delegate void CatalogueShow(object sender, EventArgs e);
        private Article article = new Article();
        private BonSortie BdS;
        private ArticleManager articleMgr= new ArticleManager();
        private BonSortieManager BdSMgr=new BonSortieManager();
        public FrmBonSortie()
        {
            InitializeComponent();
            FrmCatalogue.OnCatalogueClosing += SelectionChange;
        }


        void SelectionChange(object sender, EventArgs e, Article art)
        {
            txtboxCodeArt.Text = art.DesignationArticle.ToString();
            article = articleMgr.SaisirArticle(txtboxCodeArt.Text);
            textBoxQuantiteStock.Text = article.QuantiteArticle.ToString();
            txtboxNomArticle.Text = article.NomArticle;
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

        private void btnValider_Click(object sender, EventArgs e)
        {
            try
            {
                article = articleMgr.SaisirArticle(txtboxCodeArt.Text);
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
            if (cboxDepanneur.SelectedIndex == -1)
            {
                Methodes.Erreur("Veuillez selectionner le dépanneur");
                cboxDepanneur.Focus();

            }
            else
            {
                BdS = BdSMgr.CreerBonSortie(article);
                BdS.Quantite = ((int)numericUpDownQte.Value);
                BdS.LeDepanneur.NomDepanneur = cboxDepanneur.SelectedValue.ToString();
                Methodes.Apercu(BdS, BdSMgr);
            }


        }

        private void FrmBonSortie_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'maintinfoDataSet.RecupererDepanneur'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            //this.recupererDepanneurTableAdapter.Fill(this.maintinfoDataSet.RecupererDepanneur);
            cboxDepanneur.DataSource = BdSMgr.lesDepanneurs();

            cboxDepanneur.SelectedIndex = -1;
        }
    }
}
