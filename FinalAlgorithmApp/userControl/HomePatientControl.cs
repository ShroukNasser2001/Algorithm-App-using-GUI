using System;
using System.Collections;
using System.Windows.Forms;

namespace FinalAlgorithmApp.userControl
{
    public partial class HomePatientControl : UserControl
    {

        private PatientForm form;
        private DataGridViewRow appoitEnrollSelect = null;

        public PatientForm ParentForm
        {
            set => form = value;
        }

        /// <summary>
        /// appoitment that user select it
        /// </summary>
        public DataGridViewRow EnrolledRow
        {
            get => appoitEnrollSelect;
        }

        /// <summary>
        /// waited appoitment grid view
        /// </summary>
        public DataGridView WaitedGridView
        {
            get => waitedApp;
        }
        private void AddToGrid()
        {
            try
            {
                // clear the previous content
                appoitEnroll.Rows.Clear();
                waitedApp.Rows.Clear();

                ArrayList apps = form.patient.Appoitments;

                foreach (Appoitment app in apps)
                {
                    if (app.NumberOfWaiting == 0) // not waited
                        appoitEnroll.Rows.Add(app.AppoitmentID, app.Department.Name,
                            app.Doctor.Name, app.Medicines.Count);
                    else
                    {
                        waitedApp.Rows.Add(app.AppoitmentID, app.Department.Name, app.NumberOfWaiting);
                    }
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

        public void setInfo()
        {
            try
            {

                AddToGrid();

                idLab.Text = form.patient.ID.ToString();

                nameTxt.Text = form.patient.Name;

                ageNum.Value = form.patient.Age;

                if (form.patient.Gender)
                {
                    male.Checked = true;
                    male.CheckState = CheckState.Checked;
                }
                else
                {
                    feMale.Checked = false;
                    male.CheckState = CheckState.Unchecked;
                }

                sSNPatTxt.Text = form.patient.SSN;

                phoPatTxt.Text = form.patient.Phone;

                emerginCheck.Checked = form.patient.Emergin;

                cityCombo.SelectedItem = form.patient.City;
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

        public HomePatientControl()
        {
            InitializeComponent();
        }

        private void appoitEnroll_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0) // check  user select row
                {
                    appoitEnrollSelect = appoitEnroll.Rows[e.RowIndex];

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

        private void updataButt_Click_1(object sender, EventArgs e)
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

                    form.patient.Name = nameTxt.Text;

                    form.patient.Age = (int)ageNum.Value;

                    if (male.Checked && !feMale.Checked)
                    {
                        form.patient.Gender = true;
                    }
                    else if (feMale.Checked && !male.Checked)
                    {
                        form.patient.Gender = false;
                    }

                    form.patient.SSN = sSNPatTxt.Text;

                    form.patient.Phone = phoPatTxt.Text;

                    form.patient.Emergin = emerginCheck.Checked;

                    form.patient.City = cityCombo.SelectedItem.ToString();

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

        private void nameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void homeControl_Load(object sender, EventArgs e)
        {

        }

        private void waitedApp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0) // check  user select row
                {
                    DataGridViewRow selectedRow = waitedApp.Rows[e.RowIndex];

                    DialogResult result = MessageBox.Show
                        (Messages.QuestionYesNo(" delete this Appoitment "), "Warning",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    // remove Appoitment 
                    if (result == DialogResult.Yes)
                    {
                        int id = (int)selectedRow.Cells[0].Value;

                        form.ParentForm.ParentForm.RemoveAppoitment(id);

                        waitedApp.Rows.Remove(selectedRow);
                    }
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

        private void cityCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

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

                    form.ParentForm.ParentForm.RemovePatient(id);

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
    }
}
