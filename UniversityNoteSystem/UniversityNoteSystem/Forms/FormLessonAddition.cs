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
    public partial class FormLessonAddition : Form
    {
        // Initialize
        #region INITIALIZE
        public FormLessonAddition()
        {
            InitializeComponent();
        }
        #endregion

        // Create a new entity object
        #region _NEW ENTITY OBJECT...
        UniversityNoteSystemEntities db = new UniversityNoteSystemEntities();
        #endregion

        // Save button
        #region _SAVE BUTTON...
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Check for null
            if (txtLessonName.Text != "")
            {
                // Create a new LESSONTB object
                LessonTB newLesson = new LessonTB();

                // Define new lessons name
                newLesson.LessonName = txtLessonName.Text;

                // Add new lesson to lessons table
                db.LessonTBs.Add(newLesson);

                // Save changes
                db.SaveChanges();

                // Give an informationo message to user
                MessageBox.Show("New lesson added successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Give an error message to user
                MessageBox.Show("This field can not be left blank.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}