
namespace FinalAlgorithmApp.userControl
{
    partial class DetailAppoitDocControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailAppoitDocControl));
            this.excepLab = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MedApp = new System.Windows.Forms.DataGridView();
            this.medName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medQun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appIDTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.deleteApp = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.idLab = new Guna.UI2.WinForms.Guna2TextBox();
            this.patNameLab = new Guna.UI2.WinForms.Guna2TextBox();
            this.addMeds = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.MedApp)).BeginInit();
            this.SuspendLayout();
            // 
            // excepLab
            // 
            this.excepLab.AutoSize = true;
            this.excepLab.Font = new System.Drawing.Font("Agency FB", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excepLab.Location = new System.Drawing.Point(497, 116);
            this.excepLab.Name = "excepLab";
            this.excepLab.Size = new System.Drawing.Size(167, 24);
            this.excepLab.TabIndex = 69;
            this.excepLab.Text = "Invaild Input, Enrer Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(234, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 33);
            this.label1.TabIndex = 59;
            this.label1.Text = "Appoitment ID";
            // 
            // MedApp
            // 
            this.MedApp.AllowDrop = true;
            this.MedApp.AllowUserToAddRows = false;
            this.MedApp.AllowUserToDeleteRows = false;
            this.MedApp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MedApp.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.MedApp.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.MedApp.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.MedApp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MedApp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.medName,
            this.medQun});
            this.MedApp.Location = new System.Drawing.Point(32, 342);
            this.MedApp.Name = "MedApp";
            this.MedApp.ReadOnly = true;
            this.MedApp.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.MedApp.RowTemplate.Height = 24;
            this.MedApp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.MedApp.Size = new System.Drawing.Size(474, 188);
            this.MedApp.TabIndex = 58;
            this.MedApp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.medApp_CellContentClick);
            // 
            // medName
            // 
            this.medName.HeaderText = "Medicine Name";
            this.medName.MinimumWidth = 6;
            this.medName.Name = "medName";
            this.medName.ReadOnly = true;
            // 
            // medQun
            // 
            this.medQun.HeaderText = "Quantity";
            this.medQun.MinimumWidth = 6;
            this.medQun.Name = "medQun";
            this.medQun.ReadOnly = true;
            // 
            // appIDTxt
            // 
            this.appIDTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.appIDTxt.BorderRadius = 18;
            this.appIDTxt.BorderThickness = 4;
            this.appIDTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.appIDTxt.DefaultText = "";
            this.appIDTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.appIDTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.appIDTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.appIDTxt.DisabledState.Parent = this.appIDTxt;
            this.appIDTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.appIDTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.appIDTxt.FocusedState.Parent = this.appIDTxt;
            this.appIDTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appIDTxt.ForeColor = System.Drawing.Color.Black;
            this.appIDTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.appIDTxt.HoverState.FillColor = System.Drawing.Color.White;
            this.appIDTxt.HoverState.ForeColor = System.Drawing.Color.Black;
            this.appIDTxt.HoverState.Parent = this.appIDTxt;
            this.appIDTxt.Location = new System.Drawing.Point(450, 60);
            this.appIDTxt.Margin = new System.Windows.Forms.Padding(4);
            this.appIDTxt.Name = "appIDTxt";
            this.appIDTxt.PasswordChar = '\0';
            this.appIDTxt.PlaceholderText = "";
            this.appIDTxt.SelectedText = "";
            this.appIDTxt.ShadowDecoration.Parent = this.appIDTxt;
            this.appIDTxt.Size = new System.Drawing.Size(234, 52);
            this.appIDTxt.TabIndex = 57;
            this.appIDTxt.TextChanged += new System.EventHandler(this.AppIDTxt_TextChanged);
            // 
            // deleteApp
            // 
            this.deleteApp.Animated = true;
            this.deleteApp.AutoRoundedCorners = true;
            this.deleteApp.BorderRadius = 39;
            this.deleteApp.CheckedState.Parent = this.deleteApp;
            this.deleteApp.CustomImages.Parent = this.deleteApp;
            this.deleteApp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.deleteApp.Font = new System.Drawing.Font("Simplified Arabic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteApp.ForeColor = System.Drawing.Color.White;
            this.deleteApp.HoverState.ForeColor = System.Drawing.Color.MistyRose;
            this.deleteApp.HoverState.Parent = this.deleteApp;
            this.deleteApp.Location = new System.Drawing.Point(802, 459);
            this.deleteApp.Name = "deleteApp";
            this.deleteApp.ShadowDecoration.Parent = this.deleteApp;
            this.deleteApp.Size = new System.Drawing.Size(304, 80);
            this.deleteApp.TabIndex = 68;
            this.deleteApp.Text = "Delete  Appoitment";
            this.deleteApp.Click += new System.EventHandler(this.deleteApp_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(415, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 30);
            this.label5.TabIndex = 62;
            this.label5.Text = "Patient Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 30);
            this.label2.TabIndex = 60;
            this.label2.Text = "Appoitment ID";
            // 
            // idLab
            // 
            this.idLab.BackColor = System.Drawing.Color.White;
            this.idLab.BorderRadius = 18;
            this.idLab.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.idLab.BorderThickness = 4;
            this.idLab.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.idLab.DefaultText = "";
            this.idLab.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.idLab.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.idLab.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.idLab.DisabledState.Parent = this.idLab;
            this.idLab.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.idLab.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.idLab.FocusedState.Parent = this.idLab;
            this.idLab.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLab.ForeColor = System.Drawing.Color.Black;
            this.idLab.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.idLab.HoverState.FillColor = System.Drawing.Color.White;
            this.idLab.HoverState.ForeColor = System.Drawing.Color.Black;
            this.idLab.HoverState.Parent = this.idLab;
            this.idLab.Location = new System.Drawing.Point(229, 203);
            this.idLab.Margin = new System.Windows.Forms.Padding(4);
            this.idLab.Name = "idLab";
            this.idLab.PasswordChar = '\0';
            this.idLab.PlaceholderForeColor = System.Drawing.Color.Black;
            this.idLab.PlaceholderText = "";
            this.idLab.ReadOnly = true;
            this.idLab.SelectedText = "";
            this.idLab.ShadowDecoration.Parent = this.idLab;
            this.idLab.Size = new System.Drawing.Size(120, 52);
            this.idLab.TabIndex = 70;
            // 
            // patNameLab
            // 
            this.patNameLab.BackColor = System.Drawing.Color.White;
            this.patNameLab.BorderRadius = 18;
            this.patNameLab.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.patNameLab.BorderThickness = 4;
            this.patNameLab.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.patNameLab.DefaultText = "";
            this.patNameLab.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.patNameLab.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.patNameLab.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.patNameLab.DisabledState.Parent = this.patNameLab;
            this.patNameLab.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.patNameLab.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.patNameLab.FocusedState.Parent = this.patNameLab;
            this.patNameLab.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patNameLab.ForeColor = System.Drawing.Color.Black;
            this.patNameLab.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.patNameLab.HoverState.FillColor = System.Drawing.Color.White;
            this.patNameLab.HoverState.ForeColor = System.Drawing.Color.Black;
            this.patNameLab.HoverState.Parent = this.patNameLab;
            this.patNameLab.Location = new System.Drawing.Point(607, 214);
            this.patNameLab.Margin = new System.Windows.Forms.Padding(4);
            this.patNameLab.Name = "patNameLab";
            this.patNameLab.PasswordChar = '\0';
            this.patNameLab.PlaceholderForeColor = System.Drawing.Color.Black;
            this.patNameLab.PlaceholderText = "";
            this.patNameLab.ReadOnly = true;
            this.patNameLab.SelectedText = "";
            this.patNameLab.ShadowDecoration.Parent = this.patNameLab;
            this.patNameLab.Size = new System.Drawing.Size(255, 52);
            this.patNameLab.TabIndex = 71;
            // 
            // addMeds
            // 
            this.addMeds.Animated = true;
            this.addMeds.AutoRoundedCorners = true;
            this.addMeds.BorderRadius = 32;
            this.addMeds.CheckedState.Parent = this.addMeds;
            this.addMeds.CustomImages.Parent = this.addMeds;
            this.addMeds.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.addMeds.Font = new System.Drawing.Font("Sitka Display", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMeds.ForeColor = System.Drawing.Color.White;
            this.addMeds.HoverState.ForeColor = System.Drawing.Color.MistyRose;
            this.addMeds.HoverState.Parent = this.addMeds;
            this.addMeds.Location = new System.Drawing.Point(521, 358);
            this.addMeds.Name = "addMeds";
            this.addMeds.ShadowDecoration.Parent = this.addMeds;
            this.addMeds.Size = new System.Drawing.Size(143, 67);
            this.addMeds.TabIndex = 72;
            this.addMeds.Text = "Add | Edit Medicines";
            this.addMeds.Click += new System.EventHandler(this.addMeds_Click);
            // 
            // DetailAppoitDocControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.addMeds);
            this.Controls.Add(this.patNameLab);
            this.Controls.Add(this.idLab);
            this.Controls.Add(this.excepLab);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MedApp);
            this.Controls.Add(this.appIDTxt);
            this.Controls.Add(this.deleteApp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.Name = "DetailAppoitDocControl";
            this.Size = new System.Drawing.Size(1235, 563);
            this.Load += new System.EventHandler(this.DetailAppoitDoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MedApp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label excepLab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView MedApp;
        private Guna.UI2.WinForms.Guna2TextBox appIDTxt;
        private Guna.UI2.WinForms.Guna2Button deleteApp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn medName;
        private System.Windows.Forms.DataGridViewTextBoxColumn medQun;
        private Guna.UI2.WinForms.Guna2TextBox idLab;
        private Guna.UI2.WinForms.Guna2TextBox patNameLab;
        private Guna.UI2.WinForms.Guna2Button addMeds;
    }
}
