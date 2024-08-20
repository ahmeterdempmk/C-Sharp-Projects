namespace UniversityNoteSystem.Forms
{
    partial class FormStudentPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStudentPanel));
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.comBoxStudentDepartment = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblStudentMail = new System.Windows.Forms.Label();
            this.txtStudentMail = new System.Windows.Forms.TextBox();
            this.lblStudentPassword = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtStudentPassword = new System.Windows.Forms.TextBox();
            this.lblStudentNumber = new System.Windows.Forms.Label();
            this.txtStudentNumber = new System.Windows.Forms.TextBox();
            this.lblStudentSurname = new System.Windows.Forms.Label();
            this.txtStudentSurname = new System.Windows.Forms.TextBox();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNewPasswordAgain = new System.Windows.Forms.Label();
            this.txtNewPasswordAgain = new System.Windows.Forms.TextBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(127, 321);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(170, 45);
            this.btnUpdate.TabIndex = 9;
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
            this.lblHeader.Text = "Student Panel";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comBoxStudentDepartment
            // 
            this.comBoxStudentDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.comBoxStudentDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxStudentDepartment.Enabled = false;
            this.comBoxStudentDepartment.ForeColor = System.Drawing.Color.White;
            this.comBoxStudentDepartment.FormattingEnabled = true;
            this.comBoxStudentDepartment.Location = new System.Drawing.Point(175, 280);
            this.comBoxStudentDepartment.Name = "comBoxStudentDepartment";
            this.comBoxStudentDepartment.Size = new System.Drawing.Size(178, 26);
            this.comBoxStudentDepartment.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(14, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "Student Department:";
            // 
            // lblStudentMail
            // 
            this.lblStudentMail.AutoSize = true;
            this.lblStudentMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStudentMail.ForeColor = System.Drawing.Color.White;
            this.lblStudentMail.Location = new System.Drawing.Point(70, 253);
            this.lblStudentMail.Name = "lblStudentMail";
            this.lblStudentMail.Size = new System.Drawing.Size(106, 18);
            this.lblStudentMail.TabIndex = 11;
            this.lblStudentMail.Text = "Student Mail:";
            // 
            // txtStudentMail
            // 
            this.txtStudentMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.txtStudentMail.Enabled = false;
            this.txtStudentMail.ForeColor = System.Drawing.Color.White;
            this.txtStudentMail.Location = new System.Drawing.Point(175, 250);
            this.txtStudentMail.Name = "txtStudentMail";
            this.txtStudentMail.Size = new System.Drawing.Size(178, 24);
            this.txtStudentMail.TabIndex = 7;
            // 
            // lblStudentPassword
            // 
            this.lblStudentPassword.AutoSize = true;
            this.lblStudentPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStudentPassword.ForeColor = System.Drawing.Color.White;
            this.lblStudentPassword.Location = new System.Drawing.Point(87, 162);
            this.lblStudentPassword.Name = "lblStudentPassword";
            this.lblStudentPassword.Size = new System.Drawing.Size(88, 18);
            this.lblStudentPassword.TabIndex = 7;
            this.lblStudentPassword.Text = "Password:";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "Student Picture";
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(3, 20);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(837, 363);
            this.dataGridView.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView);
            this.groupBox2.Location = new System.Drawing.Point(2, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(843, 386);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            // 
            // txtStudentPassword
            // 
            this.txtStudentPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.txtStudentPassword.Enabled = false;
            this.txtStudentPassword.ForeColor = System.Drawing.Color.White;
            this.txtStudentPassword.Location = new System.Drawing.Point(175, 159);
            this.txtStudentPassword.Name = "txtStudentPassword";
            this.txtStudentPassword.Size = new System.Drawing.Size(178, 24);
            this.txtStudentPassword.TabIndex = 4;
            // 
            // lblStudentNumber
            // 
            this.lblStudentNumber.AutoSize = true;
            this.lblStudentNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStudentNumber.ForeColor = System.Drawing.Color.White;
            this.lblStudentNumber.Location = new System.Drawing.Point(42, 71);
            this.lblStudentNumber.Name = "lblStudentNumber";
            this.lblStudentNumber.Size = new System.Drawing.Size(134, 18);
            this.lblStudentNumber.TabIndex = 5;
            this.lblStudentNumber.Text = "Student Number:";
            // 
            // txtStudentNumber
            // 
            this.txtStudentNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.txtStudentNumber.Enabled = false;
            this.txtStudentNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtStudentNumber.ForeColor = System.Drawing.Color.White;
            this.txtStudentNumber.Location = new System.Drawing.Point(175, 68);
            this.txtStudentNumber.Name = "txtStudentNumber";
            this.txtStudentNumber.Size = new System.Drawing.Size(178, 24);
            this.txtStudentNumber.TabIndex = 1;
            // 
            // lblStudentSurname
            // 
            this.lblStudentSurname.AutoSize = true;
            this.lblStudentSurname.Enabled = false;
            this.lblStudentSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStudentSurname.ForeColor = System.Drawing.Color.White;
            this.lblStudentSurname.Location = new System.Drawing.Point(34, 132);
            this.lblStudentSurname.Name = "lblStudentSurname";
            this.lblStudentSurname.Size = new System.Drawing.Size(142, 18);
            this.lblStudentSurname.TabIndex = 3;
            this.lblStudentSurname.Text = "Student Surname:";
            // 
            // txtStudentSurname
            // 
            this.txtStudentSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.txtStudentSurname.Enabled = false;
            this.txtStudentSurname.ForeColor = System.Drawing.Color.White;
            this.txtStudentSurname.Location = new System.Drawing.Point(175, 129);
            this.txtStudentSurname.Name = "txtStudentSurname";
            this.txtStudentSurname.Size = new System.Drawing.Size(178, 24);
            this.txtStudentSurname.TabIndex = 3;
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Enabled = false;
            this.lblStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStudentName.ForeColor = System.Drawing.Color.White;
            this.lblStudentName.Location = new System.Drawing.Point(57, 104);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(119, 18);
            this.lblStudentName.TabIndex = 0;
            this.lblStudentName.Text = "Student Name:";
            // 
            // txtStudentName
            // 
            this.txtStudentName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.txtStudentName.Enabled = false;
            this.txtStudentName.ForeColor = System.Drawing.Color.White;
            this.txtStudentName.Location = new System.Drawing.Point(175, 99);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(178, 24);
            this.txtStudentName.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNewPasswordAgain);
            this.groupBox1.Controls.Add(this.txtNewPasswordAgain);
            this.groupBox1.Controls.Add(this.lblNewPassword);
            this.groupBox1.Controls.Add(this.txtNewPassword);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.lblHeader);
            this.groupBox1.Controls.Add(this.comBoxStudentDepartment);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblStudentMail);
            this.groupBox1.Controls.Add(this.txtStudentMail);
            this.groupBox1.Controls.Add(this.lblStudentPassword);
            this.groupBox1.Controls.Add(this.txtStudentPassword);
            this.groupBox1.Controls.Add(this.lblStudentNumber);
            this.groupBox1.Controls.Add(this.txtStudentNumber);
            this.groupBox1.Controls.Add(this.lblStudentSurname);
            this.groupBox1.Controls.Add(this.txtStudentSurname);
            this.groupBox1.Controls.Add(this.lblStudentName);
            this.groupBox1.Controls.Add(this.txtStudentName);
            this.groupBox1.Location = new System.Drawing.Point(851, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 386);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // lblNewPasswordAgain
            // 
            this.lblNewPasswordAgain.AutoSize = true;
            this.lblNewPasswordAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNewPasswordAgain.ForeColor = System.Drawing.Color.White;
            this.lblNewPasswordAgain.Location = new System.Drawing.Point(4, 222);
            this.lblNewPasswordAgain.Name = "lblNewPasswordAgain";
            this.lblNewPasswordAgain.Size = new System.Drawing.Size(172, 18);
            this.lblNewPasswordAgain.TabIndex = 22;
            this.lblNewPasswordAgain.Text = "New Password Again:";
            // 
            // txtNewPasswordAgain
            // 
            this.txtNewPasswordAgain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.txtNewPasswordAgain.ForeColor = System.Drawing.Color.White;
            this.txtNewPasswordAgain.Location = new System.Drawing.Point(175, 219);
            this.txtNewPasswordAgain.Name = "txtNewPasswordAgain";
            this.txtNewPasswordAgain.Size = new System.Drawing.Size(178, 24);
            this.txtNewPasswordAgain.TabIndex = 6;
            this.txtNewPasswordAgain.UseSystemPasswordChar = true;
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNewPassword.ForeColor = System.Drawing.Color.White;
            this.lblNewPassword.Location = new System.Drawing.Point(50, 192);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(126, 18);
            this.lblNewPassword.TabIndex = 20;
            this.lblNewPassword.Text = "New Password:";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.txtNewPassword.ForeColor = System.Drawing.Color.White;
            this.txtNewPassword.Location = new System.Drawing.Point(175, 189);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(178, 24);
            this.txtNewPassword.TabIndex = 5;
            this.txtNewPassword.UseSystemPasswordChar = true;
            // 
            // FormStudentPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1264, 399);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormStudentPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Panel";
            this.Load += new System.EventHandler(this.FormStudentPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.ComboBox comBoxStudentDepartment;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblStudentMail;
        private System.Windows.Forms.TextBox txtStudentMail;
        private System.Windows.Forms.Label lblStudentPassword;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtStudentPassword;
        private System.Windows.Forms.Label lblStudentNumber;
        private System.Windows.Forms.TextBox txtStudentNumber;
        private System.Windows.Forms.Label lblStudentSurname;
        private System.Windows.Forms.TextBox txtStudentSurname;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNewPasswordAgain;
        private System.Windows.Forms.TextBox txtNewPasswordAgain;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
    }
}