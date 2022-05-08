using System;
using System.Windows.Forms;

namespace FinalAlgorithmApp
{
    public partial class LoginReg : Form
    {
        private bool role;
        private userControl.LogDocControl logDoc;
        private userControl.LoginPatControl logPat;
        private userControl.RegPatControl regPat;

        public userControl.LogDocControl LogDoc
        {
            set => logDoc = value;
            get => logDoc;
        }
        public userControl.LoginPatControl LogPat
        {
            set => logPat = value;
            get => logPat;
        }
        public userControl.RegPatControl RegPat
        {
            set => regPat = value;
            get => regPat;
        }

        WelcomeForm parent;

        /// <summary>
        /// parent form of this form
        /// </summary>
        public WelcomeForm ParentForm
        {
            set => parent = value;
            get => parent;
        }

        /// <param name="role"> true: Patient | false: Doctor </param>
        public LoginReg(bool role)
        {
            this.role = role;
            InitializeComponent();
        }

        private void LoginReg_Load(object sender, EventArgs e)
        {

            if (role)
            {
                logPat = new userControl.LoginPatControl();
                logPat.ParentForm = this;
                logPat.Dock = DockStyle.Fill;
                this.Controls.Clear();
                this.Controls.Add(logPat);
            }
            else
            {
                logDoc = new userControl.LogDocControl();
                logDoc.ParentForm = this;
                logDoc.Dock = DockStyle.Fill;
                this.Controls.Clear();
                this.Controls.Add(logDoc);
            }
        }
    }
}
