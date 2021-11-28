using ContextDB;
using DOM;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA
{
    public class EmployeeDAO
    {

        ComapanySalesDBEntities DBContext = new ComapanySalesDBEntities();

        public Boolean addEmployee(EmployeeDOM employee)
        {

            Employee newEmployee = new Employee();

            newEmployee.ID = employee.Id;
            newEmployee.Name = employee.Name;
            newEmployee.Address = employee.Address;
            newEmployee.Email = employee.Email;
            newEmployee.Telephone = employee.Telephone;

            DBContext.Employee.Add(newEmployee);

            try
            {
                if (DBContext.SaveChanges() == 1)
                {
                    return true;
                }
            }
            catch (Exception)
            {

                return false;
            }

            return false;
        }

        public EmployeeDOM getEmployee(int id)
        {
            Employee employeeToFind = DBContext.Employee.Find(id);
            EmployeeDOM employee = new EmployeeDOM();

            if (employeeToFind != null)
            {
                employee.Id = employeeToFind.ID;
                employee.Name = employeeToFind.Name;
                employee.Address = employeeToFind.Address;
                employee.Email = employeeToFind.Email;
                employee.Telephone = (int) employeeToFind.Telephone;

                return employee;
            }
            else
            {
                return null;
            }

        }

        public void updateEmployee(EmployeeDOM employee)
        {

            Employee newEmployee = new Employee();

            newEmployee.ID = employee.Id;
            newEmployee.Name = employee.Name;
            newEmployee.Address = employee.Address;
            newEmployee.Email = employee.Email;
            newEmployee.Telephone = employee.Telephone;

            DBContext.Employee.Attach(newEmployee);
            DBContext.Entry(newEmployee).State = EntityState.Modified;
            DBContext.SaveChanges();

        }

        public Boolean removeEmployee(int id)
        {
            try
            {
                Employee newEmployee = DBContext.Employee.Find(id);
                DBContext.Entry(newEmployee).State = EntityState.Deleted;
                DBContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public List<EmployeeDOM> employeesList()
        {

            List<Employee> list = new List<Employee>();
            List<EmployeeDOM> returnList = new List<EmployeeDOM>();
            list = DBContext.Employee.ToList();

            foreach (Employee e in list)
            {
                returnList.Add(new EmployeeDOM(e.ID, e.Name, e.Address, e.Email, (int) e.Telephone));
            }

            return returnList;
        }


    }

}
