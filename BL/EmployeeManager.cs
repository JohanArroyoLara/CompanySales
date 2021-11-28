using DA;
using DOM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    class EmployeeManager
    {

        EmployeeDAO employeeDAO = new EmployeeDAO();

        public Boolean addEmployee(EmployeeDOM employee)
        {
            return employeeDAO.addEmployee(employee);
        }

        public EmployeeDOM getEmployee(int id)
        {
            return employeeDAO.getEmployee(id);
        }

        public Boolean removeEmployee(int id)
        {
            return employeeDAO.removeEmployee(id);
        }

        public void updateEmployee(EmployeeDOM employee)
        {
            employeeDAO.updateEmployee(employee);
        }

        public List<EmployeeDOM> employeesList()
        {
            return employeeDAO.employeesList();
        }

    }

}
