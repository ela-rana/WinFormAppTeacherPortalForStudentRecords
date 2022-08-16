namespace WinFormAppTeacherPortalForStudentRecords
{
    partial class TeacherPortal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherPortal));
            this.dtgrdDisplayStudent = new System.Windows.Forms.DataGridView();
            this.grpDisplayStudent = new System.Windows.Forms.GroupBox();
            this.grpAddStudent = new System.Windows.Forms.GroupBox();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.tblAddStudent = new System.Windows.Forms.TableLayoutPanel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblGPA = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtGPA = new System.Windows.Forms.TextBox();
            this.lblStudentId = new System.Windows.Forms.Label();
            this.grpDeleteStudent = new System.Windows.Forms.GroupBox();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.lblDeleteMessage = new System.Windows.Forms.Label();
            this.grpTopStudent = new System.Windows.Forms.GroupBox();
            this.btnSaveTopStudent = new System.Windows.Forms.Button();
            this.lblSaveTopStudent = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdDisplayStudent)).BeginInit();
            this.grpDisplayStudent.SuspendLayout();
            this.grpAddStudent.SuspendLayout();
            this.tblAddStudent.SuspendLayout();
            this.grpDeleteStudent.SuspendLayout();
            this.grpTopStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgrdDisplayStudent
            // 
            this.dtgrdDisplayStudent.AllowUserToAddRows = false;
            this.dtgrdDisplayStudent.AllowUserToDeleteRows = false;
            this.dtgrdDisplayStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdDisplayStudent.Location = new System.Drawing.Point(0, 29);
            this.dtgrdDisplayStudent.Name = "dtgrdDisplayStudent";
            this.dtgrdDisplayStudent.ReadOnly = true;
            this.dtgrdDisplayStudent.Size = new System.Drawing.Size(803, 301);
            this.dtgrdDisplayStudent.TabIndex = 0;
            // 
            // grpDisplayStudent
            // 
            this.grpDisplayStudent.Controls.Add(this.dtgrdDisplayStudent);
            this.grpDisplayStudent.Location = new System.Drawing.Point(12, 12);
            this.grpDisplayStudent.Name = "grpDisplayStudent";
            this.grpDisplayStudent.Size = new System.Drawing.Size(803, 330);
            this.grpDisplayStudent.TabIndex = 1;
            this.grpDisplayStudent.TabStop = false;
            this.grpDisplayStudent.Text = "Student Display";
            // 
            // grpAddStudent
            // 
            this.grpAddStudent.Controls.Add(this.btnAddStudent);
            this.grpAddStudent.Controls.Add(this.tblAddStudent);
            this.grpAddStudent.Location = new System.Drawing.Point(12, 366);
            this.grpAddStudent.Name = "grpAddStudent";
            this.grpAddStudent.Size = new System.Drawing.Size(319, 215);
            this.grpAddStudent.TabIndex = 2;
            this.grpAddStudent.TabStop = false;
            this.grpAddStudent.Text = "Add New Student";
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(111, 128);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(75, 23);
            this.btnAddStudent.TabIndex = 1;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // tblAddStudent
            // 
            this.tblAddStudent.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tblAddStudent.ColumnCount = 2;
            this.tblAddStudent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.97183F));
            this.tblAddStudent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.02817F));
            this.tblAddStudent.Controls.Add(this.lblName, 0, 1);
            this.tblAddStudent.Controls.Add(this.lblGPA, 0, 2);
            this.tblAddStudent.Controls.Add(this.txtStudentID, 1, 0);
            this.tblAddStudent.Controls.Add(this.txtName, 1, 1);
            this.tblAddStudent.Controls.Add(this.txtGPA, 1, 2);
            this.tblAddStudent.Controls.Add(this.lblStudentId, 0, 0);
            this.tblAddStudent.Location = new System.Drawing.Point(9, 23);
            this.tblAddStudent.Name = "tblAddStudent";
            this.tblAddStudent.RowCount = 3;
            this.tblAddStudent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblAddStudent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblAddStudent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblAddStudent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblAddStudent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblAddStudent.Size = new System.Drawing.Size(284, 97);
            this.tblAddStudent.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(34, 41);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblGPA
            // 
            this.lblGPA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGPA.AutoSize = true;
            this.lblGPA.Location = new System.Drawing.Point(37, 74);
            this.lblGPA.Name = "lblGPA";
            this.lblGPA.Size = new System.Drawing.Size(29, 13);
            this.lblGPA.TabIndex = 2;
            this.lblGPA.Text = "GPA";
            // 
            // txtStudentID
            // 
            this.txtStudentID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtStudentID.Location = new System.Drawing.Point(107, 6);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(174, 20);
            this.txtStudentID.TabIndex = 3;
            this.txtStudentID.Validating += new System.ComponentModel.CancelEventHandler(this.txtStudentID_Validating);
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.Location = new System.Drawing.Point(107, 38);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(174, 20);
            this.txtName.TabIndex = 4;
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.txtName_Validating);
            // 
            // txtGPA
            // 
            this.txtGPA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGPA.Location = new System.Drawing.Point(107, 70);
            this.txtGPA.Name = "txtGPA";
            this.txtGPA.Size = new System.Drawing.Size(174, 20);
            this.txtGPA.TabIndex = 5;
            this.txtGPA.Validating += new System.ComponentModel.CancelEventHandler(this.txtGPA_Validating);
            // 
            // lblStudentId
            // 
            this.lblStudentId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.Location = new System.Drawing.Point(23, 9);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(58, 13);
            this.lblStudentId.TabIndex = 0;
            this.lblStudentId.Text = "Student ID";
            // 
            // grpDeleteStudent
            // 
            this.grpDeleteStudent.Controls.Add(this.btnDeleteStudent);
            this.grpDeleteStudent.Controls.Add(this.lblDeleteMessage);
            this.grpDeleteStudent.Location = new System.Drawing.Point(337, 366);
            this.grpDeleteStudent.Name = "grpDeleteStudent";
            this.grpDeleteStudent.Size = new System.Drawing.Size(231, 215);
            this.grpDeleteStudent.TabIndex = 3;
            this.grpDeleteStudent.TabStop = false;
            this.grpDeleteStudent.Text = "Delete Student";
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Location = new System.Drawing.Point(55, 90);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(102, 23);
            this.btnDeleteStudent.TabIndex = 2;
            this.btnDeleteStudent.Text = "Delete Student";
            this.btnDeleteStudent.UseVisualStyleBackColor = true;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // lblDeleteMessage
            // 
            this.lblDeleteMessage.AutoSize = true;
            this.lblDeleteMessage.Location = new System.Drawing.Point(18, 28);
            this.lblDeleteMessage.Name = "lblDeleteMessage";
            this.lblDeleteMessage.Size = new System.Drawing.Size(188, 39);
            this.lblDeleteMessage.TabIndex = 0;
            this.lblDeleteMessage.Text = "Select Student that you want to delete\r\nfrom the grid above, then click Delete\r\nS" +
    "tudent below";
            // 
            // grpTopStudent
            // 
            this.grpTopStudent.Controls.Add(this.btnSaveTopStudent);
            this.grpTopStudent.Controls.Add(this.lblSaveTopStudent);
            this.grpTopStudent.Location = new System.Drawing.Point(574, 366);
            this.grpTopStudent.Name = "grpTopStudent";
            this.grpTopStudent.Size = new System.Drawing.Size(241, 215);
            this.grpTopStudent.TabIndex = 4;
            this.grpTopStudent.TabStop = false;
            this.grpTopStudent.Text = "Top Student";
            // 
            // btnSaveTopStudent
            // 
            this.btnSaveTopStudent.Location = new System.Drawing.Point(58, 90);
            this.btnSaveTopStudent.Name = "btnSaveTopStudent";
            this.btnSaveTopStudent.Size = new System.Drawing.Size(121, 23);
            this.btnSaveTopStudent.TabIndex = 3;
            this.btnSaveTopStudent.Text = "Save Top Student";
            this.btnSaveTopStudent.UseVisualStyleBackColor = true;
            this.btnSaveTopStudent.Click += new System.EventHandler(this.btnSaveTopStudent_Click);
            // 
            // lblSaveTopStudent
            // 
            this.lblSaveTopStudent.AutoSize = true;
            this.lblSaveTopStudent.Location = new System.Drawing.Point(22, 27);
            this.lblSaveTopStudent.Name = "lblSaveTopStudent";
            this.lblSaveTopStudent.Size = new System.Drawing.Size(213, 26);
            this.lblSaveTopStudent.TabIndex = 0;
            this.lblSaveTopStudent.Text = "Press button below to save the Top student\r\nto a file";
            // 
            // TeacherPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(850, 593);
            this.Controls.Add(this.grpTopStudent);
            this.Controls.Add(this.grpDeleteStudent);
            this.Controls.Add(this.grpAddStudent);
            this.Controls.Add(this.grpDisplayStudent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TeacherPortal";
            this.Text = "TeacherPortal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TeacherPortal_FormClosing);
            this.Load += new System.EventHandler(this.TeacherPortal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdDisplayStudent)).EndInit();
            this.grpDisplayStudent.ResumeLayout(false);
            this.grpAddStudent.ResumeLayout(false);
            this.tblAddStudent.ResumeLayout(false);
            this.tblAddStudent.PerformLayout();
            this.grpDeleteStudent.ResumeLayout(false);
            this.grpDeleteStudent.PerformLayout();
            this.grpTopStudent.ResumeLayout(false);
            this.grpTopStudent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgrdDisplayStudent;
        private System.Windows.Forms.GroupBox grpDisplayStudent;
        private System.Windows.Forms.GroupBox grpAddStudent;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.TableLayoutPanel tblAddStudent;
        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblGPA;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtGPA;
        private System.Windows.Forms.GroupBox grpDeleteStudent;
        private System.Windows.Forms.GroupBox grpTopStudent;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.Label lblDeleteMessage;
        private System.Windows.Forms.Button btnSaveTopStudent;
        private System.Windows.Forms.Label lblSaveTopStudent;
    }
}