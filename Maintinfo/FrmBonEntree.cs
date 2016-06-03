using System;

using System.Windows.Forms;
using MaintinfoBll;
namespace Maintinfo
{
    public partial class FrmBonEntree : Form
    {
        public FrmBonEntree()
        {
            InitializeComponent();
        }

        private void btnValider_Click(object sender,EventArgs e)
        {
            string refArt = txtBoxRefArticle.Text;
            int quant = (int)numericUpDownQuantite.Value;
            BonEntreeManager.CreerBonEntree(refArt,quant);
        }

        private void btnAnnuler_Click(object sender, System.EventArgs e)
        {
            ResetText();
        }
        private void ResetBox()
        {
            txtBoxRefArticle.Clear();
            numericUpDownQuantite.ResetText();
        }

    
    }
}
