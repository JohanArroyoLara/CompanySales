using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IU.Employees
{
    public partial class frmSearchEmployee : Form
    {

        RegularExpressions regularExpressions = new RegularExpressions();

        public frmSearchEmployee()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            enableTextBox();
            txtID.Enabled = false;
            btnSearch.Enabled = false;
            btnSaveChanges.Enabled = true;
        }

        private void enableTextBox()
        {
            txtFirstName.Enabled = true;
            txtAddress.Enabled = true;
            txtEmail.Enabled = true;
            txtPhone.Enabled = true;
        }

        private void disableTextBox()
        {
            txtFirstName.Enabled = false;
            txtAddress.Enabled = false;
            txtEmail.Enabled = false;
            txtPhone.Enabled = false;
        }

        private void clearTextBox()
        {
            txtFirstName.Text = "";
            txtAddress.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            regularExpressions.onlyNumbers(e);
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            regularExpressions.onlyNumbers(e);
        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            regularExpressions.onlyLetters(e);
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            regularExpressions.onlyLetters(e);
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmSearchClient_Load(object sender, EventArgs e)
        {

        }

        private void frmSearchEmployee_Load(object sender, EventArgs e)
        {

        }
        
    }
}
