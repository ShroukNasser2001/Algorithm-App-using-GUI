using System;
using System.Collections;
using System.Windows.Forms;

namespace FinalAlgorithmApp.userControl
{
    public partial class HomeDoctorControl : UserControl
    {
        private DoctorForm form;
        private DataGridViewRow appoitSelect = null;

        public DoctorForm ParentForm
        {
            set => form = value;
        }

        /// <summary>
        /// appoitment that user select it
        /// </summary>
        public DataGridViewRow AppoitRow
        {
            get => appoitSelect;
        }

        private void AddToGrid()
        {
            try
            {
                // clear the previous content
                appoits.Rows.Clear();

                ArrayList apps = form.doctor.Appoitments;

                foreach (Appoitment app in apps)
                    appoits.Rows.Add(app.AppoitmentID,
                        app.Patient.Name, app.Medicines.Count);
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

        public void setInfo()
        {
            try
            {

                AddToGrid();

                idLab.Text = form.doctor.ID.ToString();

                nameTxt.Text = form.doctor.Name;

                ageNum.Value = form.doctor.Age;

                if (form.doctor.Gender)
                {
                    male.Checked = true;
                    male.CheckState = CheckState.Checked;
                }
                else
                {
                    feMale.Checked = false;
                    male.CheckState = CheckState.Unchecked;
                }

                sSNPatTxt.Text = form.doctor.SSN;

                phoPatTxt.Text = form.doctor.Phone;

                salaryLab.Text = form.doctor.Salary.ToString();

                cityCombo.SelectedItem = form.doctor.City;
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

        public HomeDoctorControl()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void updataButt_Click(object sender, EventArgs e)
        {

            try
            {
                string mess = "";

                // user not select gender  
                if ((feMale.Checked && male.Checked) ||
                     (!feMale.Checked && !male.Checked)
                     ) mess += "You must choose your Gnder !! \n";

                // user not select city  
                if (cityCombo.SelectedItem == null)
                    mess += "You must choose your City !! ";

                // user sets his data correctly 
                if (mess == "")
                {

                    form.doctor.Name = nameTxt.Text;

                    form.doctor.Age = (int)ageNum.Value;

                    if (male.Checked && !feMale.Checked)
                    {
                        form.doctor.Gender = true;
                    }
                    else if (feMale.Checked && !male.Checked)
                    {
                        form.doctor.Gender = false;
                    }

                    form.doctor.SSN = sSNPatTxt.Text;

                    form.doctor.Phone = phoPatTxt.Text;

                    form.doctor.City = cityCombo.SelectedItem.ToString();

                    MessageBox.Show("Updata is done");
                }
                else
                    MessageBox.Show(mess, "Warning", MessageBoxButtons.OK,
                                                 MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void appoits_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0) // check  user select row
                {
                    appoitSelect = appoits.Rows[e.RowIndex];

                    DialogResult result = MessageBox.Show(Messages.QuestionYesNo
                        (" Show the Appoitment Details"), "Question",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                        form.LoadDetails();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteButt_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show
                    (Messages.QuestionYesNo(" delete your Account "), "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // remove Account 
                if (result == DialogResult.Yes)
                {
                    int id = int.Parse(idLab.Text);

                    form.ParentForm.ParentForm.RemoveDoctor(id, false);

                    MessageBox.Show("Good Bye !", "^_~",
                                   MessageBoxButtons.OK, MessageBoxIcon.Hand);

                    form.ParentForm.ParentForm.Show();
                    form.Hide();
                }
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

        private void HomeDoctorControl_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
