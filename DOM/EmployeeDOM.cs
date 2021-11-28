using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOM
{
    public class EmployeeDOM
    {

        private int id;
        private string name;
        private string address;
        private string email;
        private int telephone;

        public EmployeeDOM()
        {
        }

        public EmployeeDOM(int id, string firstName, string address, string email, int telephone)
        {
            this.id = id;
            this.name = firstName;
            this.address = address;
            this.email = email;
            this.telephone = telephone;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string Email { get => email; set => email = value; }
        public int Telephone { get => telephone; set => telephone = value; }


    }

}
