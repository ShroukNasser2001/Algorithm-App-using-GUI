
namespace FinalAlgorithmApp.userControl
{
    partial class AddMedicine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMedicine));
            this.add = new Guna.UI2.WinForms.Guna2Button();
            this.nameTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.quantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.Animated = true;
            this.add.AutoRoundedCorners = true;
            this.add.BorderRadius = 21;
            this.add.CheckedState.Parent = this.add;
            this.add.CustomImages.Parent = this.add;
            this.add.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.add.Font = new System.Drawing.Font("Sitka Display", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.ForeColor = System.Drawing.Color.White;
            this.add.HoverState.ForeColor = System.Drawing.Color.MistyRose;
            this.add.HoverState.Parent = this.add;
            this.add.Location = new System.Drawing.Point(72, 204);
            this.add.Name = "add";
            this.add.ShadowDecoration.Parent = this.add;
            this.add.Size = new System.Drawing.Size(203, 44);
            this.add.TabIndex = 73;
            this.add.Text = "Add Medicine";
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // nameTxt
            // 
            this.nameTxt.BackColor = System.Drawing.Color.Transparent;
            this.nameTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nameTxt.BorderRadius = 10;
            this.nameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTxt.DefaultText = "Medicine Name";
            this.nameTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nameTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nameTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameTxt.DisabledState.Parent = this.nameTxt;
            this.nameTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameTxt.FocusedState.Parent = this.nameTxt;
            this.nameTxt.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold);
            this.nameTxt.ForeColor = System.Drawing.Color.Black;
            this.nameTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameTxt.HoverState.Parent = this.nameTxt;
            this.nameTxt.Location = new System.Drawing.Point(38, 43);
            this.nameTxt.Margin = new System.Windows.Forms.Padding(5);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.PasswordChar = '\0';
            this.nameTxt.PlaceholderText = "";
            this.nameTxt.SelectedText = "";
            this.nameTxt.SelectionStart = 13;
            this.nameTxt.ShadowDecoration.Parent = this.nameTxt;
            this.nameTxt.Size = new System.Drawing.Size(283, 44);
            this.nameTxt.TabIndex = 91;
            this.nameTxt.TextChanged += new System.EventHandler(this.nameTxt_TextChanged);
            // 
            // quantity
            // 
            this.quantity.BackColor = System.Drawing.Color.Transparent;
            this.quantity.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.quantity.BorderRadius = 10;
            this.quantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.quantity.DefaultText = "Quantity";
            this.quantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.quantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.quantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.quantity.DisabledState.Parent = this.quantity;
            this.quantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.quantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.quantity.FocusedState.Parent = this.quantity;
            this.quantity.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold);
            this.quantity.ForeColor = System.Drawing.Color.Black;
            this.quantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.quantity.HoverState.Parent = this.quantity;
            this.quantity.Location = new System.Drawing.Point(38, 123);
            this.quantity.Margin = new System.Windows.Forms.Padding(5);
            this.quantity.Name = "quantity";
            this.quantity.PasswordChar = '\0';
            this.quantity.PlaceholderText = "";
            this.quantity.SelectedText = "";
            this.quantity.SelectionStart = 8;
            this.quantity.ShadowDecoration.Parent = this.quantity;
            this.quantity.Size = new System.Drawing.Size(283, 44);
            this.quantity.TabIndex = 92;
            // 
            // AddMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 290);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddMedicine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Add Medicine";
            this.Load += new System.EventHandler(this.AddMedicine_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button add;
        private Guna.UI2.WinForms.Guna2TextBox nameTxt;
        private Guna.UI2.WinForms.Guna2TextBox quantity;
    }
}