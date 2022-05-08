using System;
using System.Drawing;
using System.Windows.Forms;

namespace FinalAlgorithmApp
{
    public partial class PatientForm : Form
    {
        bool pressHome = false;
        bool pressDetial = false;
        bool pressNew = false;
        internal userControl.HomePatientControl home;
        internal userControl.DetailAppoitPatientControl detail;
        internal userControl.NewAppoitment newApp;

        internal Patient patient; // patient who logged in

        LoginReg form;

        public LoginReg ParentForm
        {
            set => form = value;
            get => form;
        }

        /// <summary>
        /// Load Home Patient control
        /// </summary>
        private void LoadHome()
        {
            pressHome = true;
            pressDetial = false;
            pressNew = false;

            home.ParentForm = this;
            home.setInfo();

            home.Dock = DockStyle.Fill;
            panelControl.Controls.Clear();
            panelControl.Controls.Add(home);
            panelControl.BringToFront();

            // clear the content of detail tap
            if (detail != null)
                detail.clear();

            homeButt.BackColor = Color.White;
            showAppoitButt.BackColor = Color.WhiteSmoke;
            addAppoitButt.BackColor = Color.WhiteSmoke;
        }

        /// <summary>
        /// Load Detials of Appoitment Control
        /// </summary>
        internal void LoadDetails()
        {
            pressHome = false;
            pressDetial = true;
            pressNew = false;

            detail.ParentForm = this;
            if (home.EnrolledRow != null)
                detail.SearchApp(
                    (int)home.EnrolledRow.
                    Cells[0].Value);

            detail.Dock = DockStyle.Fill;
            panelControl.Controls.Clear();
            panelControl.Controls.Add(detail);
            panelControl.BringToFront();

            //showAppoitButt.BackColor = Color.WhiteSmoke;
            homeButt.BackColor = Color.WhiteSmoke;
            addAppoitButt.BackColor = Color.WhiteSmoke;
        }

        /// <summary>
        /// Load New Appoitem Control
        /// </summary>
        private void LoadNew()
        {
            pressHome = false;
            pressDetial = false;
            pressNew = true;
            newApp.ParentForm = this;
            newApp.AddToGrid();

            newApp.Dock = DockStyle.Fill;
            panelControl.Controls.Clear();
            panelControl.Controls.Add(newApp);
            panelControl.BringToFront();

            // clear the content of detail tap
            if (detail != null)
            {
                detail.ClearSearch();
                detail.clear();
            }

            showAppoitButt.BackColor = Color.WhiteSmoke;
            homeButt.BackColor = Color.WhiteSmoke;
            addAppoitButt.BackColor = Color.White;
        }

        public PatientForm()
        {
            home = new userControl.HomePatientControl();
            detail = new userControl.DetailAppoitPatientControl();
            newApp = new userControl.NewAppoitment();
            //  patient = new Patient();

            InitializeComponent();
        }

        /// <summary>
        /// <paramref name="pateient"/> who logged in
        /// </summary>
        internal PatientForm(ref Patient pateient)
        {
            InitializeComponent();

            home = new userControl.HomePatientControl();
            detail = new userControl.DetailAppoitPatientControl();
            newApp = new userControl.NewAppoitment();

            patient = pateient;
        }

        private void PatientForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadHome();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.ParamName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            #region MyRegion
            //Patient p1 = new Patient(); p1.Name = "Pat 1";
            //((Patient)patient).Name = "Pat 1";
            //((Patient)patient).Age = 50;
            //((Patient)patient).City = "Cairo";
            //((Patient)patient).Phone = "10000000000";
            //((Patient)patient).SSN = "12345678910000";
            //((Patient)patient).Gender = true;
            //((Patient)patient).Emergin = false;
            //Appoitment a1 = new Appoitment(1, "Dep 1", 1, "Pat 1",1); 
            //Appoitment a2 = new Appoitment(1, "Dep 2", 1, "Pat 1",5);
            //a2.AddDoctor(1, "Doc");
            //patient.AddAppoitment(ref a1);
            //patient.AddAppoitment(ref a2);




            //AddPat(ref p1);
            //Patient p2 = new Patient(); p2.Name = "Pat 2";
            //AddPat(ref p2);
            //Patient p3 = new Patient(); p3.Name = "Pat 3";
            //AddPat(ref p3);

            //Patient pp = (Patient)pat[0];
            //pp.Name = "PPAATT 11";
            //MessageBox.Show(((Patient)pat[0]).Name);
            //MessageBox.Show(p1.Name);

            //Doctor d1 = new Doctor(); d1.Name = "Doc 1";
            //AddDoc(ref d1); d1.Department = "Dep 1";

            //Doctor d2 = new Doctor(); d2.Name = "Doc 2";
            //AddDoc(ref d1); d2.Department = "Dep 1";

            //Doctor d3 = new Doctor(); d3.Name = "Doc 3";
            //AddDoc(ref d3); d3.Department = "Dep 2";

            //Department e1 = new Department("Dep 1");
            //AddDep(ref e1);
            //e1.AddDoctor(ref d1); e1.AddDoctor(ref d2);

            //Department e2 = new Department("Dep 2");
            //AddDep(ref e2); e2.AddDoctor(ref d3);



            //            Appoitment a1 = new Appoitment(1, "Dep 1", 1, "Pat 1");
            //            AddApp(ref a1);
            //            p1.AddAppoitment(ref a1);
            //            a1.AddDoctor(1, "doc 1");
            //            d1.AddAppoitment(ref a1);


            //            Appoitment a2 = new Appoitment(1, "Dep 1", 2, "Pat 2");
            //            AddApp(ref a2);
            //            p2.AddAppoitment(ref a2);
            //            a2.NumberOfWaiting = 1;
            //            e1.AddWaitAppoitment(ref a2);

            //            /////////////////////////////////////////////////

            //            string sh = " App 2 : " + a2.AppoitmentID
            //                + "\n Dep 1 : " + a2.DepartmentName + " --- " + e1.Name
            //                + "\n Pat 2 : " + a2.PatientName + " --- " + p2.Name
            //                + "\n WaitNum : " + a2.NumberOfWaiting;
            //            MessageBox.Show(sh,"App detail before change");

            //            sh = " App 2 : " + ( (Appoitment)p2.Appoitments[0]).AppoitmentID
            //                + "\n Dep 1 : " + ((Appoitment)p2.Appoitments[0]).DepartmentName 
            //                + "\n Pat 2 : " + p2.Name
            //                + "\n WaitNum : " + ((Appoitment)p2.Appoitments[0]).NumberOfWaiting;
            //            MessageBox.Show(sh, "Pat detail before change");

            //            e1.addWaitedAppoitments();

            //            sh = " App 2 : " + a2.AppoitmentID
            //                + "\n Dep 1 : " + a2.DepartmentName + " --- " + e1.Name
            //                + "\n Pat 2 : " + a2.PatientName + " --- " + p2.Name
            //                + "\n WaitNum : " + a2.NumberOfWaiting
            //                + "\n DocName : " + a2.DoctorName;
            //            MessageBox.Show(sh, "App detail after change");

            //            sh = " App 2 : " + ((Appoitment)p2.Appoitments[0]).AppoitmentID
            //               + "\n Dep 1 : " + ((Appoitment)p2.Appoitments[0]).DepartmentName
            //               + "\n Pat 2 : " + p2.Name
            //               + "\n WaitNum : " + ((Appoitment)p2.Appoitments[0]).NumberOfWaiting
            //               + "\n DocName : " + ((Appoitment)p2.Appoitments[0]).DoctorName;
            //            MessageBox.Show(sh, "Pat detail after change");
            //sh = " App 2 : " + ((Appoitment)apps[1]).AppoitmentID
            //               + "\n Dep 1 : " + ((Appoitment)apps[1]).DepartmentName
            //               + "\n Pat 2 : " + ((Appoitment)apps[1]).PatientName
            //               + "\n WaitNum : " + ((Appoitment)apps[1]).NumberOfWaiting
            //               + "\n DocName : " + ((Appoitment)apps[1]).DoctorName;
            //            MessageBox.Show(sh, "Doct detail after change"); 
            #endregion

        }

        private void homeButt_Click(object sender, EventArgs e)
        {
            try
            {
                // Prevent reloading, without needing
                if (!pressHome) LoadHome();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.ParamName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void showAppoitButt_Click(object sender, EventArgs e)
        {
            try
            {
                LoadDetails();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.ParamName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void appoitEnroll_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelControl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addAppoitButt_Click(object sender, EventArgs e)
        {
            try
            {
                // Prevent reloading, without needing
                if (!pressNew)
                {
                    if (form.ParentForm.MainDepartments.Count == 0)
                        MessageBox.Show("We are really Sory, No Department in our System !!"
                            , "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    else if (form.ParentForm.MainDepartments.Count == patient.Appoitments.Count)
                        MessageBox.Show("No Departments Available for you !!\n" +
                            "You enrolled and waiting in all our Departments\n" +
                            "Thanks for your Trust （*＾-＾*）"
                            , "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    else LoadNew();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ageNum_ValueChanged(object sender, EventArgs e)
        {

        }

        private void waitedApp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void feMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void male_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void noEmer_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void yesEmer_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void phoPatTxt_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void sSNPatTxt_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void outButt_Click(object sender, EventArgs e)
        {
            try
            {
                form.ParentForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
