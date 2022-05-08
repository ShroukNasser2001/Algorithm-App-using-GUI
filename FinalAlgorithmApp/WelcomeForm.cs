using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace FinalAlgorithmApp
{
    public partial class WelcomeForm : Form
    {
        Random random;

        private LoginReg person;

        /// <summary>
        /// The Login Regestration Form 
        /// </summary>
        public LoginReg CurrentPerson
        {
            set => person = value;
            get => person;
        }

        #region MainData

        #region Lists
        // Store all data that be created during Running Application
        private ArrayList mainDepts;
        private ArrayList mainDocs;
        private ArrayList mainPats;
        private ArrayList mainApps;
        #endregion

        #region Adding

        /// <summary>
        /// Add new Department
        /// </summary>
        /// <param name="name">name of Department</param>
        internal void AddDepartment(string name)
        {
            // create new object
            Department dep = new Department(name);

            // ref Department department = ref dep; // get refernc

            mainDepts.Add(dep); // add to main list
        }

        /// <summary>
        /// Add new Patient
        /// </summary>
        internal void AddPatient(string sSN, string name,
            int age, bool gender, string city,
            string phone, bool emergin)
        {
            // create new object
            Patient pat = new Patient(sSN, name, age,
                gender, city, phone, emergin);

            // ref Patient patient = ref pat;

            mainPats.Add(pat); // add to main list
        }

        /// <summary>
        /// Add new Doctor to Department of <paramref name="departmentID"/>
        /// </summary>
        internal void AddDoctor(string sSN, string name, int age, bool gender, string city,
            string phone, int departmentID, float salary, bool avilability)
        {
            // create new object
            Doctor doc = new Doctor(sSN, name, age, gender, city
                , phone, departmentID, salary, avilability);

            //ref Doctor doctor = ref doc;

            // add doctor to his department
            ((Department)mainDepts
                [getDepartmentIndex(departmentID)])
                .AddDoctor(ref doc); //

            mainDocs.Add(doc); // add to main list
        }

        /// <summary>
        /// Add new Appoitment to 
        /// Department <paramref name="dep"/>
        /// Patient <paramref name="pat"/>
        /// </summary>
        internal void AddAppoitment(ref Department dep,
            ref Patient pat)
        {

            // create new object
            // by default is waited
            Appoitment app = new Appoitment(ref dep, ref pat,
                dep.WaitedAppoitments.Count + 1);

            //ref Appoitment appoitment = ref app;

            // add appoitment to its Patient
            pat.AddAppoitment(ref app);

            #region check Avaliablity

            Doctor doc = dep.AvaliableDoctor();

            if (doc == null) // add to waiting list 
                dep.AddWaitAppoitment(ref app);
            else
            {
                // add appoitment to its doctor
                doc.AddAppoitment(ref app);

                // add available doctor to the appoitment
                app.AddDoctor(ref doc);
            }

            #endregion

            mainApps.Add(app); // add to mail list
        }

        #endregion

        #region Remove

        /// <summary>
        /// Remove Department and its all date that related to it
        /// by <paramref name="departmentID"/>
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        internal void RemoveDepartment(int departmentID)
        {
            int ind = getDepartmentIndex(departmentID);
            Department dep = (Department)mainDepts[ind];

            // remove its doctors
            ArrayList docs = dep.Doctors;
            for (int i = 0; i < docs.Count; i++)
                RemoveDoctor(((Doctor)docs[i]).ID);


            // remove its waited appoitmnts
            ArrayList waitApps = dep.WaitedAppoitments;
            for (int i = 0; i < waitApps.Count; i++)
                RemoveAppoitment(((Appoitment)waitApps[i]).AppoitmentID);

            mainDepts.RemoveAt(ind);
        }

        /// <summary>
        /// Remove Patient and its all date that related to it
        /// by <paramref name="patientID"/>
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        internal void RemovePatient(int patientID)
        {
            int ind = getPatientIndex(patientID);

            // remove his appoitments 
            ArrayList apps = ((Patient)mainPats[ind]).Appoitments;
            while (apps.Count != 0)
                RemoveAppoitment(((Appoitment)apps[0])
                               .AppoitmentID);

            mainPats.RemoveAt(ind);
        }

        /// <summary>
        /// Remove Doctor and its all date that related to it
        /// by <paramref name="doctorID"/>
        /// </summary>
        /// <param name="removeAppoitments">remove his Appoitments or
        /// make them waited </param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        internal void RemoveDoctor(int doctorID,
            bool removeAppoitments = true)
        {
            int ind = getDoctorIndex(doctorID);

            Doctor doc = (Doctor)mainDocs[ind];

            ArrayList apps = ((Doctor)mainDocs[ind]).Appoitments;

            // handle his Appoitments
            if (removeAppoitments)
                while (apps.Count != 0)
                    RemoveAppoitment(((Appoitment)apps[0])
                                            .AppoitmentID);

            else
                for (int i = 0; i < apps.Count; i++)
                {
                    Appoitment app = (Appoitment)apps[i];

                    app.RemoveDoctor();
                    app.Department.AddWaitAppoitment(ref app);
                }

            mainDocs.RemoveAt(ind);
        }

        /// <summary>
        /// Remove Appoitment and its all date that related to it
        /// by <paramref name="appoitmentID"/>
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        internal void RemoveAppoitment(int appoitmentID)
        {
            int ind = getAppoitmentIndex(appoitmentID);

            Appoitment app = (Appoitment)mainApps[ind];

            // remove appoitment from patient
            app.Patient.RemoveAppoitment(appoitmentID);
            if (app.NumberOfWaiting == 0)
                app.Doctor.RemoveAppoitment(appoitmentID);
            else
                app.Department.RemoveWaitedAppoitment(appoitmentID);

            // remove appoitment from main list
            mainApps.RemoveAt(ind);
        }

        #endregion

        #region GetObjectIndex

        /// <exception cref="ArgumentOutOfRangeException"></exception>
        internal int getDepartmentIndex(int departmentID)
        {
            int ind = BinarySearch.Department(ref mainDepts, departmentID,
                0, mainDepts.Count - 1);

            if (ind != -1) return ind;
            else
                throw new ArgumentOutOfRangeException
                (Messages.NotBelong("Department", "Main List"));
        }

        /// <exception cref="ArgumentOutOfRangeException"></exception>
        internal int getPatientIndex(int patientID)
        {
            int ind = BinarySearch.Patient(ref mainPats, patientID,
                0, mainPats.Count - 1);

            if (ind != -1) return ind;

            throw new ArgumentOutOfRangeException
                (Messages.NotBelong("Patient", "Main List"));
        }

        /// <exception cref="ArgumentOutOfRangeException"></exception>
        internal int getDoctorIndex(int doctorID)
        {
            int ind = BinarySearch.Doctor(ref mainDocs, doctorID,
                0, mainDocs.Count - 1);

            if (ind != -1) return ind;

            throw new ArgumentOutOfRangeException
                (Messages.NotBelong("Doctor", "Main List"));
        }

        /// <exception cref="ArgumentOutOfRangeException"></exception>
        internal int getAppoitmentIndex(int appoitmentID)
        {
            int ind = BinarySearch.Appoitment(ref mainApps, appoitmentID,
                0, mainApps.Count - 1);
            if (ind != -1) return ind;
            throw new ArgumentOutOfRangeException
                (Messages.NotBelong("Appoitment", "Main List"));
        }

        #endregion

        #region GetList
        internal ref ArrayList MainDepartments
        {
            get => ref mainDepts;
        }
        internal ref ArrayList MainPatients
        {
            get => ref mainPats;
        }
        internal ref ArrayList MainDoctors
        {
            get => ref mainDocs;
        }
        internal ref ArrayList MainAppoitments
        {
            get => ref mainApps;
        }
        #endregion

        #endregion

        public WelcomeForm()
        {
            random = new Random();
            mainDepts = new ArrayList();
            mainDocs = new ArrayList();
            mainPats = new ArrayList();
            mainApps = new ArrayList();

            #region Add Data

            AddDepartment("Genetics I");
            AddDepartment("Genetics II");
            AddDepartment("Genetics III");

            AddDoctor("125478910254104", "Malk Yasser", 50, true, "Cairo", "01054975011", 1, 30000, true);
            AddDoctor("125478910254104", "Mohamed Yasser", 50, true, "Cairo", "01054975011", 1, 2000, true);
            AddDoctor("125478910254104", "Samuel Adeal", 50, true, "Cairo", "01054975011", 2, 2000, true);
            AddDoctor("125478910254104", "Shrouk Nasser", 50, true, "Cairo", "01054975011", 3, 2000, true);

            AddPatient("30123457891547", "Mohamed", 50, true, "Fayoum", "01024578945", false); ;
            AddPatient("30123457891549", "Samuel", 50, true, "Fayoum", "0101234560", false);
            AddPatient("30123457891540", "Shrouk", 50, false, "Fayoum", "0101234569", false);
            AddPatient("30123457891547", "Ahmed", 50, true, "Fayoum", "0101234567", false);
            AddPatient("30123457891549", "Ali", 50, true, "Fayoum", "0101234560", false);
            AddPatient("30123457891540", "Rana", 50, false, "Fayoum", "0101234569", false);
            AddPatient("30123457891547", "Mostafa", 50, true, "Fayoum", "0101234567", false);
            AddPatient("30123457891549", "Mahmoud", 50, true, "Fayoum", "0101234560", false);
            AddPatient("30123457891540", "Tamer", 50, false, "Fayoum", "0101234569", false);
            AddPatient("30123457891540", "Ali", 50, false, "Fayoum", "0101234569", false);
            AddPatient("30123457891540", "Ashraf", 50, false, "Fayoum", "0101234569", false);


            // add Appoitments To Genetics I
            Department a1 = (Department)mainDepts[0];
            for (int i = 0; i < 10; i++)
            {
                Patient p1 = (Patient)mainPats[i];
                try
                {
                    AddAppoitment(ref a1, ref p1);
                }
                catch (ArgumentOutOfRangeException)
                {

                }
                catch (ArgumentNullException)
                {

                }
            }

            Patient p = (Patient)mainPats[10]; // as waiting Appoitment
            AddAppoitment(ref a1, ref p);

            // add Appoitments To Genetics II
            Department a2 = (Department)mainDepts[1];
            for (int i = 0; i < 10; i++)
            {
                Patient p1 = (Patient)mainPats[i];

                try
                {
                    AddAppoitment(ref a2, ref p1);
                }
                catch (ArgumentOutOfRangeException)
                {

                }
                catch (ArgumentNullException)
                {

                }
            }
            AddAppoitment(ref a2, ref p);// as waiting Appoitment
            #endregion

            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.ForeColor = Color.FromArgb(random.Next(0, 255),
                            random.Next(0, 255), random.Next(0, 255));
        }


        private void patientBut_Click(object sender, EventArgs e)
        {
            // load Login Regestration Form for patient

            person = new LoginReg(true);

            // make this form perent to LogReg Form
            person.ParentForm = this;
            person.Show();
            this.Hide();
        }

        private void doctorBut_Click(object sender, EventArgs e)
        {
            // load Login Regestration Form for doctor

            person = new LoginReg(false);

            // make this form perent to LogReg Form
            person.ParentForm = this;
            person.Show();
            this.Hide();
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void patientBut_MouseLeave(object sender, EventArgs e)
        {
            patientBut.ForeColor = Color.FromArgb(64, 184, 191);
        }

        private void patientBut_MouseMove(object sender, MouseEventArgs e)
        {
            patientBut.ForeColor = Color.FromArgb(58, 105, 149);
        }

        private void doctorBut_MouseMove(object sender, MouseEventArgs e)
        {
            doctorBut.ForeColor = Color.FromArgb(58, 105, 149);
        }

        private void doctorBut_MouseLeave(object sender, EventArgs e)
        {
            doctorBut.ForeColor = Color.FromArgb(64, 184, 191);
        }
    }
}
