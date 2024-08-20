namespace UniversityNoteSystem.Forms
{
    partial class FormStudentArrangement
    {
        private System.ComponentModel.IContainer components = null;

        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region _TOOLS...
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStudentArrangement));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.btnList = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.comBoxStudentDepartment = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblStudentPicture = new System.Windows.Forms.Label();
            this.txtStudentPicture = new System.Windows.Forms.TextBox();
            this.lblStudentMail = new System.Windows.Forms.Label();
            this.txtStudentMail = new System.Windows.Forms.TextBox();
            this.lblStudentPassword = new System.Windows.Forms.Label();
            this.txtStudentPassword = new System.Windows.Forms.TextBox();
            this.lblStudentNumber = new System.Windows.Forms.Label();
            this.txtStudentNumber = new System.Windows.Forms.TextBox();
            this.lblStudentSurname = new System.Windows.Forms.Label();
            this.txtStudentSurname = new System.Windows.Forms.TextBox();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblStudentID);
            this.groupBox1.Controls.Add(this.txtStudentID);
            this.groupBox1.Controls.Add(this.btnList);
            this.groupBox1.Controls.Add(this.btnBrowse);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.lblHeader);
            this.groupBox1.Controls.Add(this.comBoxStudentDepartment);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblStudentPicture);
            this.groupBox1.Controls.Add(this.txtStudentPicture);
            this.groupBox1.Controls.Add(this.lblStudentMail);
            this.groupBox1.Controls.Add(this.txtStudentMail);
            this.groupBox1.Controls.Add(this.lblStudentPassword);
            this.groupBox1.Controls.Add(this.txtStudentPassword);
            this.groupBox1.Controls.Add(this.lblStudentNumber);
            this.groupBox1.Controls.Add(this.txtStudentNumber);
            this.groupBox1.Controls.Add(this.lblStudentSurname);
            this.groupBox1.Controls.Add(this.txtStudentSurname);
            this.groupBox1.Controls.Add(this.lblStudentName);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.txtStudentName);
            this.groupBox1.Location = new System.Drawing.Point(861, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 553);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStudentID.ForeColor = System.Drawing.Color.White;
            this.lblStudentID.Location = new System.Drawing.Point(85, 83);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(91, 18);
            this.lblStudentID.TabIndex = 21;
            this.lblStudentID.Text = "Student ID:";
            // 
            // txtStudentID
            // 
            this.txtStudentID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.txtStudentID.ForeColor = System.Drawing.Color.White;
            this.txtStudentID.Location = new System.Drawing.Point(175, 80);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(178, 20);
            this.txtStudentID.TabIndex = 22;
            // 
            // btnList
            // 
            this.btnList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnList.ForeColor = System.Drawing.Color.White;
            this.btnList.Location = new System.Drawing.Point(127, 453);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(170, 45);
            this.btnList.TabIndex = 20;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.Location = new System.Drawing.Point(359, 252);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(34, 20);
            this.btnBrowse.TabIndex = 19;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(127, 393);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(170, 45);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(4, 30);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(404, 24);
            this.lblHeader.TabIndex = 17;
            this.lblHeader.Text = "Student Arrangement";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comBoxStudentDepartment
            // 
            this.comBoxStudentDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.comBoxStudentDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxStudentDepartment.ForeColor = System.Drawing.Color.White;
            this.comBoxStudentDepartment.FormattingEnabled = true;
            this.comBoxStudentDepartment.Location = new System.Drawing.Point(175, 286);
            this.comBoxStudentDepartment.Name = "comBoxStudentDepartment";
            this.comBoxStudentDepartment.Size = new System.Drawing.Size(178, 21);
            this.comBoxStudentDepartment.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(14, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "Student Department:";
            // 
            // lblStudentPicture
            // 
            this.lblStudentPicture.AutoSize = true;
            this.lblStudentPicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStudentPicture.ForeColor = System.Drawing.Color.White;
            this.lblStudentPicture.Location = new System.Drawing.Point(48, 256);
            this.lblStudentPicture.Name = "lblStudentPicture";
            this.lblStudentPicture.Size = new System.Drawing.Size(128, 18);
            this.lblStudentPicture.TabIndex = 13;
            this.lblStudentPicture.Text = "Student Picture:";
            // 
            // txtStudentPicture
            // 
            this.txtStudentPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.txtStudentPicture.ForeColor = System.Drawing.Color.White;
            this.txtStudentPicture.Location = new System.Drawing.Point(175, 253);
            this.txtStudentPicture.Name = "txtStudentPicture";
            this.txtStudentPicture.Size = new System.Drawing.Size(178, 20);
            this.txtStudentPicture.TabIndex = 7;
            // 
            // lblStudentMail
            // 
            this.lblStudentMail.AutoSize = true;
            this.lblStudentMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStudentMail.ForeColor = System.Drawing.Color.White;
            this.lblStudentMail.Location = new System.Drawing.Point(70, 226);
            this.lblStudentMail.Name = "lblStudentMail";
            this.lblStudentMail.Size = new System.Drawing.Size(106, 18);
            this.lblStudentMail.TabIndex = 11;
            this.lblStudentMail.Text = "Student Mail:";
            // 
            // txtStudentMail
            // 
            this.txtStudentMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.txtStudentMail.ForeColor = System.Drawing.Color.White;
            this.txtStudentMail.Location = new System.Drawing.Point(175, 223);
            this.txtStudentMail.Name = "txtStudentMail";
            this.txtStudentMail.Size = new System.Drawing.Size(178, 20);
            this.txtStudentMail.TabIndex = 6;
            // 
            // lblStudentPassword
            // 
            this.lblStudentPassword.AutoSize = true;
            this.lblStudentPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStudentPassword.ForeColor = System.Drawing.Color.White;
            this.lblStudentPassword.Location = new System.Drawing.Point(26, 199);
            this.lblStudentPassword.Name = "lblStudentPassword";
            this.lblStudentPassword.Size = new System.Drawing.Size(150, 18);
            this.lblStudentPassword.TabIndex = 7;
            this.lblStudentPassword.Text = "Student Password:";
            // 
            // txtStudentPassword
            // 
            this.txtStudentPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.txtStudentPassword.ForeColor = System.Drawing.Color.White;
            this.txtStudentPassword.Location = new System.Drawing.Point(175, 196);
            this.txtStudentPassword.Name = "txtStudentPassword";
            this.txtStudentPassword.Size = new System.Drawing.Size(178, 20);
            this.txtStudentPassword.TabIndex = 4;
            // 
            // lblStudentNumber
            // 
            this.lblStudentNumber.AutoSize = true;
            this.lblStudentNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStudentNumber.ForeColor = System.Drawing.Color.White;
            this.lblStudentNumber.Location = new System.Drawing.Point(42, 169);
            this.lblStudentNumber.Name = "lblStudentNumber";
            this.lblStudentNumber.Size = new System.Drawing.Size(134, 18);
            this.lblStudentNumber.TabIndex = 5;
            this.lblStudentNumber.Text = "Student Number:";
            // 
            // txtStudentNumber
            // 
            this.txtStudentNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.txtStudentNumber.ForeColor = System.Drawing.Color.White;
            this.txtStudentNumber.Location = new System.Drawing.Point(175, 166);
            this.txtStudentNumber.Name = "txtStudentNumber";
            this.txtStudentNumber.Size = new System.Drawing.Size(178, 20);
            this.txtStudentNumber.TabIndex = 3;
            // 
            // lblStudentSurname
            // 
            this.lblStudentSurname.AutoSize = true;
            this.lblStudentSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStudentSurname.ForeColor = System.Drawing.Color.White;
            this.lblStudentSurname.Location = new System.Drawing.Point(34, 139);
            this.lblStudentSurname.Name = "lblStudentSurname";
            this.lblStudentSurname.Size = new System.Drawing.Size(142, 18);
            this.lblStudentSurname.TabIndex = 3;
            this.lblStudentSurname.Text = "Student Surname:";
            // 
            // txtStudentSurname
            // 
            this.txtStudentSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.txtStudentSurname.ForeColor = System.Drawing.Color.White;
            this.txtStudentSurname.Location = new System.Drawing.Point(175, 136);
            this.txtStudentSurname.Name = "txtStudentSurname";
            this.txtStudentSurname.Size = new System.Drawing.Size(178, 20);
            this.txtStudentSurname.TabIndex = 2;
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStudentName.ForeColor = System.Drawing.Color.White;
            this.lblStudentName.Location = new System.Drawing.Point(57, 109);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(119, 18);
            this.lblStudentName.TabIndex = 0;
            this.lblStudentName.Text = "Student Name:";
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(130, 336);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(170, 45);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtStudentName
            // 
            this.txtStudentName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.txtStudentName.ForeColor = System.Drawing.Color.White;
            this.txtStudentName.Location = new System.Drawing.Point(175, 106);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(178, 20);
            this.txtStudentName.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView);
            this.groupBox2.Location = new System.Drawing.Point(12, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(843, 553);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(3, 16);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(837, 534);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "Student Picture";
            // 
            // FormStudentArrangement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1280, 571);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormStudentArrangement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Arrangement";
            this.Load += new System.EventHandler(this.FormStudentArrangement_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.ComboBox comBoxStudentDepartment;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblStudentPicture;
        private System.Windows.Forms.TextBox txtStudentPicture;
        private System.Windows.Forms.Label lblStudentMail;
        private System.Windows.Forms.TextBox txtStudentMail;
        private System.Windows.Forms.Label lblStudentPassword;
        private System.Windows.Forms.TextBox txtStudentPassword;
        private System.Windows.Forms.Label lblStudentNumber;
        private System.Windows.Forms.TextBox txtStudentNumber;
        private System.Windows.Forms.Label lblStudentSurname;
        private System.Windows.Forms.TextBox txtStudentSurname;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.TextBox txtStudentID;
    }
}