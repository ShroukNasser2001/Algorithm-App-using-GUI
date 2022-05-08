
namespace FinalAlgorithmApp.userControl
{
    partial class ShowDeptManegControl
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
            this.deptShow = new System.Windows.Forms.DataGridView();
            this.depIDShow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepNameShow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numDocShow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waitListShow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.showDetial = new System.Windows.Forms.Panel();
            this.deleteDep = new Guna.UI2.WinForms.Guna2Button();
            this.addWaitedDep = new Guna.UI2.WinForms.Guna2Button();
            this.depWaitApps = new System.Windows.Forms.DataGridView();
            this.appDepWaitID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patDepWaitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numWaitDepApp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docsSelDep = new System.Windows.Forms.DataGridView();
            this.docDepID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docDepName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docDepNumApps = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.deptShow)).BeginInit();
            this.showDetial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depWaitApps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docsSelDep)).BeginInit();
            this.SuspendLayout();
            // 
            // deptShow
            // 
            this.deptShow.AllowUserToAddRows = false;
            this.deptShow.AllowUserToDeleteRows = false;
            this.deptShow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.deptShow.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.deptShow.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.deptShow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.deptShow.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.deptShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deptShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.depIDShow,
            this.DepNameShow,
            this.numDocShow,
            this.waitListShow});
            this.deptShow.Dock = System.Windows.Forms.DockStyle.Top;
            this.deptShow.GridColor = System.Drawing.Color.SkyBlue;
            this.deptShow.Location = new System.Drawing.Point(0, 0);
            this.deptShow.Name = "deptShow";
            this.deptShow.ReadOnly = true;
            this.deptShow.RowHeadersWidth = 51;
            this.deptShow.RowTemplate.Height = 24;
            this.deptShow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.deptShow.Size = new System.Drawing.Size(1368, 263);
            this.deptShow.StandardTab = true;
            this.deptShow.TabIndex = 0;
            this.deptShow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.deptShow_CellContentClick);
            // 
            // depIDShow
            // 
            this.depIDShow.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.depIDShow.HeaderText = "Department ID";
            this.depIDShow.MinimumWidth = 6;
            this.depIDShow.Name = "depIDShow";
            this.depIDShow.ReadOnly = true;
            // 
            // DepNameShow
            // 
            this.DepNameShow.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DepNameShow.HeaderText = "Department Name";
            this.DepNameShow.MinimumWidth = 6;
            this.DepNameShow.Name = "DepNameShow";
            this.DepNameShow.ReadOnly = true;
            // 
            // numDocShow
            // 
            this.numDocShow.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.numDocShow.HeaderText = "Number of Doctors";
            this.numDocShow.MinimumWidth = 6;
            this.numDocShow.Name = "numDocShow";
            this.numDocShow.ReadOnly = true;
            // 
            // waitListShow
            // 
            this.waitListShow.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.waitListShow.HeaderText = "Number of Waiting Appoitments ";
            this.waitListShow.MinimumWidth = 6;
            this.waitListShow.Name = "waitListShow";
            this.waitListShow.ReadOnly = true;
            // 
            // showDetial
            // 
            this.showDetial.BackColor = System.Drawing.Color.Transparent;
            this.showDetial.Controls.Add(this.deleteDep);
            this.showDetial.Controls.Add(this.addWaitedDep);
            this.showDetial.Controls.Add(this.depWaitApps);
            this.showDetial.Controls.Add(this.docsSelDep);
            this.showDetial.Location = new System.Drawing.Point(0, 263);
            this.showDetial.Name = "showDetial";
            this.showDetial.Size = new System.Drawing.Size(1367, 311);
            this.showDetial.TabIndex = 1;
            this.showDetial.Paint += new System.Windows.Forms.PaintEventHandler(this.showDetial_Paint);
            // 
            // deleteDep
            // 
            this.deleteDep.Animated = true;
            this.deleteDep.AutoRoundedCorners = true;
            this.deleteDep.BorderRadius = 48;
            this.deleteDep.CheckedState.Parent = this.deleteDep;
            this.deleteDep.CustomImages.Parent = this.deleteDep;
            this.deleteDep.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.deleteDep.ForeColor = System.Drawing.Color.White;
            this.deleteDep.HoverState.Parent = this.deleteDep;
            this.deleteDep.Location = new System.Drawing.Point(163, 198);
            this.deleteDep.Name = "deleteDep";
            this.deleteDep.ShadowDecoration.Parent = this.deleteDep;
            this.deleteDep.Size = new System.Drawing.Size(206, 99);
            this.deleteDep.TabIndex = 4;
            this.deleteDep.Text = "Delete Department";
            this.deleteDep.Click += new System.EventHandler(this.deleteDep_Click);
            // 
            // addWaitedDep
            // 
            this.addWaitedDep.Animated = true;
            this.addWaitedDep.AutoRoundedCorners = true;
            this.addWaitedDep.BackColor = System.Drawing.Color.Transparent;
            this.addWaitedDep.BorderRadius = 48;
            this.addWaitedDep.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.addWaitedDep.CheckedState.Parent = this.addWaitedDep;
            this.addWaitedDep.CustomImages.Parent = this.addWaitedDep;
            this.addWaitedDep.FillColor = System.Drawing.Color.Turquoise;
            this.addWaitedDep.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addWaitedDep.ForeColor = System.Drawing.Color.Black;
            this.addWaitedDep.HoverState.ForeColor = System.Drawing.Color.Black;
            this.addWaitedDep.HoverState.Parent = this.addWaitedDep;
            this.addWaitedDep.Location = new System.Drawing.Point(941, 198);
            this.addWaitedDep.Name = "addWaitedDep";
            this.addWaitedDep.ShadowDecoration.Parent = this.addWaitedDep;
            this.addWaitedDep.Size = new System.Drawing.Size(325, 99);
            this.addWaitedDep.TabIndex = 3;
            this.addWaitedDep.Text = "Add Waiting Appoitements ";
            this.addWaitedDep.Click += new System.EventHandler(this.addWaitedDep_Click);
            // 
            // depWaitApps
            // 
            this.depWaitApps.AllowUserToAddRows = false;
            this.depWaitApps.AllowUserToDeleteRows = false;
            this.depWaitApps.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.depWaitApps.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.depWaitApps.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.depWaitApps.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.depWaitApps.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.depWaitApps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.depWaitApps.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.appDepWaitID,
            this.patDepWaitName,
            this.numWaitDepApp});
            this.depWaitApps.GridColor = System.Drawing.Color.Snow;
            this.depWaitApps.Location = new System.Drawing.Point(758, 0);
            this.depWaitApps.Name = "depWaitApps";
            this.depWaitApps.ReadOnly = true;
            this.depWaitApps.RowHeadersWidth = 51;
            this.depWaitApps.RowTemplate.Height = 24;
            this.depWaitApps.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.depWaitApps.Size = new System.Drawing.Size(615, 175);
            this.depWaitApps.StandardTab = true;
            this.depWaitApps.TabIndex = 2;
            this.depWaitApps.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.depWaitApps_CellContentClick);
            // 
            // appDepWaitID
            // 
            this.appDepWaitID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.appDepWaitID.HeaderText = "Appoitment ID";
            this.appDepWaitID.MinimumWidth = 6;
            this.appDepWaitID.Name = "appDepWaitID";
            this.appDepWaitID.ReadOnly = true;
            // 
            // patDepWaitName
            // 
            this.patDepWaitName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.patDepWaitName.HeaderText = "Patient Name";
            this.patDepWaitName.MinimumWidth = 6;
            this.patDepWaitName.Name = "patDepWaitName";
            this.patDepWaitName.ReadOnly = true;
            // 
            // numWaitDepApp
            // 
            this.numWaitDepApp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.numWaitDepApp.HeaderText = "Number of Waiting";
            this.numWaitDepApp.MinimumWidth = 6;
            this.numWaitDepApp.Name = "numWaitDepApp";
            this.numWaitDepApp.ReadOnly = true;
            // 
            // docsSelDep
            // 
            this.docsSelDep.AllowUserToAddRows = false;
            this.docsSelDep.AllowUserToDeleteRows = false;
            this.docsSelDep.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.docsSelDep.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.docsSelDep.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.docsSelDep.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.docsSelDep.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.docsSelDep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.docsSelDep.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.docDepID,
            this.docDepName,
            this.docDepNumApps});
            this.docsSelDep.GridColor = System.Drawing.Color.SkyBlue;
            this.docsSelDep.Location = new System.Drawing.Point(0, 0);
            this.docsSelDep.Name = "docsSelDep";
            this.docsSelDep.ReadOnly = true;
            this.docsSelDep.RowHeadersWidth = 51;
            this.docsSelDep.RowTemplate.Height = 24;
            this.docsSelDep.Size = new System.Drawing.Size(610, 175);
            this.docsSelDep.StandardTab = true;
            this.docsSelDep.TabIndex = 1;
            this.docsSelDep.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.docsSelDep_CellContentClick);
            // 
            // docDepID
            // 
            this.docDepID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.docDepID.HeaderText = "Doctor ID";
            this.docDepID.MinimumWidth = 6;
            this.docDepID.Name = "docDepID";
            this.docDepID.ReadOnly = true;
            // 
            // docDepName
            // 
            this.docDepName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.docDepName.HeaderText = "Doctor Name";
            this.docDepName.MinimumWidth = 6;
            this.docDepName.Name = "docDepName";
            this.docDepName.ReadOnly = true;
            // 
            // docDepNumApps
            // 
            this.docDepNumApps.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.docDepNumApps.HeaderText = "Number of Appoitments";
            this.docDepNumApps.MinimumWidth = 6;
            this.docDepNumApps.Name = "docDepNumApps";
            this.docDepNumApps.ReadOnly = true;
            // 
            // ShowDeptManegControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.showDetial);
            this.Controls.Add(this.deptShow);
            this.Name = "ShowDeptManegControl";
            this.Size = new System.Drawing.Size(1368, 574);
            ((System.ComponentModel.ISupportInitialize)(this.deptShow)).EndInit();
            this.showDetial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.depWaitApps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docsSelDep)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView deptShow;
        private System.Windows.Forms.DataGridViewTextBoxColumn depIDShow;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepNameShow;
        private System.Windows.Forms.DataGridViewTextBoxColumn numDocShow;
        private System.Windows.Forms.DataGridViewTextBoxColumn waitListShow;
        private System.Windows.Forms.Panel showDetial;
        private System.Windows.Forms.DataGridView docsSelDep;
        private System.Windows.Forms.DataGridView depWaitApps;
        private System.Windows.Forms.DataGridViewTextBoxColumn appDepWaitID;
        private System.Windows.Forms.DataGridViewTextBoxColumn patDepWaitName;
        private System.Windows.Forms.DataGridViewTextBoxColumn numWaitDepApp;
        private System.Windows.Forms.DataGridViewTextBoxColumn docDepID;
        private System.Windows.Forms.DataGridViewTextBoxColumn docDepName;
        private System.Windows.Forms.DataGridViewTextBoxColumn docDepNumApps;
        private Guna.UI2.WinForms.Guna2Button deleteDep;
        private Guna.UI2.WinForms.Guna2Button addWaitedDep;
    }
}
