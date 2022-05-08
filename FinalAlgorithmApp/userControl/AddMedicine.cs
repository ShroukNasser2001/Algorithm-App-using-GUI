using System;
using System.Windows.Forms;

namespace FinalAlgorithmApp.userControl
{
    public partial class AddMedicine : Form
    {
        private int apoitmentIndex;
        private DetailAppoitDocControl
            perentControl;

        public DetailAppoitDocControl
            PerentControl
        {
            set => perentControl = value;
            get => perentControl;
        }

        public AddMedicine(int apoitmentIndex)
        {
            this.apoitmentIndex = apoitmentIndex;

            InitializeComponent();
        }

        private void nameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddMedicine_Load(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                Medicine med = new Medicine
                    (nameTxt.Text, int.Parse(quantity.Text));

                // add (as) neew medicine to appoitment of doctor 
                ((Appoitment)perentControl.ParentForm.
                     doctor.Appoitments[apoitmentIndex]).
                     addMedicine(ref med);

                // add new Medicine to grid view
                perentControl.AddtoGridMed(nameTxt.Text,
                     int.Parse(quantity.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show(Messages.Numeric);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
