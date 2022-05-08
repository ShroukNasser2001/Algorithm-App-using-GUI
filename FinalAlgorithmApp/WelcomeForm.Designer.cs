
namespace FinalAlgorithmApp
{
    partial class WelcomeForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeForm));
            this.doctorBut = new System.Windows.Forms.Button();
            this.patientBut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.SuspendLayout();
            // 
            // doctorBut
            // 
            this.doctorBut.BackColor = System.Drawing.Color.Transparent;
            this.doctorBut.FlatAppearance.BorderSize = 0;
            this.doctorBut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.doctorBut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.doctorBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doctorBut.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.doctorBut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(184)))), ((int)(((byte)(191)))));
            this.doctorBut.Location = new System.Drawing.Point(333, 337);
            this.doctorBut.Name = "doctorBut";
            this.doctorBut.Size = new System.Drawing.Size(189, 57);
            this.doctorBut.TabIndex = 2;
            this.doctorBut.Text = "Doctor";
            this.doctorBut.UseVisualStyleBackColor = false;
            this.doctorBut.Click += new System.EventHandler(this.doctorBut_Click);
            this.doctorBut.MouseLeave += new System.EventHandler(this.doctorBut_MouseLeave);
            this.doctorBut.MouseMove += new System.Windows.Forms.MouseEventHandler(this.doctorBut_MouseMove);
            // 
            // patientBut
            // 
            this.patientBut.BackColor = System.Drawing.Color.Transparent;
            this.patientBut.FlatAppearance.BorderSize = 0;
            this.patientBut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.patientBut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.patientBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.patientBut.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientBut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(184)))), ((int)(((byte)(191)))));
            this.patientBut.Location = new System.Drawing.Point(2, 336);
            this.patientBut.Name = "patientBut";
            this.patientBut.Size = new System.Drawing.Size(210, 57);
            this.patientBut.TabIndex = 1;
            this.patientBut.Text = "Patient";
            this.patientBut.UseVisualStyleBackColor = false;
            this.patientBut.Click += new System.EventHandler(this.patientBut_Click);
            this.patientBut.MouseLeave += new System.EventHandler(this.patientBut_MouseLeave);
            this.patientBut.MouseMove += new System.Windows.Forms.MouseEventHandler(this.patientBut_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(184)))), ((int)(((byte)(191)))));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.label1.Location = new System.Drawing.Point(220, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome";
            this.label1.UseCompatibleTextRendering = true;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            // 
            // WelcomeForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScrollMargin = new System.Drawing.Size(100, 200);
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(551, 688);
            this.Controls.Add(this.doctorBut);
            this.Controls.Add(this.patientBut);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.Name = "WelcomeForm";
            this.RightToLeftLayout = true;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WelcomeForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.WelcomeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button doctorBut;
        private System.Windows.Forms.Button patientBut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}