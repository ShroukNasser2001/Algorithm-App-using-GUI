using System;
using System.Collections;
using System.Windows.Forms;

namespace FinalAlgorithmApp.userControl
{
    public partial class DetailAppoitPatientControl : UserControl
    {
        PatientForm form;
        int ind = -1;
        DataGridViewRow selectedMid;

        public PatientForm ParentForm
        {
            set => form = value;
        }

        internal void ClearSearch()
        {
            appIDTxt.Text = "";
        }

        /// <summary> 
        /// Clear content of panel
        /// </summary> 
        internal void clear()
        {
            idLab.Text = "";
            docNameLab.Text = "";
            ind = -1;
            excepLab.Text = "";
            MedApp.Rows.Clear();
        }

        /// <summary>
        /// Delete selected | search appoitment 
        /// </summary>
        private void DeleteAppoitment()
        {
            try
            {
                // ID from idLab, sure is target patient
                form.ParentForm.ParentForm.
                    RemoveAppoitment(int.Parse(idLab.Text));

                // clear 
                clear();
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

        /// <summary>
        /// Search appoitment 
        /// </summary>
        /// <param name="targetAppID">ID of target Appoitment</param>
        internal void SearchApp(int targetAppID)
        {
            clear();
            ind = form.patient.
                getAppoitmentIndex(targetAppID);

            // fill content
            Appoitment app = (Appoitment)form.patient.
                Appoitments[ind];

            idLab.Text = app.AppoitmentID.ToString();
            docNameLab.Text = app.Doctor.Name.ToString();

            ArrayList meds = app.Medicines;
            foreach (Medicine med in meds)
                MedApp.Rows.Add(med.Name, med.Quantity);
        }

        public DetailAppoitPatientControl()
        {
            InitializeComponent();
        }

        private void medView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DetailAppoitPatientControl_Load(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void delApp_Click(object sender, EventArgs e)
        {
            try
            {
                if (idLab.Text == "")
                    MessageBox.Show(
                        "You haven't chosen a appoitment yet ", "Waring",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                else
                {
                    DialogResult result =
                         MessageBox.Show(Messages.QuestionYesNo("Remove Apppiotment ?")
                         , "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    // remove
                    if (result == DialogResult.Yes)
                    {
                        DeleteAppoitment();

                        MessageBox.Show(
                            "Apppiotment Removed Successfully !!");

                        appIDTxt.Text = "";
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

        private void appIDTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (appIDTxt.Text != "")
                    SearchApp(int.Parse(appIDTxt.Text));
            }
            catch (ArgumentOutOfRangeException ex)
            {
                // no data to show
                clear();
                MessageBox.Show(ex.ParamName);
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

        private void MedApp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
