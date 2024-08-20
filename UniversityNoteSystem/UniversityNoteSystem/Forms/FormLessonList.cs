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
    public partial class FormLessonList : Form
    {
        // Initialize
        #region INITIALIZE
        public FormLessonList()
        {
            InitializeComponent();
        }
        #endregion

        // Create a new entity object
        #region _NEW ENTITY OBJECT...
        UniversityNoteSystemEntities db = new UniversityNoteSystemEntities();
        #endregion

        // List lessons
        #region _LIST LESSONS...
        private void FormLessonList_Load(object sender, EventArgs e)
        {
            // Just list LessonID & LessonName
            var lessonList = from x in db.LessonTBs
                             select new
                             {
                                 x.LessonID,
                                 x.LessonName
                             };
            // List data on data grid wiew
            dataGridView.DataSource = lessonList.ToList();
        }
        #endregion
    }
}