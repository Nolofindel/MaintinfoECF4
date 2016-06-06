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
            //FrmBonDeCommande.OnCatalogueShow += DetailFermeture;
        }
        public delegate void CatalogueClosing(object sender, EventArgs e,Article art);
        public static event CatalogueClosing OnCatalogueClosing;
        private Article article;
        private void buttonRechercher_Click(object sender, EventArgs e)
        {
            try {
           MaintinfoBll.CatalogueManager.GenererCatalogue(Convert.ToChar(textBoxCategorie.Text));
            List<Article> cat = MaintinfoBll.CatalogueManager.RecupererCatalogue();
            listBoxArticles.DataSource = cat;
            }
            catch(Exception se)
            {
                Methodes.Erreur(se);
            }
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            OnCatalogueClosing(sender,e,article);
            this.Close();
        }
        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FrmCatalogue_FormClosing(object sender, FormClosingEventArgs e)
        {
            Methodes.Quitter(sender,e,"Quitter Catalogue?");
        }
        void DetailFermeture(object sender, EventArgs e)
        {

        }

        private void listBoxArticles_SelectedIndexChanged(object sender, EventArgs e)
        {
            article = (Article)listBoxArticles.SelectedItem;
        }
    }
}
