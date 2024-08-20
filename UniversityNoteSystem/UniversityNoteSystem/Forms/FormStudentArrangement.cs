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
    public partial class FormStudentArrangement : Form
    {
        // Initialize
        #region INITIALIZE
        public FormStudentArrangement()
        {
            InitializeComponent();
        }
        #endregion

        // Creating a new entity object
        #region _NEW ENTITY OBJECT...
        UniversityNoteSystemEntities db = new UniversityNoteSystemEntities();
        #endregion

        // Define a method to list student informations
        #region _LIST METHOD...
        void listStudentInformations()
        {
            // Define a variable to list values
            var values = from x in db.StudentTBs
                         select new
                         {
                             x.StudentID,
                             x.StudentName,
                             x.StudentSurname,
                             x.StudentNumber,
                             x.StudentPassword,
                             x.StudentMail,
                             x.StudentPicture,
                             x.StudentDepartment,
                             x.StudentStatus,
                             x.DepartmentTB.DepartmentName
                         };

            // List only those with correct status
            dataGridView.DataSource = values.Where(x=> x.StudentStatus == true).ToList();
        }
        #endregion

        // Define a public number variable
        #region _NUMBER VARIABLE...
        public string number;
        #endregion

        // List student informations on load
        #region _LIST STUDENT INFORMATIONS ON LOAD...
        private void FormStudentArrangement_Load(object sender, EventArgs e)
        {
            // Call list method
            listStudentInformations();

            // Hide number of department and students status
            dataGridView.Columns["StudentDepartment"].Visible = false;
            dataGridView.Columns["StudentStatus"].Visible = false;

            // List departments on combobox
            comBoxStudentDepartment.ValueMember = "DepartmentID";
            comBoxStudentDepartment.DisplayMember = "DepartmentName";
            comBoxStudentDepartment.DataSource = db.DepartmentTBs.ToList();
        }
        #endregion

        // Transferring information to tools
        #region _TRANSFERRING INFORMATIONS TO TOOLS...
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtStudentID.Text = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtStudentName.Text = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtStudentSurname.Text = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtStudentNumber.Text = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtStudentPassword.Text = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtStudentMail.Text = dataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtStudentPicture.Text = dataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
            comBoxStudentDepartment.SelectedValue = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[7].Value);
        }
        #endregion

        // Buttons
        #region _BUTTONS...
        // List button
        #region _LIST BUTTON...
        private void btnList_Click(object sender, EventArgs e)
        {
            // Call list method
            listStudentInformations();

            // Hide number of department and students status
            dataGridView.Columns["StudentDepartment"].Visible = false;
            dataGridView.Columns["StudentStatus"].Visible = false;
        }
        #endregion

        // Delete button
        #region _DELETE BUTTON...
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtStudentID.Text != "")
            {
                // Get ID value
                int id = int.Parse(txtStudentID.Text);

                // Define a variable to find ID value in students table
                var x = db.StudentTBs.Find(id);

                // Make found items status false
                x.StudentStatus = false;

                // Save changes
                db.SaveChanges();

                // Give a message to user
                MessageBox.Show("The selected student has been successfully deleted from the system.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Call list function
                listStudentInformations();
            }
            else
            {
                MessageBox.Show("Please select the student you want to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        // Update button
        #region _UPDATE BUTTON...
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtStudentID.Text != "")
            {
                // Get ID value
                int id = int.Parse(txtStudentID.Text);

                // Define a variable to find ID value in students table
                var x = db.StudentTBs.Find(id);

                // Enter new informations of selected student

                x.StudentName = txtStudentName.Text;
                x.StudentSurname = txtStudentSurname.Text;
                x.StudentNumber = txtStudentNumber.Text;
                x.StudentPassword = txtStudentPassword.Text;
                x.StudentMail = txtStudentMail.Text;
                x.StudentPicture = txtStudentPicture.Text;
                x.StudentDepartment = int.Parse(comBoxStudentDepartment.SelectedValue.ToString());

                // Save changes
                db.SaveChanges();

                // Give a message to user
                MessageBox.Show("The selected student has been successfully update.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Call list function
                listStudentInformations();
            }
            else
            {
                // Give a error message to user
                MessageBox.Show("Please enter values you want to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        // Browse button
        #region _BROWSE BUTTON...
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            txtStudentPicture.Text = openFileDialog.FileName;
        }
        #endregion
        #endregion
    }
}