namespace FinalAlgorithmApp
{
    internal class Doctor : Person
    {
        #region Local Variabels
        int id; // auto-increment
        int departmentID;
        float salary;
        #endregion

        #region Constructors
        public Doctor() : base()
        {
            id = 0;
            departmentID = 1;
            salary = 20000;
        }
        public Doctor(string sSN, string name, int age, bool gender,
            string city, string phone, int departmentID,
            float salary, bool avilability)

        : base(sSN, name, age, gender, city, phone)
        {
            this.id = ++IDs.IDdoc;
            this.departmentID = departmentID;
            this.salary = salary;

        }
        #endregion

        #region Properties
        public int ID
        {
            get => id;
        }
        public int DepartmentID
        {
            set => departmentID = value;
            get => departmentID;
        }
        public float Salary
        {
            set => salary = value;
            get => salary;
        }
        #endregion
    }
}
