using System;
using System.Collections;
using System.Windows.Forms;

namespace FinalAlgorithmApp.userControl
{
    public partial class NewAppoitment : UserControl
    {
        PatientForm form;
        public PatientForm ParentForm
        {
            set => form = value;
        }

        private int Search(ref ArrayList list,
            int id, int left, int right)
        {
            if (left > right) return -1; // isn't exist
            int mid = (left + right) / 2; // get middle of list to check

            int _id = ((Appoitment)list[mid]).Department.ID;

            if (_id == id) return mid; // appoitment is found

            if (id > _id) // go to right half-list
                return Search(ref list, id,
                    mid + 1, right);

            else // go to left half-list
                return Search(ref list, id,
                    left, mid - 1);
        }

        internal void AddToGrid()
        {
            try
            {

                // clear the previous content
                availEnrollDepts.Rows.Clear();
                waitedApp.Rows.Clear();


                // add to waited grid view
                DataGridViewRowCollection rows = form.home.WaitedGridView.Rows;
                for (int i = 0; i < rows.Count; i++)
                    waitedApp.Rows.Add(rows[i].Cells[0].Value
                        , rows[i].Cells[1].Value, rows[i].Cells[2].Value);

                // add available department for patient

                ArrayList deps = form.ParentForm.ParentForm.MainDepartments;
                if (form.patient.Appoitments.Count != 0)
                {
                    form.patient.Sort();
                    ArrayList apps = form.patient.Appoitments;

                    foreach (Department dep in deps)
                    {
                        int ind = Search(ref apps, dep.ID, 0, apps.Count - 1);
                        if (ind == -1)
                            availEnrollDepts.Rows.Add
                                (dep.ID, dep.Name, dep.WaitedAppoitments.Count);
                    }
                }
                else
                    foreach (Department dep in deps)
                    {
                        availEnrollDepts.Rows.Add
                            (dep.ID, dep.Name, dep.WaitedAppoitments.Count);
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

        public NewAppoitment()
        {
            InitializeComponent();
        }

        private void newAppoitment_Load(object sender, EventArgs e)
        {
        }

        private void availEnrollDepts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0) // check  user select row
                {
                    int wait = (int)availEnrollDepts.
                              Rows[e.RowIndex].Cells[2].Value;

                    Department dep =
                               (Department)form.ParentForm.ParentForm.MainDepartments
                                  [
                                      form.ParentForm.ParentForm.getDepartmentIndex
                                         ((int)availEnrollDepts.Rows
                                             [e.RowIndex].Cells[0].Value)
                                  ];

                    // user answer
                    DialogResult result = DialogResult.None;

                    if (wait == 0 && dep.AvaliableDoctor() == null)
                    {
                        result = MessageBox.Show(" No Aviablable Doctors in This Department\n" +
                             Messages.QuestionYesNo(" Add to Waiting list of this Department"),
                             "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    }
                    else if (wait != 0)
                    {
                        result = MessageBox.Show(Messages.QuestionYesNo
                            (" Add to Waiting list of this Department"), "Question",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    }

                    if (result == DialogResult.Yes ||
                        result == DialogResult.None)
                    {
                        #region add appoitment

                        form.ParentForm.ParentForm.
                             AddAppoitment(ref dep, ref form.patient);

                        MessageBox.Show("Appoitment Added Successfully ", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        #endregion

                        // handling Grid View

                        availEnrollDepts.Rows.
                            RemoveAt(e.RowIndex);

                        if (result == DialogResult.Yes)
                            waitedApp.Rows.Add(
                                ((Appoitment)form.patient.Appoitments
                                   [form.patient.Appoitments.Count - 1]).AppoitmentID,

                                dep.Name, dep.WaitedAppoitments.Count);
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

                        #region Add to available Grid View
                        availEnrollDepts.Rows.Add(
                                             ((Appoitment)form.patient.Appoitments
                                                   [form.patient.getAppoitmentIndex(id)]).Department.ID,

                                             selectedRow.Cells[1].Value.ToString(),

                                             ((Appoitment)form.patient.Appoitments
                                                   [form.patient.getAppoitmentIndex(id)]).Department.
                                                        WaitedAppoitments.Count - 1);
                        #endregion

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

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
