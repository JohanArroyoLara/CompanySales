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
using DOM;

namespace IU.Employees
{
    public partial class frmDeleteEmployee : Form
    {
        private List<EmployeeDOM> employees = null;
        RegularExpressions regularExpressions = new RegularExpressions();

        public frmDeleteEmployee()
        {
            InitializeComponent();
            EmployeeManager employeM = new EmployeeManager();
          employees = employeM.employeesList();
            int counter = 0;
            foreach (var item in employees)
            {

                cbEmployee.Items.Add(employees.ElementAt(counter).Name);
                counter = counter + 1;
            }
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            EmployeeManager employeeManager = new EmployeeManager();
            if (cbEmployee.SelectedIndex == -1)
            {
             MessageBox.Show("Porfavor seleccione un empleado a eliminar");
            }
            else
            {
                int id = 0;
            int counter = 0;
            foreach (var item in employees)
            {
                if (cbEmployee.SelectedItem.ToString().Equals(employees.ElementAt(counter).Name))
                {
                    id = employees.ElementAt(counter).Id;
                }
                counter = counter + 1;
            }

          
             
          
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
          
        }

        private void txtClientID_KeyPress(object sender, KeyPressEventArgs e)
        {
            regularExpressions.onlyNumbers(e);
        }
    }
}
