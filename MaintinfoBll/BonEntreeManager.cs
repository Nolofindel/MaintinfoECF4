﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MaintinfoBo;

namespace MaintinfoBll
{
    public class BonEntreeManager
    {
        public static void CreerBonEntree(string refArt,int quantite)
        {
            Article art = new Article();
            BonEntree BonE = new BonEntree(art, quantite, DateTime.Now);
            
        }
        public static bool EnregistrerBonEntree()
        {
            return true;
        }
    }
}