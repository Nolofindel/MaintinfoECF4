namespace MaintinfoBo
{
    public class SecteurGeographique
    {
        private int secteurGeographiqueID;
        private string nomSecteurGeographique;

        public SecteurGeographique(string nomSecteurGeographique)
        {
            this.nomSecteurGeographique = nomSecteurGeographique;
        }
        
        public int SecteurGeographiqueID
        {
            get
            {
                return secteurGeographiqueID;
            }
            set
            {
                secteurGeographiqueID = value;
            }
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
