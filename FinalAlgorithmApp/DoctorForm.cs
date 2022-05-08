using System;
using System.Drawing;
using System.Windows.Forms;

namespace FinalAlgorithmApp
{
    public partial class DoctorForm : Form
    {
        bool pressHome = false;
        bool pressDetial = false;
        internal userControl.HomeDoctorControl home;
        internal userControl.DetailAppoitDocControl detail;

        internal Doctor doctor; // doctor who logged in

        LoginReg form;

        public LoginReg ParentForm
        {
            set => form = value;
            get => form;
        }

        ///// <summary>
        ///// Load Home Patient control
        ///// </summary>
        private void LoadHome()
        {
            pressHome = true;
            pressDetial = false;

            home.ParentForm = this;


            #region Re-design Form
            outButt.Location = new Point(913, -9);
            close.Location = new Point(1064, 0);

            this.Size = new Size(1200, 3550);
            showAppoitButt.Size = new Size(578, 78);
            homeButt.Size = new Size(636, 78);
            #endregion

            home.setInfo();
            home.Dock = DockStyle.Fill;
            panelControl.Controls.Clear();
            panelControl.Controls.Add(home);
            panelControl.BringToFront();


            // clear the content of detail tap
            if (detail != null)
            {
                detail.ClearSearch();
                detail.clear();
            }
            homeButt.BackColor = Color.White;
            showAppoitButt.BackColor = Color.WhiteSmoke;
        }

        /// <summary>
        /// Load Detials of Appoitment Control
        /// </summary>
        internal void LoadDetails()
        {
            pressHome = false;
            pressDetial = true;

            #region Re-design Form
            outButt.Location = new Point(797, -6);
            close.Location = new Point(948, 0);

            this.Size = new Size(1087, 700);
            showAppoitButt.Size = new Size(547, 78);
            homeButt.Size = new Size(547, 78);
            #endregion

            detail.ParentForm = this;
            if (home.AppoitRow != null)
                detail.SearchApp(
                    (int)home.AppoitRow.
                    Cells[0].Value);

            detail.Dock = DockStyle.Fill;
            panelControl.Controls.Clear();
            panelControl.Controls.Add(detail);
            panelControl.BringToFront();

            showAppoitButt.BackColor = Color.White;
            homeButt.BackColor = Color.WhiteSmoke;
        }


        internal DoctorForm(ref Doctor doctor)
        {
            home = new userControl.HomeDoctorControl();
            detail = new userControl.DetailAppoitDocControl();
            this.doctor = doctor;

            InitializeComponent();
        }

        private void DoctorForm_Load(object sender, EventArgs e)
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
                // Prevent reloading, without needing
                if (!pressDetial) LoadDetails();
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

        private void outButt_Click(object sender, EventArgs e)
        {
            try
            {
                form.ParentForm.Show();

                if (detail != null &&
                    detail.addMedicine != null)
                    detail.addMedicine.Hide();

                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panelControl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
