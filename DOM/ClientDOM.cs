using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOM
{
    public class ClientDOM
    {

        private int id;
        private string firstName;
        private string email;
        private int telephone;
        private string address;

        public ClientDOM()
        {
        }

        public ClientDOM(int iD, string firstName,string address, string email, int telephone)
        {
            this.id = iD;
            this.firstName = firstName;
            this.email = email;
            this.telephone = telephone;
            this.address = address;
        }

        public int Id { get => id; set => id = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string Address { get => address; set => address = value; }
        public string Email { get => email; set => email = value; }
        public int Telephone { get => telephone; set => telephone = value; }
    }

}
