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
        }
        private void FrmBonEntree_Load(object sender, EventArgs e)
        {

        }

        private void btnValider_Click(object sender,EventArgs e)
        {
            if (IsValideArticleSaisi())
            {
                string refArt = txtBoxRefArticle.Text;
                int quant = (int)numericUpDownQuantite.Value;
                BonEntree newBE = BonEntreeManager.CreerBonEntree(refArt,quant);

                if (BonEntreeManager.EnregistrerBonEntree(newBE))
                {
                    MessageBox.Show("Bon d'entrée ajouter", "Article " + newBE.ArticleEntree.DesignationArticle + " : " + newBE.ArticleEntree.NomArticle + " Ajouter au stock", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erreurr", "Article " + newBE.ArticleEntree.DesignationArticle+" : " + newBE.ArticleEntree.NomArticle + " Non ajouter au stock", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }

        }

        private void btnAnnuler_Click(object sender, System.EventArgs e)
        {
            ResetText();
        }
        private void ResetBox()
        {
            txtBoxRefArticle.Clear();
            numericUpDownQuantite.ResetText();
            errorProviderBonEntree.Clear();
        }
        private bool IsValideArticleSaisi()
        {
            bool retour = true;
            errorProviderBonEntree.Clear();

            // Controle saisi article
            if (this.txtBoxRefArticle.Text.Length == 0)
            {
                errorProviderBonEntree.SetError(txtBoxRefArticle, "Le code Article est obligatoire");
                txtBoxRefArticle.Focus();
                retour = false;
            }
            return retour;
        }

        private void FrmBonEntree_FormClosing(object sender, FormClosingEventArgs e)
        {
            Methodes.Quitter(sender, e, "Fin des entrées articles?");
        }


    }
}
