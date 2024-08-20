using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityNoteSystem.Forms
{
    public partial class FormMap : Form
    {
        // Initialize
        #region INITIALIZE
        public FormMap()
        {
            InitializeComponent();
        }
        #endregion

        // Form transitions
        #region _FORM TRANSITIONS
        private void lblLessonPage_Click(object sender, EventArgs e)
        {
            FormLessonList frm = new FormLessonList();
            frm.Show();
        }

        private void lblStudentRegistration_Click(object sender, EventArgs e)
        {
            FormStudentRegistration frm = new FormStudentRegistration();
            frm.Show();
        }

        private void lblDepartmentList_Click(object sender, EventArgs e)
        {
            FormDepartmentList frm = new FormDepartmentList();
            frm.Show();
        }

        private void lblNewDepartment_Click(object sender, EventArgs e)
        {
            FormDepartmentAddition frm = new FormDepartmentAddition();
            frm.Show();
        }

        private void lblNotesPage_Click(object sender, EventArgs e)
        {
            FormNoteEntry frm = new FormNoteEntry();
            frm.Show();
        }

        private void lblStudentsPage_Click(object sender, EventArgs e)
        {
            FormStudentArrangement frm = new FormStudentArrangement();
            frm.Show();
        }

        private void lblNewLesson_Click(object sender, EventArgs e)
        {
            FormLessonAddition frm = new FormLessonAddition();
            frm.Show();
        }
        #endregion

        // Help label
        #region _HELP LABEL...
        private void lblHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This project was developed by Ahmet Erdem Pamuk and consists of a scenario that includes a school's grading system, including 3 exam notes, 2 quiz notes and 1 project note. The current academician number in the project is 12345 and the password is Academician. You can update your password and number in the 63rd and 74th lines in the code section of the 'FormLogin' form.",
                "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        // Logout label
        #region _LOGOUT LABEL...
        private void lblLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}