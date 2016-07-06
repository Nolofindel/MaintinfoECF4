namespace MaintinfoBo
{
    public class Depanneur
    {
        private int depanneurID;
        private string nomDepanneur;
        private Specialite specialiteDepanneur;
        private SecteurGeographique secteurGeographiqueDepanneur;

        public Depanneur(string nomDepanneur, Specialite specialiteDepanneur, SecteurGeographique secteurGeographiqueDepanneur)
        {
            this.nomDepanneur = nomDepanneur;
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

        internal SecteurGeographique SecteurGeographiqueDepanneur
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



        #region Override Methods
        public override string ToString()
        {
            return nomDepanneur;
        }
        #endregion
    }
}
