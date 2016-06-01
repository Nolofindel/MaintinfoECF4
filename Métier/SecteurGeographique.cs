using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Métier
{
    public class SecteurGeographique
    {
        private string nomSecteurGeographique;

        public SecteurGeographique(string nomSecteurGeographique)
        {
            this.nomSecteurGeographique = nomSecteurGeographique;
        }

        public string NomSecteurGeographique
        {
            get
            {
                return nomSecteurGeographique;
            }

            set
            {
                nomSecteurGeographique = value;
            }
        }
    }
}
