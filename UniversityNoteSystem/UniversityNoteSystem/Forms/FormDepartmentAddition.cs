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
    public partial class FormDepartmentAddition : Form
    {
        // Initialize
        #region INITIALIZE
        public FormDepartmentAddition()
        {
            InitializeComponent();
        }
        #endregion

        // Creating a new entity object
        #region _NEW ENTITY OBJECT...
        UniversityNoteSystemEntities db = new UniversityNoteSystemEntities();
        #endregion

        // Save button
        #region _SAVE BUTTON...
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Check for null
            if (txtDepartmentName.Text != "")
            {
                // Create a new DEPARTMENTSTB object
                DepartmentTB newDepartment = new DepartmentTB();

                // Define new departments name
                newDepartment.DepartmentName = txtDepartmentName.Text;

                // Add new department to DEPARTMENTTB table
                db.DepartmentTBs.Add(newDepartment);

                // Save changes
                db.SaveChanges();

                // Give an informationo message to user
                MessageBox.Show("New department added successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Give an error message to user
                MessageBox.Show("This field can not be left blank.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion
        }
    }
}