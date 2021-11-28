using BL;
using DOM;
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
            EmployeeManager employeeManager = new EmployeeManager();
            EmployeeDOM employee = new EmployeeDOM();

            if (regularExpressions.allTextBoxesFilled(txtID))
            {
                int id = int.Parse(txtID.Text);

                disableTextBox();
                btnSaveChanges.Enabled = false;

                employee = employeeManager.getEmployee(id);

                if (employee != null)
                {
                    txtFirstName.Text = employee.Name;
                    txtAddress.Text = employee.Address;
                    txtEmail.Text = employee.Email;
                    txtPhone.Text = employee.Telephone.ToString();
                    btnModify.Enabled = true;
                }
                else
                {
                    btnModify.Enabled = false;
                    clearTextBox();
                    MessageBox.Show("No se encontró el empleado");
                }

            }
            else
            {
                MessageBox.Show("Por favor, digite un código");
            }
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

        private void btnModify_Click_1(object sender, EventArgs e)
        {
            enableTextBox();
            txtID.Enabled = false;
            btnSearch.Enabled = false;
            btnSaveChanges.Enabled = true;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            EmployeeManager employeeManager = new EmployeeManager();
            EmployeeDOM client = new EmployeeDOM();

            if (regularExpressions.allTextBoxesFilled(txtFirstName, txtAddress, txtEmail, txtPhone))
            {
                int id = int.Parse(txtID.Text);

                client.Id = id;
                client.Name = txtFirstName.Text;
                client.Address = txtAddress.Text;
                client.Email = txtEmail.Text;
                client.Telephone = int.Parse(txtPhone.Text);

                if (regularExpressions.validEmailFormat(client.Email) == true)
                {

                    employeeManager.updateEmployee(client);
                    MessageBox.Show("Empleado actualizado con éxito");
                    clearTextBox();
                    txtID.Text = "";
                    disableTextBox();
                    btnModify.Enabled = false;
                    btnSaveChanges.Enabled = false;
                    btnSearch.Enabled = true;
                    txtID.Enabled = true;

                }
                else
                {
                    MessageBox.Show("Digite un formato de correo válido\n" +
                        "ejemplo@ejemplo.com");
                }

            }
            else
            {
                MessageBox.Show("Por favor, rellene todas las casillas");
            }
        }
    }
}
