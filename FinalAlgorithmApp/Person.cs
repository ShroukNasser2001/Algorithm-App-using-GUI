using System;
using System.Collections;

namespace FinalAlgorithmApp
{
    internal class Person
    {
        #region Local Variabels
        string sSN;
        string name;
        int age;
        bool gender; // true : male | false : female
        string city;
        string phone;

        ArrayList appoitments;
        #endregion

        #region Constructors
        protected Person()
        {
            sSN = "12345678912345";
            name = "Ammar";
            age = 23;
            gender = true;
            city = "Fayoum";
            phone = "12345678910";
            appoitments = new ArrayList();
        }
        protected Person(string sSN, string name, int age,
               bool gender, string city, string phone)
        {
            this.sSN = sSN;
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.city = city;
            this.phone = phone;
            appoitments = new ArrayList();
        }
        #endregion

        #region Properties and Functions

        public string Name
        {
            set => name = value;
            get => name;
        }
        public string SSN
        {
            set => sSN = value;
            get => sSN;
        }
        public int Age
        {
            set => age = value;
            get => age;
        }
        public bool Gender
        {
            set => gender = value;
            get => gender;
        }
        public string City
        {
            set => city = value;
            get => city;
        }
        public string Phone
        {
            set => phone = value;
            get => phone;
        }

        #region Implementation of Sorting

        private void Divide(int left, int right)
        {
            if (left >= right) return; // go out when all elements of array are visited
            int mid = (left + right) / 2; // get the middle of 'sub-array' to split from it

            Divide(left, mid); // got left 'sub-array'
            Divide(mid + 1, right); // got left 'sub-array'

            // calling function that already sorts elements
            Merge(left, mid, right); // merge two 'sub-arrays' after sorting their elements
        }
        private void Merge(int left, int mid, int right)
        {
            // create two 'sub-arrays' to copy objects 
            int leftSize = (mid - left) + 1;
            int rightSize = right - mid;

            ArrayList leftVector = new ArrayList(leftSize);
            ArrayList rightVector = new ArrayList(rightSize);

            int i; int j;
            // copying objects
            for (i = 0; i < leftSize; i++)
                leftVector.Add(appoitments[left + i]);

            for (j = 0; j < rightSize; j++)
                rightVector.Add(appoitments[mid + 1 + j]);

            int k = left; i = j = 0;

            //sorting objects of two 'sub-arrays'
            while (i < leftSize && j < rightSize)
            {
                if (((Appoitment)leftVector[i]).Department.ID
                    <= ((Appoitment)rightVector[j]).Department.ID)
                    appoitments[k++] = leftVector[i++];

                else if (((Appoitment)leftVector[i]).Department.ID
                    > ((Appoitment)rightVector[j]).Department.ID)
                    appoitments[k++] = rightVector[j++];
            }

            //remaining objects in the two sets of "sub-arrays" are added
            //to the original array in the correct order
            while (i < leftSize)
                appoitments[k++] = leftVector[i++];
            while (j < rightSize)
                appoitments[k++] = rightVector[j++];
        }

        /// <summary>
        /// Sorting The Appoitments 
        /// according to Department ID
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">if doctor isn't exist</exception>
        public void Sort()
        {
            if (appoitments.Count == 0)
                throw new ArgumentOutOfRangeException
                    (Messages.NotFound("Appoitments"));

            Divide(0, appoitments.Count - 1);
        }

        #endregion

        /// <summary>
        /// Add Apoitment to the appoitment list 
        /// </summary>
        /// <param name="appoitment"> the appoitment object by reference </param>
        public void AddAppoitment(ref Appoitment appoitment)
        {
            appoitments.Add(appoitment);
        }

        /// <summary>
        ///  Get index of the appoitment in list
        /// </summary>
        /// <param name="appoitmentID">ID of Appoitment of interest</param>
        /// <returns>index in the List</returns>
        /// <exception cref="ArgumentOutOfRangeException"> if appoitment isn't exist 
        /// or no appoitments</exception>
        public int getAppoitmentIndex(int appoitmentID)
        {
            int len = appoitments.Count;

            if (len == 0)
                throw new ArgumentOutOfRangeException(
                           Messages.NotFound("Appoitments"));

            int i = BinarySearch.Appoitment(ref appoitments,
                                       appoitmentID, 0, len - 1);
            if (i == -1)
                throw new ArgumentOutOfRangeException
                    (Messages.NotBelong("Appoitment", "Person")); //

            return i;
        }

        /// <summary>
        ///  Remove Appoitment from list
        /// </summary>
        /// <param name="appoitmentID">ID of Appoitment will be removed</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public void RemoveAppoitment(int appoitmentID)
        {
            Appoitments.RemoveAt(
                getAppoitmentIndex(appoitmentID));
        }

        /// <summary>
        /// Get The list of Appoitments
        /// </summary>
        public ArrayList Appoitments
        {
            get => appoitments;
        }

        #endregion
    }
}
