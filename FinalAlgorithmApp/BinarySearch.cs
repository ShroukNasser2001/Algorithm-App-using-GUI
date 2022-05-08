using System.Collections;

namespace FinalAlgorithmApp
{
    /// <summary>
    /// This class to store common functions will be used
    /// </summary>
    static internal class BinarySearch
    {
        /// <summary>
        /// this function to search in list by ID
        /// the list is definitely sorted by ID
        /// </summary>
        /// <param name="id">the appoitment ID</param>
        /// <param name="left">The beginning of the sublist</param>
        /// <param name="right">The end of the sublist</param>
        /// <returns>index or -1 if isn't exist</returns>
        public static int Appoitment(ref ArrayList list,
            int id, int left, int right)

        {
            if (left > right) return -1; // isn't exist
            int mid = (left + right) / 2; // get middle of list to check

            int _id = ((Appoitment)list[mid]).AppoitmentID;

            if (_id == id) return mid; // appoitment is found

            if (id > _id) // go to right half-list
                return Appoitment(ref list, id,
                    mid + 1, right);

            else // go to left half-list
                return Appoitment(ref list, id,
                    left, mid - 1);
        }

        /// <summary>
        /// this function to search in list by ID
        /// the list is definitely sorted by ID
        /// </summary>
        /// <param name="id">the Department ID</param>
        /// <param name="left">The beginning of the sublist</param>
        /// <param name="right">The end of the sublist</param>
        /// <returns>index or -1 if isn't exist</returns>
        public static int Department(ref ArrayList list,
            int id, int left, int right)
        {
            if (left > right) return -1;
            int mid = (left + right) / 2;
            int _id = ((Department)list[mid]).ID;

            if (_id == id) return mid;
            if (id > _id)
                return Department(ref list, id, mid + 1, right);
            else
                return Department(ref list, id, left, mid - 1);
        }

        /// <summary>
        /// this function to search in list by ID
        /// the list is definitely sorted by ID
        /// </summary>
        /// <param name="id">the Patient ID</param>
        /// <param name="left">The beginning of the sublist</param>
        /// <param name="right">The end of the sublist</param>
        /// <returns>index or -1 if isn't exist</returns>
        public static int Patient(ref ArrayList list,
            int id, int left, int right)
        {
            if (left > right) return -1;
            int mid = (left + right) / 2;
            int _id = ((Patient)list[mid]).ID;

            if (_id == id) return mid;
            if (id > _id)
                return Patient(ref list, id, mid + 1, right);
            else
                return Patient(ref list, id, left, mid - 1);

        }

        /// <summary>
        /// this function to search in list by ID
        /// the list is definitely sorted by ID
        /// </summary>
        /// <param name="id">the Doctor ID</param>
        /// <param name="left">The beginning of the sublist</param>
        /// <param name="right">The end of the sublist</param>
        /// <returns>index or -1 if isn't exist</returns>
        public static int Doctor(ref ArrayList list, int id, int left, int right)
        {
            if (left > right) return -1;
            int mid = (left + right) / 2;
            int _id = ((Doctor)list[mid]).ID;

            if (_id == id) return mid;
            if (id > _id)
                return Doctor(ref list, id, mid + 1, right);
            else
                return Doctor(ref list, id, left, mid - 1);

        }
    }
}