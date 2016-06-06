using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaintinfoBo;
namespace Maintinfo
{
    public partial class FrmCatalogue : Form
    {
        public FrmCatalogue()
        {
            InitializeComponent();
        }
        private void buttonRechercher_Click(object sender, EventArgs e)
        {
           MaintinfoBll.CatalogueManager.GenererCatalogue(Convert.ToChar(textBoxCategorie.Text));
            List<Article> cat = MaintinfoBll.CatalogueManager.RecupererCatalogue();
            listBoxArticles.DataSource = cat;
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
        }
        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FrmCatalogue_FormClosing(object sender, FormClosingEventArgs e)
        {
            Methodes.Quitter(sender,e,"Quitter Catalogue?");
        }


    }
}
