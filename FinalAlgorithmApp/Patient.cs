namespace FinalAlgorithmApp
{
    internal class Patient : Person
    {
        #region Local Variabels
        int id;
        bool emergin; // true : found | false : not found
        #endregion

        #region Constructors
        public Patient() : base()
        {
            id = ++IDs.IDpat;
            emergin = true;
        }
        public Patient(string sSN, string name, int age, bool gender, string city,
            string phone, bool emergin)

          : base(sSN, name, age, gender, city, phone)
        {
            this.id = ++IDs.IDpat;
            this.emergin = emergin;
        }
        #endregion

        #region Properties
        public int ID
        {
            get => id;
        }
        public bool Emergin
        {
            set => emergin = value;
            get => emergin;
        }
        #endregion
    }
}
