using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Métier
{
    public class Specialite
    {
        private string nomSpecialite;

        public Specialite(string nomSpecialite)
        {
            this.nomSpecialite = nomSpecialite;
        }

        public string NomSpecialite
        {
            get
            {
                return nomSpecialite;
            }

            set
            {
                nomSpecialite = value;
            }
        }
    }
}
