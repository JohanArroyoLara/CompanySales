using BL;
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
    public partial class frmDeleteEmployee : Form
    {
        RegularExpressions regularExpressions = new RegularExpressions();

        public frmDeleteEmployee()
        {
            InitializeComponent();
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            EmployeeManager employeeManager = new EmployeeManager();

            if (regularExpressions.allTextBoxesFilled(txtClientID))
            {
                int id = int.Parse(txtClientID.Text);

                if (employeeManager.getEmployee(id) != null)
                {
                    DialogResult result = MessageBox.Show("¿Seguro que desea eliminar al empleado?",
                        "ATENCIÓN", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        if (employeeManager.removeEmployee(id))
                        {
                            MessageBox.Show("Empleado eliminado con éxito");
                        }
                        else
                        {
                            MessageBox.Show("Error eliminando al empleado");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No existen empleados registrados con esa cédula");
                }

            }
            else
            {
                MessageBox.Show("Por favor, digite un código");
            }
        }

        private void txtClientID_KeyPress(object sender, KeyPressEventArgs e)
        {
            regularExpressions.onlyNumbers(e);
        }
    }
}
