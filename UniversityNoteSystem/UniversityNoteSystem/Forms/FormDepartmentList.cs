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
    public partial class FormDepartmentList : Form
    {
        // Initialize
        #region INITIALIZE
        public FormDepartmentList()
        {
            InitializeComponent();
        }
        #endregion

        // Creating a new entity object
        #region _NEW ENTITY OBJECT...
        UniversityNoteSystemEntities db = new UniversityNoteSystemEntities();
        #endregion

        // List department informations
        #region _LIST DEPARTMENT INFORMATIONS...
        private void FormDepartmentList_Load(object sender, EventArgs e)
        {
            // Just list DepartmentID & DepartmentName
            var values = from x in db.DepartmentTBs
                         select new
                         {
                             x.DepartmentID,
                             x.DepartmentName
                         };
            // List data on data grid wiew
            dataGridView.DataSource = values.ToList();
        }
        #endregion
    }
}