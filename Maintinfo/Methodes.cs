﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Drawing;
using MaintinfoBo;
using MaintinfoBll;
namespace Maintinfo
{
    public class Methodes
    {
        public static void Quitter(object sender, FormClosingEventArgs e, string message)
        {
            DialogResult dr = MessageBox.Show(message, "FIN",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        public static void Erreur(Exception se)
        {
            DialogResult Erreur = MessageBox.Show("Erreur  :" + se.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }
        public static void Erreur(string msg)
        {
            DialogResult Erreur = MessageBox.Show("Erreur  :" + msg, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }
        public static void Apercu(BonDeCommande bdc)
        {
            PrintPreviewDialog printDialog = new PrintPreviewDialog();
            PrintDocument printText = new PrintDocument();
            printText.PrintPage += delegate (object sender1, PrintPageEventArgs e1)
            {
                e1.Graphics.DrawString(BonDeCommandeManager.MiseEnPageBonDeCommande(bdc), new Font("Times New Roman", 12), new SolidBrush(Color.Black), new RectangleF(0, 0, printText.DefaultPageSettings.PrintableArea.Width, printText.DefaultPageSettings.PrintableArea.Height));
            };
            printDialog.Document = printText;
            printDialog.ShowDialog();

        }

        public static void Apercu(BonSortie bds)
        {
            PrintPreviewDialog printDialog = new PrintPreviewDialog();
            PrintDocument printText = new PrintDocument();
            printText.PrintPage += delegate (object sender1, PrintPageEventArgs e1)
            {
                e1.Graphics.DrawString(BonSortieManager.MiseEnPageBonSortie(bds), new Font("Times New Roman", 12), new SolidBrush(Color.Black), new RectangleF(0, 0, printText.DefaultPageSettings.PrintableArea.Width, printText.DefaultPageSettings.PrintableArea.Height));
            };
            printDialog.Document = printText;
            printDialog.ShowDialog();

        }

    }
}
