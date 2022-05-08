
namespace FinalAlgorithmApp.userControl
{
    partial class NewAppoitment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewAppoitment));
            this.availEnrollDepts = new System.Windows.Forms.DataGridView();
            this.depID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numWaitList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waitedApp = new System.Windows.Forms.DataGridView();
            this.appoitIWaitD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptWaitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.indexWaitNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.availEnrollDepts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waitedApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // availEnrollDepts
            // 
            this.availEnrollDepts.AllowDrop = true;
            this.availEnrollDepts.AllowUserToAddRows = false;
            this.availEnrollDepts.AllowUserToDeleteRows = false;
            this.availEnrollDepts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.availEnrollDepts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.availEnrollDepts.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.availEnrollDepts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.availEnrollDepts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.availEnrollDepts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.availEnrollDepts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.depID,
            this.deptName,
            this.numWaitList});
            this.availEnrollDepts.Location = new System.Drawing.Point(34, 504);
            this.availEnrollDepts.Name = "availEnrollDepts";
            this.availEnrollDepts.ReadOnly = true;
            this.availEnrollDepts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.availEnrollDepts.RowTemplate.Height = 24;
            this.availEnrollDepts.Size = new System.Drawing.Size(604, 150);
            this.availEnrollDepts.TabIndex = 39;
            this.availEnrollDepts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.availEnrollDepts_CellContentClick);
            // 
            // depID
            // 
            this.depID.HeaderText = "Department ID";
            this.depID.MinimumWidth = 6;
            this.depID.Name = "depID";
            this.depID.ReadOnly = true;
            // 
            // deptName
            // 
            this.deptName.HeaderText = "Department Name";
            this.deptName.MinimumWidth = 6;
            this.deptName.Name = "deptName";
            this.deptName.ReadOnly = true;
            // 
            // numWaitList
            // 
            this.numWaitList.HeaderText = "Number of waiting list";
            this.numWaitList.MinimumWidth = 6;
            this.numWaitList.Name = "numWaitList";
            this.numWaitList.ReadOnly = true;
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
            this.waitedApp.Location = new System.Drawing.Point(763, 504);
            this.waitedApp.Name = "waitedApp";
            this.waitedApp.ReadOnly = true;
            this.waitedApp.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.waitedApp.RowTemplate.Height = 24;
            this.waitedApp.Size = new System.Drawing.Size(597, 150);
            this.waitedApp.TabIndex = 40;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(55, 460);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(480, 41);
            this.label1.TabIndex = 42;
            this.label1.Text = "Avaialabe Departments For You";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(778, 460);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 41);
            this.label2.TabIndex = 43;
            this.label2.Text = "Waited Appoitments";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(713, 364);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Rockwell Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(699, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(647, 35);
            this.label3.TabIndex = 45;
            this.label3.Text = "You are only allowed to register in one department.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Rockwell Condensed", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(643, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(783, 30);
            this.label4.TabIndex = 46;
            this.label4.Text = "You are assigned to one of doctors with the fewest number of Appoitments.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Rockwell Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label5.Location = new System.Drawing.Point(597, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(817, 35);
            this.label5.TabIndex = 47;
            this.label5.Text = "Otherwise, you will be added to the waiting list (in your opinion).";
            // 
            // NewAppoitment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.waitedApp);
            this.Controls.Add(this.availEnrollDepts);
            this.Name = "NewAppoitment";
            this.Size = new System.Drawing.Size(1429, 921);
            this.Load += new System.EventHandler(this.newAppoitment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.availEnrollDepts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waitedApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView availEnrollDepts;
        private System.Windows.Forms.DataGridView waitedApp;
        private System.Windows.Forms.DataGridViewTextBoxColumn appoitIWaitD;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptWaitName;
        private System.Windows.Forms.DataGridViewTextBoxColumn indexWaitNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn depID;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptName;
        private System.Windows.Forms.DataGridViewTextBoxColumn numWaitList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
