using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityNoteSystem.DAL; // Import DAL

namespace UniversityNoteSystem.Forms
{
    public partial class FormStudentPanel : Form
    {
        // Initialize
        #region INITIALIZE
        public FormStudentPanel()
        {
            InitializeComponent();
        }
        #endregion

        // Create a new entity object
        #region _NEW ENTITY OBJECT...
        UniversityNoteSystemEntities db = new UniversityNoteSystemEntities();
        #endregion

        // Define public number and studentID variables
        #region PUBLIC VARIABLES...
        public string number;
        public int studentID;
        #endregion

        // Load event
        #region _LOAD EVENT...
        private void FormStudentPanel_Load(object sender, EventArgs e)
        {
            // List departments on combobox
            comBoxStudentDepartment.ValueMember = "DepartmentID";
            comBoxStudentDepartment.DisplayMember = "DepartmentName";
            comBoxStudentDepartment.DataSource = db.DepartmentTBs.ToList();

            dataGridView.DataSource = db.StudentTBs.Where(x => x.StudentNumber == number).ToList();

            // Get values from login form
            txtStudentNumber.Text = number;
            txtStudentName.Text = db.StudentTBs.Where(x => x.StudentNumber == number).Select(y => y.StudentName).FirstOrDefault();
            txtStudentSurname.Text = db.StudentTBs.Where(x => x.StudentNumber == number).Select(y => y.StudentSurname).FirstOrDefault();
            txtStudentPassword.Text = db.StudentTBs.Where(x => x.StudentNumber == number).Select(y => y.StudentPassword).FirstOrDefault();
            txtStudentMail.Text = db.StudentTBs.Where(x => x.StudentNumber == number).Select(y => y.StudentMail).FirstOrDefault();
            comBoxStudentDepartment.SelectedValue = db.StudentTBs.Where(x => x.StudentNumber == number).Select(y => y.StudentDepartment).FirstOrDefault();

            studentID = db.StudentTBs.Where(x => x.StudentNumber == number).Select(y => y.StudentID).FirstOrDefault();

            // Define a variable to list values with a where condition
            var examNotes = (from x in db.NotesTBs
                             select new
                             {
                                 x.LessonTB.LessonName,
                                 x.Exam1,
                                 x.Exam2,
                                 x.Exam3,
                                 x.Quiz1,
                                 x.Quiz2,
                                 x.Project,
                                 x.Average,
                                 x.Student
                             }).Where(y => y.Student == studentID).ToList();
            dataGridView.DataSource = examNotes;
        }
        #endregion

        // Update button
        #region _UPDATE BUTTON...
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Check are all conditions met
            if (txtNewPassword.Text != "" && txtNewPasswordAgain.Text != "" && txtNewPassword.Text == txtNewPasswordAgain.Text)
            {
                // Define a variable to find student id in students table
                var value = db.StudentTBs.Find(studentID);

                // Define students new password
                value.StudentPassword = txtNewPassword.Text;

                // Save changes
                db.SaveChanges();

                // Give a message to user
                MessageBox.Show("Your password is updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Update password text box
                txtStudentPassword.Text = txtNewPassword.Text;

                // Clear text boxes
                txtNewPassword.Text = "";
                txtNewPasswordAgain.Text = "";
            }
            // Check are password met
            else if (txtNewPassword.Text != txtNewPasswordAgain.Text)
            {
                // Give a message to user
                MessageBox.Show("Your passwords does not match! Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Give a message to user
                MessageBox.Show("Please enter your new password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}