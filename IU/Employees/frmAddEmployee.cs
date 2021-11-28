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
    public partial class frmAddEmployee : Form
    {

        RegularExpressions regularExpressions = new RegularExpressions();

        public frmAddEmployee()
        {
            InitializeComponent();
        }

        private void lblLastName_Click(object sender, EventArgs e)
        {

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {

            EmployeeManager employeeManager = new EmployeeManager();

            if (regularExpressions.allTextBoxesFilled(txtID, txtFirstName, txtAddress,
                                                        txtEmail, txtPhone))
            {

                EmployeeDOM employee = new EmployeeDOM(int.Parse(txtID.Text), txtFirstName.Text, txtAddress.Text,
                                txtEmail.Text, int.Parse(txtPhone.Text));

                if (regularExpressions.validEmailFormat(employee.Email) == true)
                {

                    if (employeeManager.getEmployee(employee.Id) == null)
                    {
                        employeeManager.addEmployee(employee);
                        MessageBox.Show("Empleado agregado con éxito");
                    }
                    else
                    {
                        MessageBox.Show("Ya existe un empleado registrado con esa cédula");
                    }

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

        private void txtID_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            regularExpressions.onlyNumbers(e);
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            regularExpressions.onlyLetters(e);
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            regularExpressions.onlyNumbers(e);
        }
    }
}
