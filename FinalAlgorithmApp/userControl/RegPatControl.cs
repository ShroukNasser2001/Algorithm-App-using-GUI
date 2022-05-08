using System;
using System.Windows.Forms;

namespace FinalAlgorithmApp.userControl
{
    public partial class RegPatControl : UserControl
    {
        private LoginReg parent;
        public LoginReg ParentForm
        {
            set => parent = value;
            get => parent;
        }
        public RegPatControl()
        {
            InitializeComponent();
        }

        private void regPatControl_Load(object sender, EventArgs e)
        {

        }

        private void enrollButt_Click(object sender, EventArgs e)
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
                    bool gen = true;

                    if (feMale.Checked) gen = false;
                    else gen = true;

                    parent.ParentForm.AddPatient(sSNPatTxt.Text, nameTxt.Text,
                           (int)ageNum.Value, gen, cityCombo.SelectedItem.ToString(),
                           phoPatTxt.Text, emerginCheck.Checked);

                    int ind = parent.ParentForm.MainPatients.Count - 1;

                    MessageBox.Show(" Your ID is " +
                        ((Patient)parent.ParentForm.MainPatients[ind]).ID);

                    //////////////////////////
                    parent.LogPat = new LoginPatControl();
                    parent.LogPat.ParentForm = parent;

                    parent.LogPat.Dock =
                        DockStyle.Fill;
                    parent.Controls.Clear();
                    parent.Controls
                        .Add(parent.LogPat);

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

        private void back_Click(object sender, EventArgs e)
        {
            parent.ParentForm.Show();
            parent.Hide();
        }

        private void emerginCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cityCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
