namespace MaintinfoBo
{
    public class Specialite
    {
        private int specialiteID;
        private string nomSpecialite;

        public Specialite(string nomSpecialite)
        {
            this.nomSpecialite = nomSpecialite;
        }

        public int SpecialiteID
        {
            get
            { return specialiteID; }
            set
            { specialiteID = value; }
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
