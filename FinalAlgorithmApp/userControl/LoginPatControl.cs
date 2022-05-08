using System;
using System.Drawing;
using System.Windows.Forms;

namespace FinalAlgorithmApp.userControl
{
    public partial class LoginPatControl : UserControl
    {
        private LoginReg form;
        public LoginReg ParentForm
        {
            set => form = value;
            get => form;
        }

        public LoginPatControl()
        {
            InitializeComponent();
        }

        private void regBut_Click(object sender, EventArgs e)
        {
            try
            {
                this.Dispose();

                form.RegPat = new RegPatControl();
                form.RegPat.ParentForm = form;

                form.RegPat.Dock =
                    DockStyle.Fill;

                //
                form.Size = new Size(820, 500);
                //

                form.Controls.Clear();
                form.Controls
                    .Add(form.RegPat);

                form.BringToFront();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void excepLab_Click(object sender, EventArgs e)
        {

        }

        private void idTxtLog_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void loginPatControl_Load(object sender, EventArgs e)
        {
            form.Size = new Size(610, 350);
            excepLab.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void idTxtLog_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void logBut_Click(object sender, EventArgs e)
        {
            try
            {
                int ind = form.ParentForm.getPatientIndex
                    (int.Parse(idTxtLog.Text));

                Patient loginPat = ((Patient)form.ParentForm.MainPatients[ind]);

                PatientForm patientForm = new PatientForm(ref loginPat);

                patientForm.ParentForm = form;
                patientForm.Show();

                form.Hide();
            }
            catch (ArgumentOutOfRangeException ms)
            {
                excepLab.Text = "";
                MessageBox.Show(ms.ParamName);
            }
            catch (FormatException)
            {
                excepLab.Text = Messages.Numeric;
            }
            catch (Exception ex)
            {
                excepLab.Text = "";
                MessageBox.Show(ex.Message);
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            form.Hide();
            form.ParentForm.Show();
        }
    }
}
