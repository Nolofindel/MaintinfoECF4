using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maintinfo
{
    public class Methodes
    {
        public static void Quitter(object sender, FormClosingEventArgs e,string message)
        {
            DialogResult dr = MessageBox.Show(message, "FIN",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1);
            if (dr == DialogResult.No)
            {
               e.Cancel=true;
            }
        }
        public static void Erreur(Exception se)
        {
            DialogResult Erreur = MessageBox.Show("Erreur  :" + se.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }
    }
}
