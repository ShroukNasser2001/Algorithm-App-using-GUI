
namespace FinalAlgorithmApp.userControl
{
    partial class LoginPatControl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPatControl));
            this.label1 = new System.Windows.Forms.Label();
            this.excepLab = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.idTxtLog = new Guna.UI2.WinForms.Guna2TextBox();
            this.logBut = new Guna.UI2.WinForms.Guna2Button();
            this.regBut = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.back = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(365, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your System ID ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // excepLab
            // 
            this.excepLab.AutoSize = true;
            this.excepLab.Font = new System.Drawing.Font("Agency FB", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excepLab.Location = new System.Drawing.Point(467, 262);
            this.excepLab.Name = "excepLab";
            this.excepLab.Size = new System.Drawing.Size(167, 24);
            this.excepLab.TabIndex = 5;
            this.excepLab.Text = "Invaild Input, Enrer Number";
            this.excepLab.Click += new System.EventHandler(this.excepLab_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(414, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 34);
            this.label2.TabIndex = 6;
            this.label2.Text = "Welcome Patient";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(316, 434);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // idTxtLog
            // 
            this.idTxtLog.BorderRadius = 10;
            this.idTxtLog.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.idTxtLog.DefaultText = "";
            this.idTxtLog.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.idTxtLog.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.idTxtLog.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.idTxtLog.DisabledState.Parent = this.idTxtLog;
            this.idTxtLog.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.idTxtLog.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.idTxtLog.FocusedState.Parent = this.idTxtLog;
            this.idTxtLog.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTxtLog.ForeColor = System.Drawing.Color.Black;
            this.idTxtLog.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.idTxtLog.HoverState.Parent = this.idTxtLog;
            this.idTxtLog.Location = new System.Drawing.Point(369, 214);
            this.idTxtLog.Margin = new System.Windows.Forms.Padding(4);
            this.idTxtLog.Name = "idTxtLog";
            this.idTxtLog.PasswordChar = '*';
            this.idTxtLog.PlaceholderText = "";
            this.idTxtLog.SelectedText = "";
            this.idTxtLog.ShadowDecoration.Parent = this.idTxtLog;
            this.idTxtLog.Size = new System.Drawing.Size(283, 44);
            this.idTxtLog.TabIndex = 1;
            this.idTxtLog.TextChanged += new System.EventHandler(this.idTxtLog_TextChanged_1);
            // 
            // logBut
            // 
            this.logBut.Animated = true;
            this.logBut.AutoRoundedCorners = true;
            this.logBut.BackColor = System.Drawing.Color.Transparent;
            this.logBut.BorderColor = System.Drawing.Color.White;
            this.logBut.BorderRadius = 21;
            this.logBut.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.logBut.CheckedState.Parent = this.logBut;
            this.logBut.CustomBorderColor = System.Drawing.Color.White;
            this.logBut.CustomImages.Parent = this.logBut;
            this.logBut.FillColor = System.Drawing.Color.LightCyan;
            this.logBut.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logBut.ForeColor = System.Drawing.Color.Maroon;
            this.logBut.HoverState.BorderColor = System.Drawing.Color.White;
            this.logBut.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.logBut.HoverState.FillColor = System.Drawing.Color.LightCyan;
            this.logBut.HoverState.ForeColor = System.Drawing.Color.Red;
            this.logBut.HoverState.Parent = this.logBut;
            this.logBut.Location = new System.Drawing.Point(369, 323);
            this.logBut.Name = "logBut";
            this.logBut.ShadowDecoration.Parent = this.logBut;
            this.logBut.Size = new System.Drawing.Size(324, 45);
            this.logBut.TabIndex = 2;
            this.logBut.Text = "Login";
            this.logBut.Click += new System.EventHandler(this.logBut_Click);
            // 
            // regBut
            // 
            this.regBut.Animated = true;
            this.regBut.AutoRoundedCorners = true;
            this.regBut.BackColor = System.Drawing.Color.Transparent;
            this.regBut.BorderColor = System.Drawing.Color.White;
            this.regBut.BorderRadius = 20;
            this.regBut.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.regBut.CheckedState.Parent = this.regBut;
            this.regBut.CustomBorderColor = System.Drawing.Color.Transparent;
            this.regBut.CustomImages.Parent = this.regBut;
            this.regBut.FillColor = System.Drawing.Color.LightCyan;
            this.regBut.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regBut.ForeColor = System.Drawing.Color.Maroon;
            this.regBut.HoverState.BorderColor = System.Drawing.Color.White;
            this.regBut.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.regBut.HoverState.FillColor = System.Drawing.Color.LightCyan;
            this.regBut.HoverState.ForeColor = System.Drawing.Color.Red;
            this.regBut.HoverState.Parent = this.regBut;
            this.regBut.Location = new System.Drawing.Point(584, 15);
            this.regBut.Name = "regBut";
            this.regBut.ShadowDecoration.Parent = this.regBut;
            this.regBut.Size = new System.Drawing.Size(190, 42);
            this.regBut.TabIndex = 3;
            this.regBut.Text = "Regestration";
            this.regBut.Click += new System.EventHandler(this.regBut_Click);
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.TargetControl = this.pictureBox1;
            // 
            // back
            // 
            this.back.Animated = true;
            this.back.AutoRoundedCorners = true;
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.BorderColor = System.Drawing.Color.Transparent;
            this.back.BorderRadius = 24;
            this.back.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.back.CheckedState.Parent = this.back;
            this.back.CustomBorderColor = System.Drawing.Color.Transparent;
            this.back.CustomImages.Parent = this.back;
            this.back.FillColor = System.Drawing.Color.Transparent;
            this.back.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.Maroon;
            this.back.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.back.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.back.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.back.HoverState.ForeColor = System.Drawing.Color.Red;
            this.back.HoverState.Parent = this.back;
            this.back.Location = new System.Drawing.Point(3, 6);
            this.back.Name = "back";
            this.back.ShadowDecoration.Parent = this.back;
            this.back.Size = new System.Drawing.Size(67, 51);
            this.back.TabIndex = 17;
            this.back.Text = "Back";
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // loginPatControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.back);
            this.Controls.Add(this.regBut);
            this.Controls.Add(this.logBut);
            this.Controls.Add(this.idTxtLog);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.excepLab);
            this.Controls.Add(this.label1);
            this.Name = "loginPatControl";
            this.Size = new System.Drawing.Size(792, 441);
            this.Load += new System.EventHandler(this.loginPatControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label excepLab;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox idTxtLog;
        private Guna.UI2.WinForms.Guna2Button logBut;
        private Guna.UI2.WinForms.Guna2Button regBut;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private Guna.UI2.WinForms.Guna2Button back;
    }
}
