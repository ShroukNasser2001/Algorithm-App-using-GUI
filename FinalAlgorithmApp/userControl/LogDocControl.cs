using System;
using System.Drawing;
using System.Windows.Forms;

namespace FinalAlgorithmApp.userControl
{
    public partial class LogDocControl : UserControl
    {
        private LoginReg form;
        public LoginReg ParentForm
        {
            set => form = value;
            get => form;
        }
        public LogDocControl()
        {
            InitializeComponent();
        }

        private void logDocControl_Load(object sender, EventArgs e)
        {
            form.Size = new Size(610, 350);
            excepLab.Text = "";
        }

        private void logBut_Click(object sender, EventArgs e)
        {
            try
            {
                bool f = false;
                int ind = form.ParentForm.getDoctorIndex
                    (int.Parse(idTxtLog.Text));

                Doctor loginDoc = ((Doctor)form.ParentForm.MainDoctors[ind]);

                if (loginDoc.ID == 1) // ID of Manager always 1
                {
                    if (MessageBox.Show("Login as Manager ?? ", "Question",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        ManagerForm managerForm = new ManagerForm();
                        managerForm.ParentForm = form.ParentForm;
                        managerForm.Show(); f = true;
                    }
                }
                if (!f)
                {
                    DoctorForm doctorForm = new DoctorForm(ref loginDoc);
                    doctorForm.ParentForm = form;
                    doctorForm.Show();
                }
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
            //catch (Exception ex)
            //{
            //    excepLab.Text = "";
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void idTxtLog_TextChanged(object sender, EventArgs e)
        {

        }

        private void back_click(object sender, EventArgs e)
        {
            form.Hide();
            form.ParentForm.Show();
        }
    }
}
