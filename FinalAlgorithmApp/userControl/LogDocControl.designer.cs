
namespace FinalAlgorithmApp.userControl
{
    partial class LogDocControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogDocControl));
            this.excepLab = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.logBut = new Guna.UI2.WinForms.Guna2Button();
            this.idTxtLog = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.back = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // excepLab
            // 
            this.excepLab.AutoSize = true;
            this.excepLab.BackColor = System.Drawing.Color.White;
            this.excepLab.Font = new System.Drawing.Font("Agency FB", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excepLab.Location = new System.Drawing.Point(555, 244);
            this.excepLab.Name = "excepLab";
            this.excepLab.Size = new System.Drawing.Size(167, 24);
            this.excepLab.TabIndex = 14;
            this.excepLab.Text = "Invaild Input, Enrer Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(501, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Your System ID ";
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
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
            this.logBut.FillColor = System.Drawing.Color.LightGray;
            this.logBut.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logBut.ForeColor = System.Drawing.Color.Maroon;
            this.logBut.HoverState.BorderColor = System.Drawing.Color.White;
            this.logBut.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.logBut.HoverState.FillColor = System.Drawing.Color.LightGray;
            this.logBut.HoverState.ForeColor = System.Drawing.Color.Red;
            this.logBut.HoverState.Parent = this.logBut;
            this.logBut.Location = new System.Drawing.Point(505, 315);
            this.logBut.Name = "logBut";
            this.logBut.ShadowDecoration.Parent = this.logBut;
            this.logBut.Size = new System.Drawing.Size(274, 45);
            this.logBut.TabIndex = 12;
            this.logBut.Text = "Login";
            this.logBut.Click += new System.EventHandler(this.logBut_Click);
            // 
            // idTxtLog
            // 
            this.idTxtLog.BackColor = System.Drawing.Color.Transparent;
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
            this.idTxtLog.Location = new System.Drawing.Point(505, 196);
            this.idTxtLog.Margin = new System.Windows.Forms.Padding(4);
            this.idTxtLog.Name = "idTxtLog";
            this.idTxtLog.PasswordChar = '*';
            this.idTxtLog.PlaceholderText = "";
            this.idTxtLog.SelectedText = "";
            this.idTxtLog.ShadowDecoration.Parent = this.idTxtLog;
            this.idTxtLog.Size = new System.Drawing.Size(283, 44);
            this.idTxtLog.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Purple;
            this.label4.Location = new System.Drawing.Point(499, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 34);
            this.label4.TabIndex = 15;
            this.label4.Text = "Welcome Doctor";
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
            this.back.Location = new System.Drawing.Point(0, 0);
            this.back.Name = "back";
            this.back.ShadowDecoration.Parent = this.back;
            this.back.Size = new System.Drawing.Size(67, 51);
            this.back.TabIndex = 16;
            this.back.Text = "Back";
            this.back.Click += new System.EventHandler(this.back_click);
            // 
            // LogDocControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.back);
            this.Controls.Add(this.excepLab);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.logBut);
            this.Controls.Add(this.idTxtLog);
            this.Controls.Add(this.label4);
            this.Name = "LogDocControl";
            this.Size = new System.Drawing.Size(769, 438);
            this.Load += new System.EventHandler(this.logDocControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label excepLab;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Button logBut;
        private Guna.UI2.WinForms.Guna2TextBox idTxtLog;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button back;
    }
}
