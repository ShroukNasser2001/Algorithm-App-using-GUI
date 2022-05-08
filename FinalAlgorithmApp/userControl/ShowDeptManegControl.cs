using System;
using System.Collections;
using System.Windows.Forms;

namespace FinalAlgorithmApp.userControl
{
    public partial class ShowDeptManegControl : UserControl
    {
        internal DataGridViewRow selectedDep;
        internal DataGridViewRow selectedDoc;

        private ManagerForm form;
        public ManagerForm ParentForm
        {
            set => form = value;
            get => form;
        }

        /// <summary>
        /// Remove Doctors who will removed fron 'Show Doctor tap'
        /// </summary>
        /// <param name="removeRow"> 
        /// Doctor removed :
        ///           ID, Name, Num of Appoitments
        /// </param>
        /// <param name="waitedApps">
        /// Appoitments of removed doctor :
        ///                 ID, Patient Name, Num of Waiting 
        /// </param>
        internal void RemoveView(DataGridViewRow removeRow,
            params DataGridViewRow[] waitedApps)
        {

            foreach (DataGridViewRow row in waitedApps)
                depWaitApps.Rows.Add(row);

            docsSelDep.Rows.Remove(removeRow);
        }

        /// <summary>
        /// Load main info of Departments to grid
        /// </summary>
        internal void addToMainGrid()
        {
            try
            {
                deptShow.Rows.Clear();
                foreach (Department dep in
                        form.ParentForm.MainDepartments)

                    deptShow.Rows.Add(dep.ID, dep.Name,
                           dep.Doctors.Count,
                           dep.WaitedAppoitments.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Delete selected department 
        /// </summary>
        private void DeleteDep()
        {
            try
            {
                form.ParentForm.RemoveDepartment
                    ((int)selectedDep.Cells[0].Value); // first column is ID
                deptShow.Rows.Remove(selectedDep); // remove from main view
                docsSelDep.Rows.Clear();
                depWaitApps.Rows.Clear();
                selectedDep = null;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.ParamName);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("You don't select department ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Show Main info of selected department
        /// </summary>
        private void AddDet()
        {
            // remove previous department
            docsSelDep.Rows.Clear();
            depWaitApps.Rows.Clear();

            int id = (int)selectedDep.Cells[0].Value;

            int ind = form.ParentForm.
                    getDepartmentIndex(id);

            // add Doctors
            ArrayList docs = ((Department)form.ParentForm.
                MainDepartments[ind]).Doctors;

            foreach (Doctor doc in docs)
                docsSelDep.Rows.Add(doc.ID, doc.Name,
                    doc.Appoitments.Count);

            // add Waiting Appoitments
            ArrayList waitApps = ((Department)form.ParentForm.
                MainDepartments[ind]).WaitedAppoitments;

            foreach (Appoitment app in waitApps)
                depWaitApps.Rows.Add(app.AppoitmentID,
                    app.Patient.Name, app.NumberOfWaiting);
        }

        public ShowDeptManegControl()
        {
            InitializeComponent();
        }

        private void deptShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0) // check  user select row
                {
                    selectedDep = deptShow.Rows[e.RowIndex];
                    AddDet();
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.ParamName);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("You don't select department ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void docsSelDep_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show(Messages.QuestionYesNo
                       ("Show The details of this doctor"), "Question",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    selectedDoc = docsSelDep.Rows[e.RowIndex];
                    form.LoadDetails();
                }
            }
        }

        private void depWaitApps_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0) // check  user select row
                {
                    DataGridViewRow selectedRow = depWaitApps.Rows[e.RowIndex];

                    DialogResult result = MessageBox.Show
                        (Messages.QuestionYesNo(" delete this Appoitment "), "Warning",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    // remove Appoitment 
                    if (result == DialogResult.Yes)
                    {
                        int id = (int)selectedRow.Cells[0].Value;

                        form.ParentForm.RemoveAppoitment(id);

                        depWaitApps.Rows.Remove(selectedRow);

                        int i = deptShow.Rows.IndexOf(selectedDep);
                        if (i != -1)
                        {
                            deptShow.Rows[i].Cells[3].Value =
                                (int)deptShow.Rows[i].Cells[3].Value - 1;
                        }
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

        private void addWaitedDep_Click(object sender, EventArgs e)
        {
            try
            {
                if (deptShow.Rows.Count == 0)
                    MessageBox.Show("No Departments", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                if ((int)selectedDep.Cells[3].Value == 0)
                    MessageBox.Show(" the selectec Department doesn't" +
                        " have waited Appoitment !", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                int ind = form.ParentForm.
                    getAppoitmentIndex((int)selectedDep
                                       .Cells[0].Value);

                ((Department)form.ParentForm.
                    MainDepartments[ind]).addWaitedAppoitments();


                int i = deptShow.Rows.IndexOf(selectedDep);
                deptShow.Rows[i].Cells[3].Value = 0;

                depWaitApps.Rows.Clear();

                MessageBox.Show(" Appoitments Added Successfully", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("No Doctor Available");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("You don't select department ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShowDeptManegControl_Load(object sender, EventArgs e)
        {
        }

        private void deleteDep_Click(object sender, EventArgs e)
        {

            if (deptShow.Rows.Count == 0)
                MessageBox.Show("No Departments", "Warning",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                DeleteDep();
        }

        private void showDetial_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
