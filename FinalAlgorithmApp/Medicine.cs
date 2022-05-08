namespace FinalAlgorithmApp
{
    internal class Medicine
    {
        #region Local Variables

        string name;
        int quantity;

        #endregion

        // Constructor
        public Medicine(string name, int quantity)
        {
            this.name = name;
            this.quantity = quantity;
        }

        #region Properties
        public string Name
        {
            get => name;
        }
        public int Quantity
        {
            set => quantity = value;
            get => quantity;
        }
        #endregion
    }
}