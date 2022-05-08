
namespace FinalAlgorithmApp
{
    partial class PatientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.outButt = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.showAppoitButt = new System.Windows.Forms.Button();
            this.addAppoitButt = new System.Windows.Forms.Button();
            this.homeButt = new System.Windows.Forms.Button();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panelControl = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(15)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.outButt);
            this.panel1.Controls.Add(this.close);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1221, 70);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // outButt
            // 
            this.outButt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(15)))), ((int)(((byte)(64)))));
            this.outButt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.outButt.FlatAppearance.BorderSize = 0;
            this.outButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.outButt.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outButt.ForeColor = System.Drawing.Color.DodgerBlue;
            this.outButt.Location = new System.Drawing.Point(897, 0);
            this.outButt.Name = "outButt";
            this.outButt.Size = new System.Drawing.Size(145, 70);
            this.outButt.TabIndex = 4;
            this.outButt.Text = "Log Out";
            this.outButt.UseVisualStyleBackColor = true;
            this.outButt.Click += new System.EventHandler(this.outButt_Click);
            // 
            // close
            // 
            this.close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.Color.DodgerBlue;
            this.close.Location = new System.Drawing.Point(1064, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(142, 70);
            this.close.TabIndex = 2;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(78, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Patient Form";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.showAppoitButt);
            this.panel2.Controls.Add(this.addAppoitButt);
            this.panel2.Controls.Add(this.homeButt);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1221, 64);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // showAppoitButt
            // 
            this.showAppoitButt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.showAppoitButt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.showAppoitButt.FlatAppearance.BorderSize = 0;
            this.showAppoitButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showAppoitButt.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAppoitButt.Location = new System.Drawing.Point(405, -10);
            this.showAppoitButt.Name = "showAppoitButt";
            this.showAppoitButt.Size = new System.Drawing.Size(405, 78);
            this.showAppoitButt.TabIndex = 3;
            this.showAppoitButt.Text = "Show Appoitment";
            this.showAppoitButt.UseVisualStyleBackColor = false;
            this.showAppoitButt.Click += new System.EventHandler(this.showAppoitButt_Click);
            // 
            // addAppoitButt
            // 
            this.addAppoitButt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.addAppoitButt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addAppoitButt.FlatAppearance.BorderSize = 0;
            this.addAppoitButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAppoitButt.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAppoitButt.Location = new System.Drawing.Point(800, -10);
            this.addAppoitButt.Name = "addAppoitButt";
            this.addAppoitButt.Size = new System.Drawing.Size(420, 78);
            this.addAppoitButt.TabIndex = 2;
            this.addAppoitButt.Text = "Add Appoitment";
            this.addAppoitButt.UseVisualStyleBackColor = false;
            this.addAppoitButt.Click += new System.EventHandler(this.addAppoitButt_Click);
            // 
            // homeButt
            // 
            this.homeButt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.homeButt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homeButt.FlatAppearance.BorderSize = 0;
            this.homeButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButt.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButt.Location = new System.Drawing.Point(0, -10);
            this.homeButt.Name = "homeButt";
            this.homeButt.Size = new System.Drawing.Size(413, 78);
            this.homeButt.TabIndex = 1;
            this.homeButt.Text = "Home";
            this.homeButt.UseVisualStyleBackColor = false;
            this.homeButt.Click += new System.EventHandler(this.homeButt_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.panel1;
            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl.Location = new System.Drawing.Point(0, 134);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(1221, 921);
            this.panelControl.TabIndex = 3;
            this.panelControl.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl_Paint);
            // 
            // PatientForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1221, 1055);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PatientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PatientForm";
            this.Load += new System.EventHandler(this.PatientForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button homeButt;
        private System.Windows.Forms.Button addAppoitButt;
        private System.Windows.Forms.Button showAppoitButt;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button outButt;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Panel panelControl;
    }
}