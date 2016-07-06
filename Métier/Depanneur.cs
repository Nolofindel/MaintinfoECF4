namespace MaintinfoBo
{
    public class Depanneur
    {
        private int depanneurID;
        private string nomDepanneur;
        private string prenomDepanneur;
        private Specialite specialiteDepanneur;
        private int specialiteID;
        private SecteurGeographique secteurGeographiqueDepanneur;
        private int secteurGeographiqueID;
        public Depanneur(string nomDepanneur, string prenomDepanneur, Specialite specialiteDepanneur, SecteurGeographique secteurGeographiqueDepanneur)
        {
            this.nomDepanneur = nomDepanneur;
            this.prenomDepanneur = prenomDepanneur;
            this.specialiteDepanneur = specialiteDepanneur;
            this.secteurGeographiqueDepanneur = secteurGeographiqueDepanneur;
        }
        public Depanneur()
        {

        }
        
        public int DepanneurID
        {
            get
            {
                return depanneurID;
            }
            set
            {
                depanneurID = value;
            }
        }
        public string NomDepanneur
        {
            get
            {
                return nomDepanneur;
            }

            set
            {
                nomDepanneur = value;
            }
        }
        public string PrenomDepanneur
        {
            get
            {
                return prenomDepanneur;
            }

            set
            {
                prenomDepanneur = value;
            }
        }
        public Specialite SpecialiteDepanneur
        {
            get
            {
                return specialiteDepanneur;
            }

            set
            {
                specialiteDepanneur = value;
            }
        }
        public int SpecialiteID
        {
            get
            {
                return specialiteID;
            }

            set
            {
                specialiteID = value;
            }
        }

        public SecteurGeographique SecteurGeographiqueDepanneur
        {
            get
            {
                return secteurGeographiqueDepanneur;
            }

            set
            {
                secteurGeographiqueDepanneur = value;
            }
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
        public override string ToString()
        {
            return nomDepanneur;
        }
    }
}
