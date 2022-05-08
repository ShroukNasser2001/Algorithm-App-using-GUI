using System;
using System.Collections;
using System.Windows.Forms;

namespace FinalAlgorithmApp.userControl
{
    public partial class DoctorDetialManControl : UserControl
    {
        private ManagerForm form;

        public ManagerForm ParentForm
        {
            set => form = value;
            get => form;
        }

        /// <summary> 
        /// Clear content of panel
        /// </summary> 
        private void clear()
        {
            idLab.Text = "";
            nameLab.Text = "";
            DepIDLab.Text = "";
            salaryTxt.Text = "";
            AppoitDoc.Rows.Clear();
        }

        /// <summary>
        /// Delete selected | search doctor 
        /// </summary>
        private void DeleteDoc(bool remove)
        {
            try
            {
                // ID from idLab, sure is target doctor
                form.ParentForm.RemoveDoctor
                    (int.Parse(idLab.Text), remove);

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
        /// Search doctor 
        /// </summary>
        /// <param name="targetDocID">ID of target Docter</param>
        internal void SearchDoc(int targetDocID)
        {
            int ind = form.ParentForm.getDoctorIndex
                (targetDocID);

            // fill content
            Doctor doc = (Doctor)form.ParentForm.MainDoctors[ind];

            idLab.Text = doc.ID.ToString();
            DepIDLab.Text = doc.DepartmentID.ToString();
            nameLab.Text = doc.Name;
            salaryTxt.Text = doc.Salary.ToString();

            ArrayList apps = doc.Appoitments;
            foreach (Appoitment app in apps)
                AppoitDoc.Rows.Add(app.AppoitmentID,
                    app.Patient.Name, app.Medicines.Count);
        }

        public DoctorDetialManControl()
        {
            InitializeComponent();
        }

        private void DoctorDetialManControl_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void deleteDep_Click(object sender, EventArgs e)
        {
            bool f = true;
            if (idLab.Text == "")
            {
                MessageBox.Show(
                      "You haven't chosen a doctor yet ", "Waring",
                      MessageBoxButtons.OK, MessageBoxIcon.Error); f = false;
            }
            else if (idLab.Text == "1")
            {
                if (MessageBox.Show(
                   "You will Remove yourself ? sure ?? ", "Waring",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                    f = true;
                else
                    f = false;
            }
            if (f)
            {
                DialogResult result =
                     MessageBox.Show(Messages.QuestionYesNo(
                         "Remove his Apppiotments ?" +
                     "\nOr Addeding them to Waiting list od his Departent ?"),
                    "Warning", MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question);

                if (result != DialogResult.Cancel)
                {
                    // remove
                    if (result == DialogResult.Yes)
                        DeleteDoc(true);
                    else if (result == DialogResult.No)
                        DeleteDoc(false);

                    MessageBox.Show(
                        "Doctor Removed Successfully !!");
                }
            }
        }

        private void docIDTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (docIDTxt.Text != "")
                {
                    SearchDoc(int.Parse(docIDTxt.Text));
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

        private void docIDTxt_MouseLeave(object sender, EventArgs e)
        {

        }

        private void AppoitDoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void salaryTxt_MouseLeave(object sender, EventArgs e)
        {
            //try
            //{
            //    if (salaryTxt.Text == "")
            //    {
            //        int ind = form.ParentForm.getDoctorIndex
            //            (int.Parse(docIDTxt.Text));

            //        // fill content
            //        ((Doctor)form.ParentForm.MainDoctors[ind]).
            //            Salary = float.Parse(salaryTxt.Text);

            //        MessageBox.Show("Salary Updata successfully !!");
            //        label3.Text = "";
            //    }
            //}
            //catch (ArgumentOutOfRangeException ex)
            //{
            //    label3.Text = "";
            //    MessageBox.Show(ex.ParamName);
            //}
            //catch (FormatException)
            //{
            //    label3.Text = Messages.Numeric;
            //}
            //catch (Exception ex)
            //{
            //    label3.Text = "";
            //    MessageBox.Show(ex.Message);
            //}
        }
    }
}
