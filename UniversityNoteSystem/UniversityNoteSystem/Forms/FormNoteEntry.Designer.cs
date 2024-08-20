namespace UniversityNoteSystem.Forms
{
    partial class FormNoteEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNoteEntry));
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.lblExam1 = new System.Windows.Forms.Label();
            this.txtExam1 = new System.Windows.Forms.TextBox();
            this.btnList = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.comBoxLesson = new System.Windows.Forms.ComboBox();
            this.lblLesson = new System.Windows.Forms.Label();
            this.lblStudent = new System.Windows.Forms.Label();
            this.txtStudent = new System.Windows.Forms.TextBox();
            this.lblProject = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.txtProject = new System.Windows.Forms.TextBox();
            this.txtQuiz2 = new System.Windows.Forms.TextBox();
            this.lblQuiz1 = new System.Windows.Forms.Label();
            this.txtQuiz1 = new System.Windows.Forms.TextBox();
            this.lblExam3 = new System.Windows.Forms.Label();
            this.txtExam3 = new System.Windows.Forms.TextBox();
            this.lblExam2 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtExam2 = new System.Windows.Forms.TextBox();
            this.lblQuiz2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAverage = new System.Windows.Forms.Label();
            this.txtAverage = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtStudentNumber = new System.Windows.Forms.MaskedTextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.comBoxPickLesson = new System.Windows.Forms.ComboBox();
            this.lblPickLesson = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "Student Picture";
            // 
            // lblExam1
            // 
            this.lblExam1.AutoSize = true;
            this.lblExam1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblExam1.ForeColor = System.Drawing.Color.White;
            this.lblExam1.Location = new System.Drawing.Point(81, 103);
            this.lblExam1.Name = "lblExam1";
            this.lblExam1.Size = new System.Drawing.Size(69, 18);
            this.lblExam1.TabIndex = 21;
            this.lblExam1.Text = "Exam 1:";
            // 
            // txtExam1
            // 
            this.txtExam1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.txtExam1.ForeColor = System.Drawing.Color.White;
            this.txtExam1.Location = new System.Drawing.Point(149, 101);
            this.txtExam1.Name = "txtExam1";
            this.txtExam1.Size = new System.Drawing.Size(178, 24);
            this.txtExam1.TabIndex = 1;
            // 
            // btnList
            // 
            this.btnList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnList.ForeColor = System.Drawing.Color.White;
            this.btnList.Location = new System.Drawing.Point(130, 570);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(170, 45);
            this.btnList.TabIndex = 13;
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
            this.btnBrowse.Location = new System.Drawing.Point(333, 276);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(34, 20);
            this.btnBrowse.TabIndex = 8;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(130, 510);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(170, 45);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(4, 25);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(404, 24);
            this.lblHeader.TabIndex = 17;
            this.lblHeader.Text = "Note Entry";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comBoxLesson
            // 
            this.comBoxLesson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.comBoxLesson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxLesson.ForeColor = System.Drawing.Color.White;
            this.comBoxLesson.FormattingEnabled = true;
            this.comBoxLesson.Location = new System.Drawing.Point(149, 307);
            this.comBoxLesson.Name = "comBoxLesson";
            this.comBoxLesson.Size = new System.Drawing.Size(178, 26);
            this.comBoxLesson.TabIndex = 9;
            // 
            // lblLesson
            // 
            this.lblLesson.AutoSize = true;
            this.lblLesson.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLesson.ForeColor = System.Drawing.Color.White;
            this.lblLesson.Location = new System.Drawing.Point(82, 311);
            this.lblLesson.Name = "lblLesson";
            this.lblLesson.Size = new System.Drawing.Size(68, 18);
            this.lblLesson.TabIndex = 15;
            this.lblLesson.Text = "Lesson:";
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStudent.ForeColor = System.Drawing.Color.White;
            this.lblStudent.Location = new System.Drawing.Point(80, 277);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(70, 18);
            this.lblStudent.TabIndex = 13;
            this.lblStudent.Text = "Student:";
            // 
            // txtStudent
            // 
            this.txtStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.txtStudent.ForeColor = System.Drawing.Color.White;
            this.txtStudent.Location = new System.Drawing.Point(149, 274);
            this.txtStudent.Name = "txtStudent";
            this.txtStudent.Size = new System.Drawing.Size(178, 24);
            this.txtStudent.TabIndex = 7;
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProject.ForeColor = System.Drawing.Color.White;
            this.lblProject.Location = new System.Drawing.Point(83, 247);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(67, 18);
            this.lblProject.TabIndex = 11;
            this.lblProject.Text = "Project:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView);
            this.groupBox2.Location = new System.Drawing.Point(2, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(843, 517);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(3, 20);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(837, 494);
            this.dataGridView.TabIndex = 13;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // txtProject
            // 
            this.txtProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.txtProject.ForeColor = System.Drawing.Color.White;
            this.txtProject.Location = new System.Drawing.Point(149, 244);
            this.txtProject.Name = "txtProject";
            this.txtProject.Size = new System.Drawing.Size(178, 24);
            this.txtProject.TabIndex = 6;
            // 
            // txtQuiz2
            // 
            this.txtQuiz2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.txtQuiz2.ForeColor = System.Drawing.Color.White;
            this.txtQuiz2.Location = new System.Drawing.Point(149, 217);
            this.txtQuiz2.Name = "txtQuiz2";
            this.txtQuiz2.Size = new System.Drawing.Size(178, 24);
            this.txtQuiz2.TabIndex = 5;
            // 
            // lblQuiz1
            // 
            this.lblQuiz1.AutoSize = true;
            this.lblQuiz1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblQuiz1.ForeColor = System.Drawing.Color.White;
            this.lblQuiz1.Location = new System.Drawing.Point(88, 190);
            this.lblQuiz1.Name = "lblQuiz1";
            this.lblQuiz1.Size = new System.Drawing.Size(62, 18);
            this.lblQuiz1.TabIndex = 5;
            this.lblQuiz1.Text = "Quiz 1:";
            // 
            // txtQuiz1
            // 
            this.txtQuiz1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.txtQuiz1.ForeColor = System.Drawing.Color.White;
            this.txtQuiz1.Location = new System.Drawing.Point(149, 187);
            this.txtQuiz1.Name = "txtQuiz1";
            this.txtQuiz1.Size = new System.Drawing.Size(178, 24);
            this.txtQuiz1.TabIndex = 4;
            // 
            // lblExam3
            // 
            this.lblExam3.AutoSize = true;
            this.lblExam3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblExam3.ForeColor = System.Drawing.Color.White;
            this.lblExam3.Location = new System.Drawing.Point(81, 160);
            this.lblExam3.Name = "lblExam3";
            this.lblExam3.Size = new System.Drawing.Size(69, 18);
            this.lblExam3.TabIndex = 3;
            this.lblExam3.Text = "Exam 3:";
            // 
            // txtExam3
            // 
            this.txtExam3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.txtExam3.ForeColor = System.Drawing.Color.White;
            this.txtExam3.Location = new System.Drawing.Point(149, 157);
            this.txtExam3.Name = "txtExam3";
            this.txtExam3.Size = new System.Drawing.Size(178, 24);
            this.txtExam3.TabIndex = 3;
            // 
            // lblExam2
            // 
            this.lblExam2.AutoSize = true;
            this.lblExam2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblExam2.ForeColor = System.Drawing.Color.White;
            this.lblExam2.Location = new System.Drawing.Point(81, 130);
            this.lblExam2.Name = "lblExam2";
            this.lblExam2.Size = new System.Drawing.Size(69, 18);
            this.lblExam2.TabIndex = 0;
            this.lblExam2.Text = "Exam 2:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(130, 453);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(170, 45);
            this.btnCalculate.TabIndex = 11;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtExam2
            // 
            this.txtExam2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.txtExam2.ForeColor = System.Drawing.Color.White;
            this.txtExam2.Location = new System.Drawing.Point(149, 127);
            this.txtExam2.Name = "txtExam2";
            this.txtExam2.Size = new System.Drawing.Size(178, 24);
            this.txtExam2.TabIndex = 2;
            // 
            // lblQuiz2
            // 
            this.lblQuiz2.AutoSize = true;
            this.lblQuiz2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblQuiz2.ForeColor = System.Drawing.Color.White;
            this.lblQuiz2.Location = new System.Drawing.Point(88, 220);
            this.lblQuiz2.Name = "lblQuiz2";
            this.lblQuiz2.Size = new System.Drawing.Size(62, 18);
            this.lblQuiz2.TabIndex = 7;
            this.lblQuiz2.Text = "Quiz 2:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAverage);
            this.groupBox1.Controls.Add(this.txtAverage);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.lblExam1);
            this.groupBox1.Controls.Add(this.txtExam1);
            this.groupBox1.Controls.Add(this.btnList);
            this.groupBox1.Controls.Add(this.btnBrowse);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.lblHeader);
            this.groupBox1.Controls.Add(this.comBoxLesson);
            this.groupBox1.Controls.Add(this.lblLesson);
            this.groupBox1.Controls.Add(this.lblStudent);
            this.groupBox1.Controls.Add(this.txtStudent);
            this.groupBox1.Controls.Add(this.lblProject);
            this.groupBox1.Controls.Add(this.txtProject);
            this.groupBox1.Controls.Add(this.lblQuiz2);
            this.groupBox1.Controls.Add(this.txtQuiz2);
            this.groupBox1.Controls.Add(this.lblQuiz1);
            this.groupBox1.Controls.Add(this.txtQuiz1);
            this.groupBox1.Controls.Add(this.lblExam3);
            this.groupBox1.Controls.Add(this.txtExam3);
            this.groupBox1.Controls.Add(this.lblExam2);
            this.groupBox1.Controls.Add(this.btnCalculate);
            this.groupBox1.Controls.Add(this.txtExam2);
            this.groupBox1.Location = new System.Drawing.Point(851, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 644);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAverage.ForeColor = System.Drawing.Color.White;
            this.lblAverage.Location = new System.Drawing.Point(77, 344);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(73, 18);
            this.lblAverage.TabIndex = 27;
            this.lblAverage.Text = "Average:";
            // 
            // txtAverage
            // 
            this.txtAverage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.txtAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAverage.ForeColor = System.Drawing.Color.White;
            this.txtAverage.Location = new System.Drawing.Point(149, 341);
            this.txtAverage.Name = "txtAverage";
            this.txtAverage.Size = new System.Drawing.Size(178, 26);
            this.txtAverage.TabIndex = 26;
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(130, 395);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(170, 45);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(75, 74);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(75, 18);
            this.lblID.TabIndex = 23;
            this.lblID.Text = " Note ID:";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.txtID.Enabled = false;
            this.txtID.ForeColor = System.Drawing.Color.White;
            this.txtID.Location = new System.Drawing.Point(149, 71);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(178, 24);
            this.txtID.TabIndex = 24;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtStudentNumber);
            this.groupBox3.Controls.Add(this.btnSearch);
            this.groupBox3.Controls.Add(this.lblStudentID);
            this.groupBox3.Controls.Add(this.comBoxPickLesson);
            this.groupBox3.Controls.Add(this.lblPickLesson);
            this.groupBox3.Location = new System.Drawing.Point(2, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(843, 125);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            // 
            // txtStudentNumber
            // 
            this.txtStudentNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.txtStudentNumber.ForeColor = System.Drawing.Color.White;
            this.txtStudentNumber.Location = new System.Drawing.Point(168, 74);
            this.txtStudentNumber.Name = "txtStudentNumber";
            this.txtStudentNumber.Size = new System.Drawing.Size(178, 24);
            this.txtStudentNumber.TabIndex = 30;
            this.txtStudentNumber.ValidatingType = typeof(int);
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(632, 44);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(170, 45);
            this.btnSearch.TabIndex = 28;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStudentID.ForeColor = System.Drawing.Color.White;
            this.lblStudentID.Location = new System.Drawing.Point(76, 77);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(91, 18);
            this.lblStudentID.TabIndex = 29;
            this.lblStudentID.Text = "Student ID:";
            // 
            // comBoxPickLesson
            // 
            this.comBoxPickLesson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.comBoxPickLesson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxPickLesson.ForeColor = System.Drawing.Color.White;
            this.comBoxPickLesson.FormattingEnabled = true;
            this.comBoxPickLesson.Location = new System.Drawing.Point(168, 30);
            this.comBoxPickLesson.Name = "comBoxPickLesson";
            this.comBoxPickLesson.Size = new System.Drawing.Size(178, 26);
            this.comBoxPickLesson.TabIndex = 28;
            this.comBoxPickLesson.SelectedIndexChanged += new System.EventHandler(this.comBoxPickLesson_SelectedIndexChanged);
            // 
            // lblPickLesson
            // 
            this.lblPickLesson.AutoSize = true;
            this.lblPickLesson.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPickLesson.ForeColor = System.Drawing.Color.White;
            this.lblPickLesson.Location = new System.Drawing.Point(66, 34);
            this.lblPickLesson.Name = "lblPickLesson";
            this.lblPickLesson.Size = new System.Drawing.Size(101, 18);
            this.lblPickLesson.TabIndex = 29;
            this.lblPickLesson.Text = "Pick lesson:";
            // 
            // FormNoteEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1270, 656);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormNoteEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Note Entry";
            this.Load += new System.EventHandler(this.FormNoteEntry_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label lblExam1;
        private System.Windows.Forms.TextBox txtExam1;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.ComboBox comBoxLesson;
        private System.Windows.Forms.Label lblLesson;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.TextBox txtStudent;
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox txtProject;
        private System.Windows.Forms.TextBox txtQuiz2;
        private System.Windows.Forms.Label lblQuiz1;
        private System.Windows.Forms.TextBox txtQuiz1;
        private System.Windows.Forms.Label lblExam3;
        private System.Windows.Forms.TextBox txtExam3;
        private System.Windows.Forms.Label lblExam2;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtExam2;
        private System.Windows.Forms.Label lblQuiz2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.TextBox txtAverage;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.ComboBox comBoxPickLesson;
        private System.Windows.Forms.Label lblPickLesson;
        private System.Windows.Forms.MaskedTextBox txtStudentNumber;
    }
}