using System;
using System.Drawing;
using System.Windows.Forms;

namespace FinalAlgorithmApp
{
    public partial class ManagerForm : Form
    {
        bool pressShow = false;
        bool pressDetial = false;
        bool pressReg = false;
        internal userControl.ShowDeptManegControl showDep;
        internal userControl.DoctorDetialManControl detail;
        internal userControl.RegDocManControl regDoc;

        WelcomeForm form;

        public WelcomeForm ParentForm
        {
            set => form = value;
            get => form;
        }

        /// <summary>
        /// Load Home Show Department control
        /// </summary>
        private void LoadHome()
        {
            try
            {
                pressShow = true;
                pressDetial = false;
                pressReg = false;

                showDep.ParentForm = this;
                showDep.addToMainGrid();

                #region Re-design Form
                outButt.Location = new Point(741, -3);
                close.Location = new Point(884, 0);

                this.Size = new Size(1029, 574);

                showDocButt.Size = new Size(329, 78);
                showDocButt.Location = new Point(317, -10);

                homeButt.Size = new Size(300, 78);
                homeButt.Location = new Point(0, -10);

                addDocButt.Size = new Size(391, 78);
                addDocButt.Location = new Point(638, -10);
                #endregion

                showDep.Dock = DockStyle.Fill;
                panelControl.Controls.Clear();
                panelControl.Controls.Add(showDep);
                panelControl.BringToFront();


                homeButt.BackColor = Color.White;
                showDocButt.BackColor = Color.WhiteSmoke;
                addDocButt.BackColor = Color.WhiteSmoke;
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Load Detials of Doctor Control
        /// </summary>
        internal void LoadDetails()
        {
            pressShow = false;
            pressDetial = true;
            pressReg = false;

            detail.ParentForm = this;
            if (showDep.selectedDoc != null)
                detail.SearchDoc(
                    (int)showDep.selectedDoc.
                    Cells[0].Value);

            #region Re-design Form
            outButt.Location = new Point(1020, 0);
            close.Location = new Point(1171, 3);

            this.Size = new Size(1313, 700);

            showDocButt.Size = new Size(443, 78);
            showDocButt.Location = new Point(422, -10);

            homeButt.Size = new Size(429, 78);
            homeButt.Location = new Point(0, -10);

            addDocButt.Size = new Size(466, 78);
            addDocButt.Location = new Point(856, 0);
            #endregion

            detail.Dock = DockStyle.Fill;
            panelControl.Controls.Clear();
            panelControl.Controls.Add(detail);
            panelControl.BringToFront();

            showDocButt.BackColor = Color.White;
            homeButt.BackColor = Color.WhiteSmoke;
            addDocButt.BackColor = Color.WhiteSmoke;
        }

        /// <summary>
        /// Load New Soctor Control
        /// </summary>
        private void LoadNew()
        {
            pressShow = false;
            pressDetial = false;
            pressReg = true;
            regDoc.ParentForn = this;

            #region Re-design Form
            outButt.Location = new Point(913, -9);
            close.Location = new Point(1064, 0);

            this.Size = new Size(1170, 650);

            showDocButt.Size = new Size(443, 78);
            showDocButt.Location = new Point(422, -10);

            homeButt.Size = new Size(429, 78);
            homeButt.Location = new Point(0, -10);

            addDocButt.Size = new Size(466, 78);
            addDocButt.Location = new Point(856, 0);
            #endregion


            regDoc.Dock = DockStyle.Fill;
            panelControl.Controls.Clear();
            panelControl.Controls.Add(regDoc);
            panelControl.BringToFront();

            showDep.BackColor = Color.WhiteSmoke;
            homeButt.BackColor = Color.WhiteSmoke;
            addDocButt.BackColor = Color.White;
        }


        public ManagerForm()
        {
            showDep = new userControl.ShowDeptManegControl();
            detail = new userControl.DoctorDetialManControl();
            regDoc = new userControl.RegDocManControl();
            InitializeComponent();
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadHome();
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
                if (!pressShow) LoadHome();
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

        private void showDocButt_Click(object sender, EventArgs e)
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

        private void addDocButt_Click(object sender, EventArgs e)
        {
            try
            {
                // Prevent reloading, without needing
                if (!pressReg) LoadNew();
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

        private void panelControl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void outButt_Click(object sender, EventArgs e)
        {
            try
            {
                form.Show();
                this.Hide();
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
    }
}
