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
    public partial class FormLogin : Form
    {
        // Initialize
        #region INITIALIZE
        public FormLogin()
        {
            InitializeComponent();
        }
        #endregion

        // Create a new entity object
        #region _NEW ENTITY OBJECT...
        UniversityNoteSystemEntities db = new UniversityNoteSystemEntities();
        #endregion

        // Login button
        #region _LOGIN BUTTON...
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Get the input values from text boxes
            string number = txtNumber.Text; 
            string password = txtPassword.Text;

            // Perform the query using LINQ
            var ogrenci = db.StudentTBs
                .Where(o => o.StudentNumber == number && o.StudentPassword == password)
                .FirstOrDefault();

            // Check for null
            if (ogrenci != null)
            {
                // Login is successful
                FormStudentPanel frm = new FormStudentPanel();
                frm.number = txtNumber.Text;
                frm.Show();
                this.Hide();
            }
            else
            {
                // Login is not successful
                MessageBox.Show("Login failed! Please check your number and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        // Academician login
        #region _ACADEMICIAN LOGIN...
        private void txtNumber_TextChanged(object sender, EventArgs e)
        {
            if (txtNumber.Text == "12345" && txtPassword.Text == "Academician") // You can customize academician login informations as you want
            {
                // Skip to map form
                FormMap frm = new FormMap();
                frm.Show();
                this.Hide();
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtNumber.Text == "12345" && txtPassword.Text == "Academician") // You can customize academician login informations as you want
            {
                // Skip to map form
                FormMap frm = new FormMap();
                frm.Show();
                this.Hide();
            }
        }
        #endregion

        // Forget my password
        #region _FORGET MY PASSWORD...
        private void lblForgetMyPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("If you forgot your password, please contact with your academician.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
    }
}