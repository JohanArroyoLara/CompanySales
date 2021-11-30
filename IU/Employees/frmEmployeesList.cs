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
    public partial class frmEmployeesList : Form
    {
        public frmEmployeesList()
        {
            InitializeComponent();
        }

        private void Cargar_Click(object sender, EventArgs e)
        {
            EmployeeManager employeeManager = new EmployeeManager();
            List<EmployeeDOM> employees = employeeManager.employeesList();
            grdList.DataSource = employees;
        }

        private void grdList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
