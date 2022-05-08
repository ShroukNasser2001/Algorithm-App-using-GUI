using System;
using System.Collections;
using System.Windows.Forms;

namespace FinalAlgorithmApp.userControl
{
    public partial class DetailAppoitDocControl : UserControl
    {
        DoctorForm form;
        internal userControl.AddMedicine addMedicine;

        int ind = -1;
        DataGridViewRow selectedMid;
        public DoctorForm ParentForm
        {
            set => form = value;
            get => form;
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
            patNameLab.Text = "";
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
                // ID from idLab, sure is target doctor
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
            ind = form.doctor.
                getAppoitmentIndex(targetAppID);

            // fill content
            Appoitment app = (Appoitment)form.doctor.
                Appoitments[ind];

            idLab.Text = app.AppoitmentID.ToString();
            patNameLab.Text = app.Patient.Name.ToString();

            ArrayList meds = app.Medicines;
            foreach (Medicine med in meds)
                MedApp.Rows.Add(med.Name, med.Quantity);
        }

        /// <summary>
        /// Delete Medicine
        /// </summary>
        internal void DeleteMed()
        {
            try
            {
                int ind = form.doctor.getAppoitmentIndex
                      (int.Parse(idLab.Text));

                ((Appoitment)form.doctor
                    .Appoitments[ind])
                    .RemoveMedicine(selectedMid.Cells[0]
                    .Value.ToString());

                MedApp.Rows.Remove(selectedMid);

                MessageBox.Show("Removed Successfully");
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

        public DetailAppoitDocControl()
        {
            InitializeComponent();
        }

        private void DetailAppoitDoc_Load(object sender, EventArgs e)
        {

        }

        private void deleteApp_Click(object sender, EventArgs e)
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

        private void AppIDTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (appIDTxt.Text != "")
                {
                    SearchApp(int.Parse(appIDTxt.Text));
                    excepLab.Text = "";
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                excepLab.Text = "";
                // no data to show
                clear();
                MessageBox.Show(ex.ParamName);
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

        private void medApp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {

                    if (MessageBox.Show(Messages.QuestionYesNo("Remove Medicine ?"),
                        "Qustion", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        selectedMid = MedApp.Rows[e.RowIndex];
                        DeleteMed();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        internal void AddtoGridMed(string name, int quantity)
        {
            try
            {
                bool f = false;
                foreach (DataGridViewRow ro in MedApp.Rows)
                    if (ro.Cells[0].Value.ToString() == name)
                    {
                        ro.Cells[1].Value = quantity;
                        f = true; break;
                    }

                if (!f)
                    MedApp.Rows.Add(name, quantity);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addMeds_Click(object sender, EventArgs e)
        {
            try
            {
                if (ind == -1)
                    MessageBox.Show(
                        "You haven't chosen a appoitment yet ", "Waring",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {

                    addMedicine = new userControl.AddMedicine(ind);

                    addMedicine.PerentControl = this;
                    addMedicine.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
