using System;
using System.Collections;

namespace FinalAlgorithmApp
{
    internal class Department
    {
        #region Local Variables

        int id; // auto-increment
        string name;
        ArrayList doctors; // doctors belong to the department

        // Appoitments that waited in the department
        ArrayList waitedAppoitments;

        #endregion

        // Constructor
        public Department(string name)
        {
            id = ++IDs.IDdep;
            this.name = name;
            doctors = new ArrayList();
            waitedAppoitments = new ArrayList();
        }

        #region Properties and Functions

        public int ID
        {
            get => id;
        }
        public string Name
        {
            get => name;
        }

        #region Doctors

        #region Implementation of Sorting

        private void Divide(ref bool typeSort,
            int left, int right)
        {
            if (left >= right) return; // go out when all elements of array are visited
            int mid = (left + right) / 2; // get the middle of 'sub-array' to split from it

            Divide(ref typeSort, left, mid); // got left 'sub-array'
            Divide(ref typeSort, mid + 1, right); // got left 'sub-array'

            // calling function that already sorts elements
            Merge(ref typeSort, left, mid, right); // merge two 'sub-arrays' after sorting their elements
        }
        private void Merge(ref bool typeSort,
            int left, int mid, int right)
        {
            // create two 'sub-arrays' to copy objects 
            int leftSize = (mid - left) + 1;
            int rightSize = right - mid;

            ArrayList leftVector = new ArrayList(leftSize);
            ArrayList rightVector = new ArrayList(rightSize);

            int i; int j;
            // copying objects
            for (i = 0; i < leftSize; i++)
                leftVector.Add(Doctors[left + i]);

            for (j = 0; j < rightSize; j++)
                rightVector.Add(Doctors[mid + 1 + j]);

            int k = left; i = j = 0;

            //sorting objects of two 'sub-arrays'
            if (typeSort)
                while (i < leftSize && j < rightSize)
                {
                    if (((Doctor)leftVector[i]).Appoitments.Count
                        <= ((Doctor)rightVector[j]).Appoitments.Count)
                        Doctors[k++] = leftVector[i++];

                    else if (((Doctor)leftVector[i]).Appoitments.Count
                        > ((Doctor)rightVector[j]).Appoitments.Count)
                        Doctors[k++] = rightVector[j++];
                }
            else
                while (i < leftSize && j < rightSize)
                {
                    if (((Doctor)leftVector[i]).ID
                        <= ((Doctor)rightVector[j]).ID)
                        Doctors[k++] = leftVector[i++];

                    else if (((Doctor)leftVector[i]).ID
                        > ((Doctor)rightVector[j]).ID)
                        Doctors[k++] = rightVector[j++];
                }

            //remaining objects in the two sets of "sub-arrays" are added
            //to the original array in the correct order
            while (i < leftSize)
                Doctors[k++] = leftVector[i++];
            while (j < rightSize)
                Doctors[k++] = rightVector[j++];
        }

        /// <summary>
        /// Sorting The Doctors of the department 
        /// according to 
        /// <paramref name="typeSort"/> true : Number of Appoitment | false : ID 
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">if doctor isn't exist</exception>
        public void Sort(bool typeSort)
        {
            if (doctors.Count == 0)
                throw new ArgumentOutOfRangeException
                    (Messages.NotFound("Doctor"));
            else
                Divide(ref typeSort, 0, doctors.Count - 1);
        }

        #endregion

        /// <summary>
        /// Add Doctor to the doctor list 
        /// </summary>
        /// <param name="doctor"> the doctor object by reference </param>
        public void AddDoctor(ref Doctor doctor)
                                => doctors.Add(doctor);

        /// <summary>
        ///  Get index of the doctor in list
        /// </summary>
        /// <param name="doctorID">ID of Doctor of interest</param>
        /// <returns>index in the List</returns>
        /// <exception cref="ArgumentOutOfRangeException"> if aoctor isn't exist 
        /// or no doctors</exception>
        public int getDoctorIndex(int doctorID)
        {
            int len = doctors.Count;
            if (len == 0)
                throw new ArgumentOutOfRangeException(Messages.NotFound("Appoitment"));

            Sort(false); // must be sorted first to use binary search

            int ind = BinarySearch.Doctor(ref doctors, doctorID, 0, len - 1);

            if (ind == -1) throw new ArgumentOutOfRangeException
                    (Messages.NotBelong("Doctor", "Department"));

            return ind;
        }

        /// <summary>
        ///  Remove Doctor from list
        /// </summary>
        /// <param name="doctorID">ID of Doctor will be removed</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public void RemoveDoctor(int doctorID)
        {
            doctors.RemoveAt
                (getDoctorIndex(doctorID));
        }

        /// <summary>
        /// Get The list of Doctors
        /// </summary>
        public ArrayList Doctors
        {
            get => doctors;
        }

        /// <summary>
        /// Get The Doctor has the mininmum number of Appoitments
        /// </summary>
        /// <returns><seealso cref="Doctor"/> 
        /// | null if no avaliable doctors</returns>
        public Doctor AvaliableDoctor()
        {
            // sort to make the Doctor has the mininmum
            // number of Appoitments, first
            Sort(true);

            if (((Doctor)doctors[0]).
                Appoitments.Count < 10)
                return (Doctor)doctors[0];

            return null;

            /*throw new ArgumentNullException
			   ("There are no Doctors currently Available in The " 
			   + "Department ' " + name + " '");
		   */
        }

        #endregion

        #region Appoitments

        /// <summary>
        /// Add Waited Apoitment to the waited appoitment list 
        /// </summary>
        /// <param name="appoitment"> the appoitment object by reference </param>
        public void AddWaitAppoitment(ref Appoitment waitApp)
        {
            waitedAppoitments.Add(waitApp);
        }

        /// <summary>
        ///  Get index of the waited appoitment in list
        /// </summary>
        /// <param name="appoitmentID">ID of Appoitment of interest</param>
        /// <returns>index in the List</returns>
        /// <exception cref="ArgumentOutOfRangeException"> if appoitment isn't exist 
        /// or no appoitments</exception>
        public int getWaitedAppoitmentIndex(int appoitmentID)
        {
            int len = waitedAppoitments.Count;

            if (len == 0)
                throw new ArgumentOutOfRangeException(
                            Messages.NotFound("Appoitments"));

            int i = BinarySearch.Appoitment(ref waitedAppoitments,
                                       appoitmentID, 0, len - 1);
            if (i == -1)
                throw new ArgumentOutOfRangeException
                    (Messages.NotBelong(" Waited Appoitment", "Department"));

            return i;
        }

        /// <summary>
        ///  Remove Waited Appoitment from list
        /// </summary>
        /// <param name="appoitmentID">ID of Appoitment will be removed</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public void RemoveWaitedAppoitment(int appoitmentID)
        {
            waitedAppoitments.RemoveAt(
            getWaitedAppoitmentIndex(appoitmentID));
        }

        /// <summary>
        ///  Add Waited Appoitments to the
        ///  avaliable Doctors int The Department
        /// </summary>
        public void addWaitedAppoitments()
        {
            // sort to make the Doctors have the mininmum
            // number of Appoitments, first
            Sort(true);

            for (int i = 0; i < doctors.Count; i++)
            {
                Doctor doc = (Doctor)doctors[i];

                // add waited appoitments to the doctor untill
                // the doctor become not available or no waited appoitments found   
                while (doc.Appoitments.Count < 10
                      && waitedAppoitments.Count != 0)
                {
                    Appoitment a = (Appoitment)waitedAppoitments[0];

                    a.AddDoctor(ref doc); // add doctor to the appoitment 

                    doc.AddAppoitment(ref a); // add the appoitment to doctor 

                    //a.NumberOfWaiting = 0;
                    //waitedAppoitments.RemoveAt(0);
                }

                // chech on the next Doctor isn't available
                // or waited appoitments found
                // not need to continue
                if (((Doctor)doctors[i + 1]).
                    Appoitments.Count >= 10
                    || waitedAppoitments.Count == 0) break;

            }
        }

        /// <summary>
        /// Get The list of Waited Appoitments
        /// </summary>
        public ArrayList WaitedAppoitments
        {
            get => waitedAppoitments;
        }

        #endregion

        #endregion
    }

    internal class Appoitment
    {
        #region Local Variables

        int id; // auto-increment
        int numWait;

        Department department;

        Doctor doctor;

        Patient patient;


        // variables between doctor and his patient in appoitment
        ArrayList medicines;

        #endregion

        // Constructor
        public Appoitment(ref Department department,
            ref Patient patient, int numWait)
        {
            id = ++IDs.IDapp;
            this.numWait = numWait;

            this.department = department;

            this.patient = patient;

            medicines = new ArrayList();
        }

        #region Properties and Functions

        public int AppoitmentID
        {
            get => id;
        }
        public int NumberOfWaiting
        {
            set => numWait = value;
            get => numWait;
        }

        public Department Department
        {
            get => department;
        }

        /// <summary>
        /// Add Doctor to the Appoitment 
        /// </summary>
        /// <param name="doctor"> the Doctor will be added by reference </param>
        public void AddDoctor(ref Doctor doctor)
        {
            this.doctor = doctor;
            numWait = 0; // make the Apppoitment not waited

            try
            {
                // remove appoitment from waiting list, if exist
                department.RemoveWaitedAppoitment(id);
            }
            catch (ArgumentOutOfRangeException)
            {
                // no thing happened 
            }
        }

        /// <summary>
        /// Remove Doctor and 
        /// Make Appoitment in the end of waiting list  
        /// </summary>
        public void RemoveDoctor()
        {
            this.doctor = null;
            numWait = department.WaitedAppoitments.Count + 1;
        }

        public Doctor Doctor
        {
            get => doctor;
        }

        public Patient Patient
        {
            get => patient;
        }

        /// <summary>
        /// <para>Add Medicine</para>
        /// <para> Medicine is found but quantity changed, quantity will be updated </para>
        /// <para> Medicine is found and quantity is the same, no thing happen </para>
        /// otherwwise Medicine is added
        /// </summary>
        /// <param name="medicine">Medicine object</param>
        public void addMedicine(ref Medicine medicine)
        {
            int len = medicines.Count;
            bool f = false;
            for (int i = 0; i < len; i++)
            {
                if (((Medicine)medicines[i])
                       .Name == medicine.Name)
                {
                    ((Medicine)medicines[i]).
                               Quantity = medicine.Quantity;

                    f = true; break;
                }
            }
            if (!f)
            {
                medicines.Add(medicine);
            }
        }
        /// <summary>
        /// Get The list of Medicines
        /// </summary>
        public ArrayList Medicines
        {
            get => medicines;
        }

        /// <summary>
        ///  Remove Medicine from list
        /// </summary>
        /// <param name="medicineName">Name of Medicine will be removed</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public void RemoveMedicine(string medicineName)
        {
            int len = medicines.Count;

            if (len == 0)
                throw new ArgumentOutOfRangeException
                        (Messages.NotFound("Medicines"));

            bool f = false;
            for (int i = 0; i < len; i++)
                if (((ValueTuple<string, int>)medicines[i]).
                    Item1 == medicineName)
                {
                    medicines.RemoveAt(i);
                    f = true; break;
                }

            if (!f)
                throw new ArgumentOutOfRangeException
                    (Messages.NotBelong("Medicine", "Appoitment"));
        }

        #endregion
    }
}
