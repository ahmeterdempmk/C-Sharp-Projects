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
    public partial class FormStudentRegistration : Form
    {
        // Initialize
        #region INITIALIZE
        public FormStudentRegistration()
        {
            InitializeComponent();
        }
        #endregion

        // Creating a new entity object
        #region _NEW ENTITY OBJECT...
        UniversityNoteSystemEntities db = new UniversityNoteSystemEntities();
        #endregion

        // List students on load
        #region _LIST STUDENTS ON LOAD...
        private void FormStudentRegistration_Load(object sender, EventArgs e)
        {
            comBoxStudentDepartment.ValueMember = "DepartmentID";
            comBoxStudentDepartment.DisplayMember = "DepartmentName";
            comBoxStudentDepartment.DataSource = db.DepartmentTBs.ToList();
        }
        #endregion

        // Buttons
        #region _BUTTONS...
        
        // Save button code
        #region _SAVE BUTTON CODE...
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Check are all conditions met
            if (txtStudentPassword.Text == txtStudentPasswordAgain.Text && txtStudentName.Text != "" && txtStudentSurname.Text != "" && txtStudentNumber.Text != "" && txtStudentPassword.Text != "" && txtStudentMail.Text != "" && comBoxStudentDepartment.SelectedIndex != -1)
            {
                // Creating a new STUDENT object
                StudentTB newStudent = new StudentTB();

                // Define new students informations
                newStudent.StudentName = txtStudentName.Text;
                newStudent.StudentSurname = txtStudentSurname.Text;
                newStudent.StudentNumber = txtStudentNumber.Text;
                newStudent.StudentPassword = txtStudentPassword.Text;
                newStudent.StudentMail = txtStudentMail.Text;
                newStudent.StudentPicture = txtStudentPicture.Text;
                newStudent.StudentDepartment = int.Parse(comBoxStudentDepartment.SelectedValue.ToString());
                newStudent.StudentStatus = true;

                // Add new student to STUDENTSTB
                db.StudentTBs.Add(newStudent);

                // Save changes
                db.SaveChanges();

                // Give a message to user
                MessageBox.Show("The new student has been successfully added to the system.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear parameters after registration
                txtStudentName.Text = "";
                txtStudentSurname.Text = "";
                txtStudentNumber.Text = "";
                txtStudentPassword.Text = "";
                txtStudentPasswordAgain.Text = "";
                txtStudentMail.Text = "";
                txtStudentPicture.Text = "";
            }
            else if (txtStudentPassword.Text != txtStudentPasswordAgain.Text)
            {
                MessageBox.Show("Passwords do not match! Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Please fill in all the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        // Browse button code
        #region _BROWSE BUTTON CODE...
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            txtStudentPicture.Text = openFileDialog.FileName;
        }
        #endregion
        #endregion
    }
}