using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityNoteSystem.DAL; // Import DAL

namespace UniversityNoteSystem.Forms
{
    public partial class FormNoteEntry : Form
    {
        #region _INITIALIZE...
        public FormNoteEntry()
        {
            InitializeComponent();
        }
        #endregion

        // Create a new entity object
        #region _NEW ENTITY OBJECT...
        UniversityNoteSystemEntities db = new UniversityNoteSystemEntities();
        #endregion

        // Transfer informations to comboboxes
        #region _TRANSFER INFORMATIONS TO COMBOBOXES...
        private void FormNoteEntry_Load(object sender, EventArgs e)
        {
            comBoxLesson.ValueMember = "LessonID";
            comBoxLesson.DisplayMember = "LessonName";
            comBoxLesson.DataSource = db.LessonTBs.ToList();

            comBoxPickLesson.ValueMember = "LessonID";
            comBoxPickLesson.DisplayMember = "LessonName";
            comBoxPickLesson.DataSource = db.LessonTBs.ToList();
        }
        #endregion

        // Buttons
        #region _BUTTONS...

        // Add button
        #region _ADD BUTTON...
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Create a new notes table object
            NotesTB newEntry = new NotesTB();

            if (txtExam1.Text != "" && txtExam2.Text != "" && txtExam3.Text != "" && txtQuiz1.Text != "" && txtQuiz2.Text != "" && txtProject.Text != "" && txtStudent.Text != "")
            {
                // Define new entrys properties
                #region _NEW ENTRYS PROPERTIES
                newEntry.Exam1 = byte.Parse(txtExam1.Text);
                newEntry.Exam2 = byte.Parse(txtExam2.Text);
                newEntry.Exam3 = byte.Parse(txtExam3.Text);
                newEntry.Quiz1 = byte.Parse(txtQuiz1.Text);
                newEntry.Quiz2 = byte.Parse(txtQuiz2.Text);
                newEntry.Project = byte.Parse(txtProject.Text);
                newEntry.Lesson = int.Parse(comBoxLesson.SelectedValue.ToString());
                newEntry.Student = int.Parse(txtStudent.Text);
                #endregion

                // Add new entry to notes table
                db.NotesTBs.Add(newEntry);

                // Save changes
                db.SaveChanges();

                // Give a message to user
                MessageBox.Show("Note information has been successfully added to the system.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please add all values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        // Calculate button
        #region _CALCULATE BUTTON...
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Variables for notes
            int exam1, exam2, exam3, quiz1, quiz2, project, average;

            if (txtExam1.Text != "" && txtExam2.Text != "" && txtExam3.Text != "" && txtQuiz1.Text != "" && txtQuiz2.Text != "" && txtProject.Text != "" && txtStudent.Text != "")
            {
                // Define notes
                exam1 = int.Parse(txtExam1.Text);
                exam2 = int.Parse(txtExam2.Text);
                exam3 = int.Parse(txtExam3.Text);
                quiz1 = int.Parse(txtQuiz1.Text);
                quiz2 = int.Parse(txtQuiz2.Text);
                project = int.Parse(txtProject.Text);

                // Calculate average
                average = (exam1 + exam2 + exam3 + quiz1 + quiz2 + project) / 6;

                // Transferring average to textbox
                txtAverage.Text = average.ToString();
            }
            else
            {
                MessageBox.Show("The information attempted to be calculated is missing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        // List button
        #region _LIST BUTTON...
        private void btnList_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = db.averageCalculation();
        }
        #endregion

        // Search button
        #region _SEARCH BUTTON...
        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Define a variable to list values 
            var values = from x in db.NotesTBs
                         select new
                         {
                             x.NoteID,
                             x.LessonTB.LessonName,
                             x.Exam1,
                             x.Exam2,
                             x.Exam3,
                             x.Quiz1,
                             x.Quiz2,
                             x.Project,
                             x.Average,
                             x.Lesson,
                             x.Student,
                         };

            // Check for null
            if (txtStudentNumber.Text != "")
            {
                // Get entered number in a variable
                int i = int.Parse(txtStudentNumber.Text);

                // Transfer data to datagridwiew where visual y variable equals to entered number (variable i)
                dataGridView.DataSource = values.Where(y => y.Student == i).ToList();

                // Hide lesson column
                dataGridView.Columns["Lesson"].Visible = false;
            }
        }
        #endregion

        // Update button
        #region _UPDATE BUTTON...
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "" && txtExam1.Text != "" && txtExam2.Text != "" && txtExam3.Text != "" && txtQuiz1.Text != "" && txtQuiz2.Text != "" && txtProject.Text != "" && txtAverage.Text != "")
            {
                // Get ID value
                int id = int.Parse(txtID.Text);

                // Define a variable to find ID value in students table
                var x = db.NotesTBs.Find(id);

                // Enter new informations of selected student
                x.Exam1 = byte.Parse(txtExam1.Text);
                x.Exam2 = byte.Parse(txtExam2.Text);
                x.Exam3 = byte.Parse(txtExam3.Text);
                x.Quiz1 = byte.Parse(txtQuiz1.Text);
                x.Quiz2 = byte.Parse(txtQuiz2.Text);
                x.Project = byte.Parse(txtProject.Text);
                x.Average = byte.Parse(txtAverage.Text);

                // Save changes
                db.SaveChanges();

                // Give a message to user
                MessageBox.Show("The selected students notes has been successfully update.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Give a error message to user
                MessageBox.Show("Please enter value to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #endregion

        // Transferring informations to tools
        #region _TRANSFERRING INFORMATIONS TO TOOLS...
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtExam1.Text = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtExam2.Text = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtExam3.Text = dataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtQuiz1.Text = dataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtQuiz2.Text = dataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtProject.Text = dataGridView.Rows[e.RowIndex].Cells[8].Value.ToString();
            txtAverage.Text = dataGridView.Rows[e.RowIndex].Cells[9].Value.ToString();
        }
        #endregion

        // Listing by lesson
        #region _LISTING BY LESSON
        private void comBoxPickLesson_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Define a var type variable to list properties
            var values = from x in db.NotesTBs
                         select new
                         {
                             x.NoteID,
                             x.LessonTB.LessonName,
                             StudentName = x.StudentTB.StudentName + " " + x.StudentTB.StudentSurname,
                             x.Exam1,
                             x.Exam2,
                             x.Exam3,
                             x.Quiz1,
                             x.Quiz2,
                             x.Project,
                             x.Lesson,
                             x.Average
                         };

            // Define a variable to get selected value on combobox
            int d = int.Parse(comBoxPickLesson.SelectedValue.ToString());

            // Transfer data to datagridwiew where visual y variable equals to selected value (variable d)
            dataGridView.DataSource = values.Where(y => y.Lesson == d).ToList();

            // Hide lesson column
            dataGridView.Columns["Lesson"].Visible = false;
        }
        #endregion
    }
}