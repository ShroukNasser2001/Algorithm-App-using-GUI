
namespace FinalAlgorithmApp.userControl
{
    partial class RegDocManControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegDocManControl));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cityCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.phoDocxt = new System.Windows.Forms.MaskedTextBox();
            this.sSNDocTxt = new System.Windows.Forms.MaskedTextBox();
            this.ageNum = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.nameTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.enrollButt = new Guna.UI2.WinForms.Guna2Button();
            this.label8 = new System.Windows.Forms.Label();
            this.feMale = new System.Windows.Forms.CheckBox();
            this.male = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.deptsCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.salaryTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageNum)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(988, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(559, 603);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 100;
            this.pictureBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(539, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 41);
            this.label6.TabIndex = 101;
            this.label6.Text = "Phone";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // cityCombo
            // 
            this.cityCombo.BackColor = System.Drawing.Color.White;
            this.cityCombo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cityCombo.BorderRadius = 10;
            this.cityCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cityCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cityCombo.FillColor = System.Drawing.SystemColors.Window;
            this.cityCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cityCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cityCombo.FocusedState.Parent = this.cityCombo;
            this.cityCombo.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Bold);
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
            this.cityCombo.Location = new System.Drawing.Point(731, 446);
            this.cityCombo.Name = "cityCombo";
            this.cityCombo.ShadowDecoration.Parent = this.cityCombo;
            this.cityCombo.Size = new System.Drawing.Size(210, 36);
            this.cityCombo.TabIndex = 9;
            // 
            // phoDocxt
            // 
            this.phoDocxt.BackColor = System.Drawing.Color.White;
            this.phoDocxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phoDocxt.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoDocxt.ForeColor = System.Drawing.Color.Black;
            this.phoDocxt.Location = new System.Drawing.Point(677, 125);
            this.phoDocxt.Mask = "000-0000-0000";
            this.phoDocxt.Name = "phoDocxt";
            this.phoDocxt.Size = new System.Drawing.Size(174, 28);
            this.phoDocxt.TabIndex = 2;
            this.phoDocxt.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.phoPatTxt_MaskInputRejected);
            // 
            // sSNDocTxt
            // 
            this.sSNDocTxt.BackColor = System.Drawing.Color.White;
            this.sSNDocTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sSNDocTxt.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sSNDocTxt.ForeColor = System.Drawing.Color.Black;
            this.sSNDocTxt.Location = new System.Drawing.Point(180, 129);
            this.sSNDocTxt.Mask = "000-0000-000-000";
            this.sSNDocTxt.Name = "sSNDocTxt";
            this.sSNDocTxt.Size = new System.Drawing.Size(221, 28);
            this.sSNDocTxt.TabIndex = 1;
            // 
            // ageNum
            // 
            this.ageNum.BackColor = System.Drawing.Color.White;
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
            this.ageNum.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Bold);
            this.ageNum.ForeColor = System.Drawing.Color.Black;
            this.ageNum.Location = new System.Drawing.Point(147, 332);
            this.ageNum.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
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
            this.ageNum.TabIndex = 5;
            this.ageNum.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ageNum.UpDownButtonForeColor = System.Drawing.Color.White;
            this.ageNum.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // nameTxt
            // 
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
            this.nameTxt.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTxt.ForeColor = System.Drawing.Color.Black;
            this.nameTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameTxt.HoverState.Parent = this.nameTxt;
            this.nameTxt.Location = new System.Drawing.Point(156, 230);
            this.nameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.PasswordChar = '\0';
            this.nameTxt.PlaceholderText = "";
            this.nameTxt.SelectedText = "";
            this.nameTxt.ShadowDecoration.Parent = this.nameTxt;
            this.nameTxt.Size = new System.Drawing.Size(283, 44);
            this.nameTxt.TabIndex = 3;
            // 
            // enrollButt
            // 
            this.enrollButt.Animated = true;
            this.enrollButt.AutoRoundedCorners = true;
            this.enrollButt.BackColor = System.Drawing.Color.Transparent;
            this.enrollButt.BorderColor = System.Drawing.Color.White;
            this.enrollButt.BorderRadius = 28;
            this.enrollButt.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.enrollButt.CheckedState.Parent = this.enrollButt;
            this.enrollButt.CustomBorderColor = System.Drawing.Color.White;
            this.enrollButt.CustomImages.Parent = this.enrollButt;
            this.enrollButt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.enrollButt.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.enrollButt.ForeColor = System.Drawing.Color.White;
            this.enrollButt.HoverState.BorderColor = System.Drawing.Color.White;
            this.enrollButt.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.enrollButt.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.enrollButt.HoverState.ForeColor = System.Drawing.Color.AliceBlue;
            this.enrollButt.HoverState.Parent = this.enrollButt;
            this.enrollButt.Location = new System.Drawing.Point(398, 548);
            this.enrollButt.Name = "enrollButt";
            this.enrollButt.ShadowDecoration.Parent = this.enrollButt;
            this.enrollButt.Size = new System.Drawing.Size(253, 58);
            this.enrollButt.TabIndex = 10;
            this.enrollButt.Text = "Enroll";
            this.enrollButt.Click += new System.EventHandler(this.enrollButt_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(619, 436);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 41);
            this.label8.TabIndex = 102;
            this.label8.Text = "City";
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
            this.feMale.Location = new System.Drawing.Point(771, 338);
            this.feMale.Name = "feMale";
            this.feMale.Size = new System.Drawing.Size(102, 26);
            this.feMale.TabIndex = 7;
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
            this.male.Location = new System.Drawing.Point(667, 338);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(82, 26);
            this.male.TabIndex = 6;
            this.male.Text = "Male";
            this.male.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(41, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 34);
            this.label7.TabIndex = 97;
            this.label7.Text = "Age";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 34);
            this.label5.TabIndex = 96;
            this.label5.Text = "Name ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 39);
            this.label3.TabIndex = 95;
            this.label3.Text = "SSN";
            // 
            // deptsCombo
            // 
            this.deptsCombo.BackColor = System.Drawing.Color.White;
            this.deptsCombo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.deptsCombo.BorderRadius = 10;
            this.deptsCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.deptsCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deptsCombo.FillColor = System.Drawing.SystemColors.Window;
            this.deptsCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.deptsCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.deptsCombo.FocusedState.Parent = this.deptsCombo;
            this.deptsCombo.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Bold);
            this.deptsCombo.ForeColor = System.Drawing.Color.Black;
            this.deptsCombo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.deptsCombo.HoverState.FillColor = System.Drawing.Color.White;
            this.deptsCombo.HoverState.ForeColor = System.Drawing.Color.Black;
            this.deptsCombo.HoverState.Parent = this.deptsCombo;
            this.deptsCombo.ItemHeight = 30;
            this.deptsCombo.ItemsAppearance.Parent = this.deptsCombo;
            this.deptsCombo.Location = new System.Drawing.Point(265, 451);
            this.deptsCombo.Name = "deptsCombo";
            this.deptsCombo.ShadowDecoration.Parent = this.deptsCombo;
            this.deptsCombo.Size = new System.Drawing.Size(295, 36);
            this.deptsCombo.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 446);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 41);
            this.label1.TabIndex = 105;
            this.label1.Text = "Departments";
            // 
            // salaryTxt
            // 
            this.salaryTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.salaryTxt.BorderRadius = 10;
            this.salaryTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.salaryTxt.DefaultText = "";
            this.salaryTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.salaryTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.salaryTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.salaryTxt.DisabledState.Parent = this.salaryTxt;
            this.salaryTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.salaryTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.salaryTxt.FocusedState.Parent = this.salaryTxt;
            this.salaryTxt.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salaryTxt.ForeColor = System.Drawing.Color.Black;
            this.salaryTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.salaryTxt.HoverState.Parent = this.salaryTxt;
            this.salaryTxt.Location = new System.Drawing.Point(667, 220);
            this.salaryTxt.Margin = new System.Windows.Forms.Padding(4);
            this.salaryTxt.Name = "salaryTxt";
            this.salaryTxt.PasswordChar = '\0';
            this.salaryTxt.PlaceholderText = "";
            this.salaryTxt.SelectedText = "";
            this.salaryTxt.ShadowDecoration.Parent = this.salaryTxt;
            this.salaryTxt.Size = new System.Drawing.Size(219, 44);
            this.salaryTxt.TabIndex = 4;
            this.salaryTxt.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(526, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 34);
            this.label2.TabIndex = 107;
            this.label2.Text = "Salary";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(520, 332);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 34);
            this.label10.TabIndex = 98;
            this.label10.Text = "Gender";
            // 
            // RegDocManControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.salaryTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deptsCombo);
            this.Controls.Add(this.ageNum);
            this.Controls.Add(this.cityCombo);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.enrollButt);
            this.Controls.Add(this.sSNDocTxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.phoDocxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.feMale);
            this.Controls.Add(this.male);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Name = "RegDocManControl";
            this.Size = new System.Drawing.Size(1547, 611);
            this.Load += new System.EventHandler(this.RegDocManControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2ComboBox cityCombo;
        private System.Windows.Forms.MaskedTextBox phoDocxt;
        private System.Windows.Forms.MaskedTextBox sSNDocTxt;
        private Guna.UI2.WinForms.Guna2NumericUpDown ageNum;
        private Guna.UI2.WinForms.Guna2TextBox nameTxt;
        private Guna.UI2.WinForms.Guna2Button enrollButt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox feMale;
        private System.Windows.Forms.CheckBox male;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox deptsCombo;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox salaryTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
    }
}
