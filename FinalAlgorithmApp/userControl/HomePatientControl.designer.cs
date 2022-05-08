
namespace FinalAlgorithmApp.userControl
{
    partial class HomePatientControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePatientControl));
            this.waitedApp = new System.Windows.Forms.DataGridView();
            this.appoitIWaitD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptWaitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.indexWaitNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appoitEnroll = new System.Windows.Forms.DataGridView();
            this.appID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numMed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.updataButt = new System.Windows.Forms.Button();
            this.emerginCheck = new System.Windows.Forms.RadioButton();
            this.feMale = new System.Windows.Forms.CheckBox();
            this.male = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.phoPatTxt = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sSNPatTxt = new System.Windows.Forms.MaskedTextBox();
            this.idLab = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteButt = new System.Windows.Forms.Button();
            this.ageNum = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.nameTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.cityCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.waitedApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appoitEnroll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageNum)).BeginInit();
            this.SuspendLayout();
            // 
            // waitedApp
            // 
            this.waitedApp.AllowDrop = true;
            this.waitedApp.AllowUserToAddRows = false;
            this.waitedApp.AllowUserToDeleteRows = false;
            this.waitedApp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.waitedApp.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.waitedApp.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.waitedApp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.waitedApp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.waitedApp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.appoitIWaitD,
            this.deptWaitName,
            this.indexWaitNum});
            this.waitedApp.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.waitedApp.Location = new System.Drawing.Point(806, 683);
            this.waitedApp.Name = "waitedApp";
            this.waitedApp.ReadOnly = true;
            this.waitedApp.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.waitedApp.RowTemplate.Height = 24;
            this.waitedApp.Size = new System.Drawing.Size(597, 150);
            this.waitedApp.TabIndex = 39;
            this.waitedApp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.waitedApp_CellContentClick);
            // 
            // appoitIWaitD
            // 
            this.appoitIWaitD.HeaderText = "ApooitmetID";
            this.appoitIWaitD.MinimumWidth = 6;
            this.appoitIWaitD.Name = "appoitIWaitD";
            this.appoitIWaitD.ReadOnly = true;
            // 
            // deptWaitName
            // 
            this.deptWaitName.HeaderText = "Department Name";
            this.deptWaitName.MinimumWidth = 6;
            this.deptWaitName.Name = "deptWaitName";
            this.deptWaitName.ReadOnly = true;
            // 
            // indexWaitNum
            // 
            this.indexWaitNum.HeaderText = "Your turn in waiting list";
            this.indexWaitNum.MinimumWidth = 6;
            this.indexWaitNum.Name = "indexWaitNum";
            this.indexWaitNum.ReadOnly = true;
            // 
            // appoitEnroll
            // 
            this.appoitEnroll.AllowDrop = true;
            this.appoitEnroll.AllowUserToAddRows = false;
            this.appoitEnroll.AllowUserToDeleteRows = false;
            this.appoitEnroll.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.appoitEnroll.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.appoitEnroll.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.appoitEnroll.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.appoitEnroll.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.appoitEnroll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appoitEnroll.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.appID,
            this.deptName,
            this.docName,
            this.numMed});
            this.appoitEnroll.Location = new System.Drawing.Point(32, 683);
            this.appoitEnroll.Name = "appoitEnroll";
            this.appoitEnroll.ReadOnly = true;
            this.appoitEnroll.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.appoitEnroll.RowTemplate.Height = 24;
            this.appoitEnroll.Size = new System.Drawing.Size(694, 150);
            this.appoitEnroll.TabIndex = 38;
            this.appoitEnroll.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.appoitEnroll_CellContentClick);
            // 
            // appID
            // 
            this.appID.HeaderText = "Appoitment ID";
            this.appID.MinimumWidth = 6;
            this.appID.Name = "appID";
            this.appID.ReadOnly = true;
            // 
            // deptName
            // 
            this.deptName.HeaderText = "Department Name";
            this.deptName.MinimumWidth = 6;
            this.deptName.Name = "deptName";
            this.deptName.ReadOnly = true;
            // 
            // docName
            // 
            this.docName.HeaderText = "Doctor Name";
            this.docName.MinimumWidth = 6;
            this.docName.Name = "docName";
            this.docName.ReadOnly = true;
            // 
            // numMed
            // 
            this.numMed.HeaderText = "Number of Medicines";
            this.numMed.MinimumWidth = 6;
            this.numMed.Name = "numMed";
            this.numMed.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 639);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 41);
            this.label1.TabIndex = 40;
            this.label1.Text = "Enrolment Appoitments";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(813, 639);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(313, 41);
            this.label11.TabIndex = 41;
            this.label11.Text = "Waited Appoitments";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(544, 570);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // updataButt
            // 
            this.updataButt.BackColor = System.Drawing.Color.Silver;
            this.updataButt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.updataButt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.updataButt.FlatAppearance.BorderSize = 0;
            this.updataButt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updataButt.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updataButt.ForeColor = System.Drawing.Color.SeaShell;
            this.updataButt.Location = new System.Drawing.Point(553, 514);
            this.updataButt.Name = "updataButt";
            this.updataButt.Size = new System.Drawing.Size(238, 59);
            this.updataButt.TabIndex = 51;
            this.updataButt.Text = "Updata ";
            this.updataButt.UseVisualStyleBackColor = false;
            this.updataButt.Click += new System.EventHandler(this.updataButt_Click_1);
            // 
            // emerginCheck
            // 
            this.emerginCheck.AutoSize = true;
            this.emerginCheck.BackColor = System.Drawing.Color.Transparent;
            this.emerginCheck.CheckAlign = System.Drawing.ContentAlignment.BottomRight;
            this.emerginCheck.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.emerginCheck.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold);
            this.emerginCheck.Location = new System.Drawing.Point(1056, 242);
            this.emerginCheck.Name = "emerginCheck";
            this.emerginCheck.Size = new System.Drawing.Size(161, 46);
            this.emerginCheck.TabIndex = 49;
            this.emerginCheck.Text = "Emergin";
            this.emerginCheck.UseVisualStyleBackColor = false;
            // 
            // feMale
            // 
            this.feMale.AutoSize = true;
            this.feMale.BackColor = System.Drawing.Color.White;
            this.feMale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.feMale.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.feMale.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.feMale.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feMale.ForeColor = System.Drawing.SystemColors.Info;
            this.feMale.Location = new System.Drawing.Point(786, 370);
            this.feMale.Name = "feMale";
            this.feMale.Size = new System.Drawing.Size(102, 26);
            this.feMale.TabIndex = 46;
            this.feMale.Text = "Female";
            this.feMale.UseVisualStyleBackColor = false;
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.BackColor = System.Drawing.Color.White;
            this.male.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.male.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.male.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.male.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.male.ForeColor = System.Drawing.SystemColors.Info;
            this.male.Location = new System.Drawing.Point(684, 368);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(82, 26);
            this.male.TabIndex = 45;
            this.male.Text = "Male";
            this.male.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(561, 362);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 34);
            this.label10.TabIndex = 59;
            this.label10.Text = "Gender";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1049, 336);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 41);
            this.label8.TabIndex = 58;
            this.label8.Text = "City";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(567, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 34);
            this.label7.TabIndex = 57;
            this.label7.Text = "Age";
            // 
            // phoPatTxt
            // 
            this.phoPatTxt.BackColor = System.Drawing.Color.White;
            this.phoPatTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phoPatTxt.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoPatTxt.ForeColor = System.Drawing.Color.Black;
            this.phoPatTxt.Location = new System.Drawing.Point(1226, 136);
            this.phoPatTxt.Mask = "000-0000-0000";
            this.phoPatTxt.Name = "phoPatTxt";
            this.phoPatTxt.Size = new System.Drawing.Size(166, 28);
            this.phoPatTxt.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1049, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 41);
            this.label6.TabIndex = 56;
            this.label6.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(567, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 34);
            this.label5.TabIndex = 55;
            this.label5.Text = "Name ";
            // 
            // sSNPatTxt
            // 
            this.sSNPatTxt.BackColor = System.Drawing.Color.White;
            this.sSNPatTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sSNPatTxt.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sSNPatTxt.ForeColor = System.Drawing.Color.Black;
            this.sSNPatTxt.Location = new System.Drawing.Point(1205, 37);
            this.sSNPatTxt.Mask = "000-0000-000-000";
            this.sSNPatTxt.Name = "sSNPatTxt";
            this.sSNPatTxt.Size = new System.Drawing.Size(221, 28);
            this.sSNPatTxt.TabIndex = 47;
            // 
            // idLab
            // 
            this.idLab.AutoSize = true;
            this.idLab.BackColor = System.Drawing.Color.White;
            this.idLab.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLab.ForeColor = System.Drawing.Color.Black;
            this.idLab.Location = new System.Drawing.Point(713, 31);
            this.idLab.Name = "idLab";
            this.idLab.Size = new System.Drawing.Size(36, 41);
            this.idLab.TabIndex = 54;
            this.idLab.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1049, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 39);
            this.label3.TabIndex = 53;
            this.label3.Text = "SSN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(587, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 34);
            this.label2.TabIndex = 52;
            this.label2.Text = "ID";
            // 
            // deleteButt
            // 
            this.deleteButt.BackColor = System.Drawing.Color.Silver;
            this.deleteButt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteButt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.deleteButt.FlatAppearance.BorderSize = 0;
            this.deleteButt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteButt.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButt.ForeColor = System.Drawing.Color.SeaShell;
            this.deleteButt.Location = new System.Drawing.Point(948, 514);
            this.deleteButt.Name = "deleteButt";
            this.deleteButt.Size = new System.Drawing.Size(321, 59);
            this.deleteButt.TabIndex = 60;
            this.deleteButt.Text = "Delete Account";
            this.deleteButt.UseVisualStyleBackColor = false;
            this.deleteButt.Click += new System.EventHandler(this.deleteButt_Click);
            // 
            // ageNum
            // 
            this.ageNum.BackColor = System.Drawing.Color.Transparent;
            this.ageNum.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ageNum.BorderRadius = 22;
            this.ageNum.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.ageNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ageNum.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ageNum.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ageNum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ageNum.DisabledState.Parent = this.ageNum;
            this.ageNum.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.ageNum.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.ageNum.FillColor = System.Drawing.SystemColors.Window;
            this.ageNum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ageNum.FocusedState.Parent = this.ageNum;
            this.ageNum.Font = new System.Drawing.Font("Century Gothic", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ageNum.ForeColor = System.Drawing.Color.Black;
            this.ageNum.Location = new System.Drawing.Point(665, 242);
            this.ageNum.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.ageNum.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.ageNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ageNum.Name = "ageNum";
            this.ageNum.ShadowDecoration.Parent = this.ageNum;
            this.ageNum.Size = new System.Drawing.Size(283, 51);
            this.ageNum.TabIndex = 91;
            this.ageNum.UpDownButtonFillColor = System.Drawing.Color.White;
            this.ageNum.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ageNum.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // nameTxt
            // 
            this.nameTxt.BackColor = System.Drawing.Color.Transparent;
            this.nameTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nameTxt.BorderRadius = 10;
            this.nameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTxt.DefaultText = "";
            this.nameTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nameTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nameTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameTxt.DisabledState.Parent = this.nameTxt;
            this.nameTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameTxt.FocusedState.Parent = this.nameTxt;
            this.nameTxt.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTxt.ForeColor = System.Drawing.Color.Black;
            this.nameTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameTxt.HoverState.Parent = this.nameTxt;
            this.nameTxt.Location = new System.Drawing.Point(665, 136);
            this.nameTxt.Margin = new System.Windows.Forms.Padding(5);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.PasswordChar = '\0';
            this.nameTxt.PlaceholderText = "";
            this.nameTxt.SelectedText = "";
            this.nameTxt.ShadowDecoration.Parent = this.nameTxt;
            this.nameTxt.Size = new System.Drawing.Size(283, 44);
            this.nameTxt.TabIndex = 92;
            // 
            // cityCombo
            // 
            this.cityCombo.BackColor = System.Drawing.Color.Transparent;
            this.cityCombo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cityCombo.BorderRadius = 10;
            this.cityCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cityCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cityCombo.FillColor = System.Drawing.SystemColors.Window;
            this.cityCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cityCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cityCombo.FocusedState.Parent = this.cityCombo;
            this.cityCombo.Font = new System.Drawing.Font("Century Schoolbook", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cityCombo.ForeColor = System.Drawing.Color.Black;
            this.cityCombo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cityCombo.HoverState.FillColor = System.Drawing.Color.White;
            this.cityCombo.HoverState.ForeColor = System.Drawing.Color.Black;
            this.cityCombo.HoverState.Parent = this.cityCombo;
            this.cityCombo.ItemHeight = 30;
            this.cityCombo.Items.AddRange(new object[] {
            "Fayoum",
            "Cairo",
            "Port Said",
            "Alexandria",
            "BaniSwief"});
            this.cityCombo.ItemsAppearance.Parent = this.cityCombo;
            this.cityCombo.Location = new System.Drawing.Point(1169, 341);
            this.cityCombo.Name = "cityCombo";
            this.cityCombo.ShadowDecoration.Parent = this.cityCombo;
            this.cityCombo.Size = new System.Drawing.Size(210, 36);
            this.cityCombo.TabIndex = 93;
            // 
            // HomePatientControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.cityCombo);
            this.Controls.Add(this.ageNum);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.deleteButt);
            this.Controls.Add(this.updataButt);
            this.Controls.Add(this.emerginCheck);
            this.Controls.Add(this.feMale);
            this.Controls.Add(this.male);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.phoPatTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sSNPatTxt);
            this.Controls.Add(this.idLab);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.waitedApp);
            this.Controls.Add(this.appoitEnroll);
            this.Name = "HomePatientControl";
            this.Size = new System.Drawing.Size(1429, 921);
            this.Load += new System.EventHandler(this.homeControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.waitedApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appoitEnroll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView waitedApp;
        private System.Windows.Forms.DataGridView appoitEnroll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button updataButt;
        private System.Windows.Forms.RadioButton emerginCheck;
        private System.Windows.Forms.CheckBox feMale;
        private System.Windows.Forms.CheckBox male;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox phoPatTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox sSNPatTxt;
        private System.Windows.Forms.Label idLab;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn appoitIWaitD;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptWaitName;
        private System.Windows.Forms.DataGridViewTextBoxColumn indexWaitNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn appID;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptName;
        private System.Windows.Forms.DataGridViewTextBoxColumn docName;
        private System.Windows.Forms.DataGridViewTextBoxColumn numMed;
        private System.Windows.Forms.Button deleteButt;
        private Guna.UI2.WinForms.Guna2NumericUpDown ageNum;
        private Guna.UI2.WinForms.Guna2TextBox nameTxt;
        private Guna.UI2.WinForms.Guna2ComboBox cityCombo;
    }
}
