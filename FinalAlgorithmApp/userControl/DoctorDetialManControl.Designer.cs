
namespace FinalAlgorithmApp.userControl
{
    partial class DoctorDetialManControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorDetialManControl));
            this.docIDTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.AppoitDoc = new System.Windows.Forms.DataGridView();
            this.appDocID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appDocName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedAppDocNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.idLab = new System.Windows.Forms.Label();
            this.nameLab = new System.Windows.Forms.Label();
            this.DepIDLab = new System.Windows.Forms.Label();
            this.salaryTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.deleteDep = new Guna.UI2.WinForms.Guna2Button();
            this.excepLab = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AppoitDoc)).BeginInit();
            this.SuspendLayout();
            // 
            // docIDTxt
            // 
            this.docIDTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.docIDTxt.BorderRadius = 10;
            this.docIDTxt.BorderThickness = 3;
            this.docIDTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.docIDTxt.DefaultText = "";
            this.docIDTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.docIDTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.docIDTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.docIDTxt.DisabledState.Parent = this.docIDTxt;
            this.docIDTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.docIDTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.docIDTxt.FocusedState.Parent = this.docIDTxt;
            this.docIDTxt.ForeColor = System.Drawing.Color.Black;
            this.docIDTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.docIDTxt.HoverState.Parent = this.docIDTxt;
            this.docIDTxt.Location = new System.Drawing.Point(587, 80);
            this.docIDTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.docIDTxt.Name = "docIDTxt";
            this.docIDTxt.PasswordChar = '\0';
            this.docIDTxt.PlaceholderText = "";
            this.docIDTxt.SelectedText = "";
            this.docIDTxt.ShadowDecoration.Parent = this.docIDTxt;
            this.docIDTxt.Size = new System.Drawing.Size(293, 52);
            this.docIDTxt.TabIndex = 0;
            this.docIDTxt.TextChanged += new System.EventHandler(this.docIDTxt_TextChanged);
            this.docIDTxt.MouseLeave += new System.EventHandler(this.docIDTxt_MouseLeave);
            // 
            // AppoitDoc
            // 
            this.AppoitDoc.AllowDrop = true;
            this.AppoitDoc.AllowUserToAddRows = false;
            this.AppoitDoc.AllowUserToDeleteRows = false;
            this.AppoitDoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AppoitDoc.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.AppoitDoc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.AppoitDoc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.AppoitDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppoitDoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.appDocID,
            this.appDocName,
            this.MedAppDocNum});
            this.AppoitDoc.Location = new System.Drawing.Point(0, 500);
            this.AppoitDoc.Name = "AppoitDoc";
            this.AppoitDoc.ReadOnly = true;
            this.AppoitDoc.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.AppoitDoc.RowTemplate.Height = 24;
            this.AppoitDoc.Size = new System.Drawing.Size(581, 188);
            this.AppoitDoc.TabIndex = 43;
            this.AppoitDoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AppoitDoc_CellContentClick);
            // 
            // appDocID
            // 
            this.appDocID.HeaderText = "Appoitment ID";
            this.appDocID.MinimumWidth = 6;
            this.appDocID.Name = "appDocID";
            this.appDocID.ReadOnly = true;
            // 
            // appDocName
            // 
            this.appDocName.HeaderText = "Patient Name";
            this.appDocName.MinimumWidth = 6;
            this.appDocName.Name = "appDocName";
            this.appDocName.ReadOnly = true;
            // 
            // MedAppDocNum
            // 
            this.MedAppDocNum.HeaderText = "Number of Medicines";
            this.MedAppDocNum.MinimumWidth = 6;
            this.MedAppDocNum.Name = "MedAppDocNum";
            this.MedAppDocNum.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(426, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 33);
            this.label1.TabIndex = 44;
            this.label1.Text = "Doctor ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 33);
            this.label2.TabIndex = 45;
            this.label2.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 33);
            this.label4.TabIndex = 47;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(385, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 30);
            this.label5.TabIndex = 48;
            this.label5.Text = "Department ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(384, 370);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 33);
            this.label6.TabIndex = 49;
            this.label6.Text = "Salary";
            // 
            // idLab
            // 
            this.idLab.AutoSize = true;
            this.idLab.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLab.Location = new System.Drawing.Point(208, 259);
            this.idLab.Name = "idLab";
            this.idLab.Size = new System.Drawing.Size(33, 26);
            this.idLab.TabIndex = 50;
            this.idLab.Text = "ID";
            // 
            // nameLab
            // 
            this.nameLab.AutoSize = true;
            this.nameLab.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLab.Location = new System.Drawing.Point(184, 377);
            this.nameLab.Name = "nameLab";
            this.nameLab.Size = new System.Drawing.Size(69, 26);
            this.nameLab.TabIndex = 51;
            this.nameLab.Text = "Name";
            // 
            // DepIDLab
            // 
            this.DepIDLab.AutoSize = true;
            this.DepIDLab.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepIDLab.Location = new System.Drawing.Point(629, 271);
            this.DepIDLab.Name = "DepIDLab";
            this.DepIDLab.Size = new System.Drawing.Size(33, 26);
            this.DepIDLab.TabIndex = 53;
            this.DepIDLab.Text = "ID";
            // 
            // salaryTxt
            // 
            this.salaryTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.salaryTxt.BorderRadius = 20;
            this.salaryTxt.BorderThickness = 3;
            this.salaryTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.salaryTxt.DefaultText = "";
            this.salaryTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.salaryTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.salaryTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.salaryTxt.DisabledState.Parent = this.salaryTxt;
            this.salaryTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.salaryTxt.Enabled = false;
            this.salaryTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.salaryTxt.FocusedState.Parent = this.salaryTxt;
            this.salaryTxt.ForeColor = System.Drawing.Color.Black;
            this.salaryTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.salaryTxt.HoverState.Parent = this.salaryTxt;
            this.salaryTxt.Location = new System.Drawing.Point(515, 356);
            this.salaryTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.salaryTxt.Name = "salaryTxt";
            this.salaryTxt.PasswordChar = '\0';
            this.salaryTxt.PlaceholderForeColor = System.Drawing.Color.White;
            this.salaryTxt.PlaceholderText = "";
            this.salaryTxt.SelectedText = "";
            this.salaryTxt.ShadowDecoration.Parent = this.salaryTxt;
            this.salaryTxt.Size = new System.Drawing.Size(218, 59);
            this.salaryTxt.TabIndex = 54;
            this.salaryTxt.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            this.salaryTxt.MouseLeave += new System.EventHandler(this.salaryTxt_MouseLeave);
            // 
            // deleteDep
            // 
            this.deleteDep.Animated = true;
            this.deleteDep.AutoRoundedCorners = true;
            this.deleteDep.BorderRadius = 38;
            this.deleteDep.CheckedState.Parent = this.deleteDep;
            this.deleteDep.CustomImages.Parent = this.deleteDep;
            this.deleteDep.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.deleteDep.Font = new System.Drawing.Font("Segoe UI Historic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteDep.ForeColor = System.Drawing.Color.White;
            this.deleteDep.HoverState.ForeColor = System.Drawing.Color.MistyRose;
            this.deleteDep.HoverState.Parent = this.deleteDep;
            this.deleteDep.Location = new System.Drawing.Point(645, 546);
            this.deleteDep.Name = "deleteDep";
            this.deleteDep.ShadowDecoration.Parent = this.deleteDep;
            this.deleteDep.Size = new System.Drawing.Size(235, 79);
            this.deleteDep.TabIndex = 55;
            this.deleteDep.Text = "Delete Department";
            this.deleteDep.Click += new System.EventHandler(this.deleteDep_Click);
            // 
            // excepLab
            // 
            this.excepLab.AutoSize = true;
            this.excepLab.Font = new System.Drawing.Font("Agency FB", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excepLab.Location = new System.Drawing.Point(703, 136);
            this.excepLab.Name = "excepLab";
            this.excepLab.Size = new System.Drawing.Size(167, 24);
            this.excepLab.TabIndex = 56;
            this.excepLab.Text = "Invaild Input, Enrer Number";
            // 
            // DoctorDetialManControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.excepLab);
            this.Controls.Add(this.deleteDep);
            this.Controls.Add(this.salaryTxt);
            this.Controls.Add(this.DepIDLab);
            this.Controls.Add(this.nameLab);
            this.Controls.Add(this.idLab);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AppoitDoc);
            this.Controls.Add(this.docIDTxt);
            this.DoubleBuffered = true;
            this.Name = "DoctorDetialManControl";
            this.Size = new System.Drawing.Size(1313, 694);
            this.Load += new System.EventHandler(this.DoctorDetialManControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AppoitDoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox docIDTxt;
        private System.Windows.Forms.DataGridView AppoitDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn appDocID;
        private System.Windows.Forms.DataGridViewTextBoxColumn appDocName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedAppDocNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label idLab;
        private System.Windows.Forms.Label nameLab;
        private System.Windows.Forms.Label DepIDLab;
        private Guna.UI2.WinForms.Guna2TextBox salaryTxt;
        private Guna.UI2.WinForms.Guna2Button deleteDep;
        private System.Windows.Forms.Label excepLab;
    }
}
