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
        //Delegate permettant de récupérer l'id d'un Article dans le formulaire qui à appelé le catalogue
        public delegate void CatalogueClosing(object sender, EventArgs e,Article art);
        public static event CatalogueClosing OnCatalogueClosing;
        private Article article;
        private bool Valide;
        //Recherche la liste des articles appartenant à une certaine catégorie
        private void buttonRechercher_Click(object sender, EventArgs e)
        {
            try {
                listBoxArticles.DataSource = null;
           MaintinfoBll.CatalogueManager.GenererCatalogue(Convert.ToChar(textBoxCategorie.Text));
            List<Article> cat = MaintinfoBll.CatalogueManager.RecupererCatalogue();
            listBoxArticles.DataSource = cat;
            }
            catch(Exception se)
            {
                Methodes.Erreur(se);
            }
        }

        //Lance l'event associé au delegate puis ferme
        private void buttonValider_Click(object sender, EventArgs e)
        {try
            {
                if (article == null) { throw new Exception(); }
                OnCatalogueClosing(sender, e, article);
                Valide = true;
                this.Close();
            }
           catch (Exception)
            {
                Methodes.Erreur("Veuillez Sélectionner un article avant de valider");
            }
            
        }
        //Ferme le formulaire
        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCatalogue_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Valide)
            {
                Methodes.Quitter(sender, e, "Quitter Catalogue?");
            }
        }

        private void listBoxArticles_SelectedIndexChanged(object sender, EventArgs e)
        {
            article = (Article)listBoxArticles.SelectedItem;
        }
    }
}
