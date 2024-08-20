namespace UniversityNoteSystem.Forms
{
    partial class FormStudentRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStudentRegistration));
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.txtStudentSurname = new System.Windows.Forms.TextBox();
            this.lblStudentSurname = new System.Windows.Forms.Label();
            this.lblStudentNumber = new System.Windows.Forms.Label();
            this.txtStudentPassword = new System.Windows.Forms.TextBox();
            this.lblStudentPassword = new System.Windows.Forms.Label();
            this.txtStudentPasswordAgain = new System.Windows.Forms.TextBox();
            this.lblPasswordAgain = new System.Windows.Forms.Label();
            this.txtStudentMail = new System.Windows.Forms.TextBox();
            this.lblStudentMail = new System.Windows.Forms.Label();
            this.txtStudentPicture = new System.Windows.Forms.TextBox();
            this.lblStudentPicture = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comBoxStudentDepartment = new System.Windows.Forms.ComboBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtStudentNumber = new System.Windows.Forms.MaskedTextBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "Student Picture";
            // 
            // txtStudentName
            // 
            this.txtStudentName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.txtStudentName.ForeColor = System.Drawing.Color.White;
            this.txtStudentName.Location = new System.Drawing.Point(175, 84);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(178, 24);
            this.txtStudentName.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(123, 367);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(170, 45);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStudentName.ForeColor = System.Drawing.Color.White;
            this.lblStudentName.Location = new System.Drawing.Point(57, 87);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(119, 18);
            this.lblStudentName.TabIndex = 0;
            this.lblStudentName.Text = "Student Name:";
            // 
            // txtStudentSurname
            // 
            this.txtStudentSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.txtStudentSurname.ForeColor = System.Drawing.Color.White;
            this.txtStudentSurname.Location = new System.Drawing.Point(175, 114);
            this.txtStudentSurname.Name = "txtStudentSurname";
            this.txtStudentSurname.Size = new System.Drawing.Size(178, 24);
            this.txtStudentSurname.TabIndex = 2;
            // 
            // lblStudentSurname
            // 
            this.lblStudentSurname.AutoSize = true;
            this.lblStudentSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStudentSurname.ForeColor = System.Drawing.Color.White;
            this.lblStudentSurname.Location = new System.Drawing.Point(34, 117);
            this.lblStudentSurname.Name = "lblStudentSurname";
            this.lblStudentSurname.Size = new System.Drawing.Size(142, 18);
            this.lblStudentSurname.TabIndex = 3;
            this.lblStudentSurname.Text = "Student Surname:";
            // 
            // lblStudentNumber
            // 
            this.lblStudentNumber.AutoSize = true;
            this.lblStudentNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStudentNumber.ForeColor = System.Drawing.Color.White;
            this.lblStudentNumber.Location = new System.Drawing.Point(42, 148);
            this.lblStudentNumber.Name = "lblStudentNumber";
            this.lblStudentNumber.Size = new System.Drawing.Size(134, 18);
            this.lblStudentNumber.TabIndex = 5;
            this.lblStudentNumber.Text = "Student Number:";
            // 
            // txtStudentPassword
            // 
            this.txtStudentPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.txtStudentPassword.ForeColor = System.Drawing.Color.White;
            this.txtStudentPassword.Location = new System.Drawing.Point(175, 174);
            this.txtStudentPassword.Name = "txtStudentPassword";
            this.txtStudentPassword.Size = new System.Drawing.Size(178, 24);
            this.txtStudentPassword.TabIndex = 4;
            // 
            // lblStudentPassword
            // 
            this.lblStudentPassword.AutoSize = true;
            this.lblStudentPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStudentPassword.ForeColor = System.Drawing.Color.White;
            this.lblStudentPassword.Location = new System.Drawing.Point(26, 177);
            this.lblStudentPassword.Name = "lblStudentPassword";
            this.lblStudentPassword.Size = new System.Drawing.Size(150, 18);
            this.lblStudentPassword.TabIndex = 7;
            this.lblStudentPassword.Text = "Student Password:";
            // 
            // txtStudentPasswordAgain
            // 
            this.txtStudentPasswordAgain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.txtStudentPasswordAgain.ForeColor = System.Drawing.Color.White;
            this.txtStudentPasswordAgain.Location = new System.Drawing.Point(175, 204);
            this.txtStudentPasswordAgain.Name = "txtStudentPasswordAgain";
            this.txtStudentPasswordAgain.Size = new System.Drawing.Size(178, 24);
            this.txtStudentPasswordAgain.TabIndex = 5;
            // 
            // lblPasswordAgain
            // 
            this.lblPasswordAgain.AutoSize = true;
            this.lblPasswordAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPasswordAgain.ForeColor = System.Drawing.Color.White;
            this.lblPasswordAgain.Location = new System.Drawing.Point(42, 207);
            this.lblPasswordAgain.Name = "lblPasswordAgain";
            this.lblPasswordAgain.Size = new System.Drawing.Size(134, 18);
            this.lblPasswordAgain.TabIndex = 9;
            this.lblPasswordAgain.Text = "Password Again:";
            // 
            // txtStudentMail
            // 
            this.txtStudentMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.txtStudentMail.ForeColor = System.Drawing.Color.White;
            this.txtStudentMail.Location = new System.Drawing.Point(175, 234);
            this.txtStudentMail.Name = "txtStudentMail";
            this.txtStudentMail.Size = new System.Drawing.Size(178, 24);
            this.txtStudentMail.TabIndex = 6;
            // 
            // lblStudentMail
            // 
            this.lblStudentMail.AutoSize = true;
            this.lblStudentMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStudentMail.ForeColor = System.Drawing.Color.White;
            this.lblStudentMail.Location = new System.Drawing.Point(70, 237);
            this.lblStudentMail.Name = "lblStudentMail";
            this.lblStudentMail.Size = new System.Drawing.Size(106, 18);
            this.lblStudentMail.TabIndex = 11;
            this.lblStudentMail.Text = "Student Mail:";
            // 
            // txtStudentPicture
            // 
            this.txtStudentPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.txtStudentPicture.ForeColor = System.Drawing.Color.White;
            this.txtStudentPicture.Location = new System.Drawing.Point(175, 264);
            this.txtStudentPicture.Name = "txtStudentPicture";
            this.txtStudentPicture.Size = new System.Drawing.Size(178, 24);
            this.txtStudentPicture.TabIndex = 7;
            // 
            // lblStudentPicture
            // 
            this.lblStudentPicture.AutoSize = true;
            this.lblStudentPicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStudentPicture.ForeColor = System.Drawing.Color.White;
            this.lblStudentPicture.Location = new System.Drawing.Point(48, 267);
            this.lblStudentPicture.Name = "lblStudentPicture";
            this.lblStudentPicture.Size = new System.Drawing.Size(128, 18);
            this.lblStudentPicture.TabIndex = 13;
            this.lblStudentPicture.Text = "Student Picture:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(14, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "Student Department:";
            // 
            // comBoxStudentDepartment
            // 
            this.comBoxStudentDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.comBoxStudentDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxStudentDepartment.ForeColor = System.Drawing.Color.White;
            this.comBoxStudentDepartment.FormattingEnabled = true;
            this.comBoxStudentDepartment.Location = new System.Drawing.Point(175, 297);
            this.comBoxStudentDepartment.Name = "comBoxStudentDepartment";
            this.comBoxStudentDepartment.Size = new System.Drawing.Size(178, 26);
            this.comBoxStudentDepartment.TabIndex = 9;
            // 
            // lblHeader
            // 
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(4, 30);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(404, 24);
            this.lblHeader.TabIndex = 17;
            this.lblHeader.Text = "New Student Registration";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.Location = new System.Drawing.Point(359, 264);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(34, 24);
            this.btnBrowse.TabIndex = 8;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtStudentNumber
            // 
            this.txtStudentNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.txtStudentNumber.ForeColor = System.Drawing.Color.White;
            this.txtStudentNumber.Location = new System.Drawing.Point(175, 145);
            this.txtStudentNumber.Mask = "00000";
            this.txtStudentNumber.Name = "txtStudentNumber";
            this.txtStudentNumber.Size = new System.Drawing.Size(178, 24);
            this.txtStudentNumber.TabIndex = 3;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.txtStudentNumber);
            this.groupBox.Controls.Add(this.btnBrowse);
            this.groupBox.Controls.Add(this.lblHeader);
            this.groupBox.Controls.Add(this.comBoxStudentDepartment);
            this.groupBox.Controls.Add(this.label7);
            this.groupBox.Controls.Add(this.lblStudentPicture);
            this.groupBox.Controls.Add(this.txtStudentPicture);
            this.groupBox.Controls.Add(this.lblStudentMail);
            this.groupBox.Controls.Add(this.txtStudentMail);
            this.groupBox.Controls.Add(this.lblPasswordAgain);
            this.groupBox.Controls.Add(this.txtStudentPasswordAgain);
            this.groupBox.Controls.Add(this.lblStudentPassword);
            this.groupBox.Controls.Add(this.txtStudentPassword);
            this.groupBox.Controls.Add(this.lblStudentNumber);
            this.groupBox.Controls.Add(this.lblStudentSurname);
            this.groupBox.Controls.Add(this.txtStudentSurname);
            this.groupBox.Controls.Add(this.lblStudentName);
            this.groupBox.Controls.Add(this.btnSave);
            this.groupBox.Controls.Add(this.txtStudentName);
            this.groupBox.Location = new System.Drawing.Point(12, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(411, 466);
            this.groupBox.TabIndex = 4;
            this.groupBox.TabStop = false;
            // 
            // FormStudentRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(434, 490);
            this.Controls.Add(this.groupBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormStudentRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Registration";
            this.Load += new System.EventHandler(this.FormStudentRegistration_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.TextBox txtStudentSurname;
        private System.Windows.Forms.Label lblStudentSurname;
        private System.Windows.Forms.Label lblStudentNumber;
        private System.Windows.Forms.TextBox txtStudentPassword;
        private System.Windows.Forms.Label lblStudentPassword;
        private System.Windows.Forms.TextBox txtStudentPasswordAgain;
        private System.Windows.Forms.Label lblPasswordAgain;
        private System.Windows.Forms.TextBox txtStudentMail;
        private System.Windows.Forms.Label lblStudentMail;
        private System.Windows.Forms.TextBox txtStudentPicture;
        private System.Windows.Forms.Label lblStudentPicture;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comBoxStudentDepartment;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.MaskedTextBox txtStudentNumber;
        private System.Windows.Forms.GroupBox groupBox;
    }
}