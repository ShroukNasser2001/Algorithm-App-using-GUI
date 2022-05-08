using System;
using System.Windows.Forms;

namespace FinalAlgorithmApp.userControl
{
    public partial class RegDocManControl : UserControl
    {
        ManagerForm form;

        public ManagerForm ParentForn
        {
            set => form = value;
            get => form;
        }

        public RegDocManControl()
        {
            InitializeComponent();
        }

        private void enrollButt_Click(object sender, EventArgs e)
        {
            try
            {
                string mess = "";

                // user not select gender  
                if ((feMale.Checked && male.Checked) ||
                     (!feMale.Checked && !male.Checked)
                     ) mess += "You must choose Gnder !! \n";

                // user not select city  
                if (cityCombo.SelectedItem == null)
                    mess += "You must choose City !! \n";

                // user not select city  
                if (deptsCombo.SelectedItem == null)
                    mess += "You must choose Department !! ";

                // user sets his data correctly 
                if (mess == "")
                {
                    bool gen = true;

                    if (feMale.Checked) gen = false;
                    else gen = true;

                    form.ParentForm.AddDoctor(sSNDocTxt.Text, nameTxt.Text,
                           (int)ageNum.Value, gen,
                           cityCombo.SelectedItem.ToString(),
                           phoDocxt.Text, (int)deptsCombo.SelectedItem,
                           float.Parse(salaryTxt.Text), true);

                    int ind = form.ParentForm.MainDoctors.Count - 1;

                    MessageBox.Show(" Docto ID is " +
                        ((Doctor)form.ParentForm.MainDoctors[ind]).ID);

                    ///// clear data

                    sSNDocTxt.Text = "";
                    phoDocxt.Text = "";
                    nameTxt.Text = "";
                    salaryTxt.Text = "";
                    ageNum.Value = 20;
                    feMale.Checked = false; male.Checked = false;
                    cityCombo.SelectedItem = null;
                    deptsCombo.SelectedItem = null;

                    //////////
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

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void phoPatTxt_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void RegDocManControl_Load(object sender, EventArgs e)
        {
            foreach (Department dep in
                form.ParentForm.MainDepartments)
                deptsCombo.Items.Add(dep.ID);
        }
    }
}
