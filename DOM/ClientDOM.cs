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
        private string lastName;
        private string email;
        private int telephone;

        public ClientDOM()
        {
        }

        public ClientDOM(int iD, string firstName, string lastName, string email, int telephone)
        {
            this.id = iD;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.telephone = telephone;
        }

        public int Id { get => id; set => id = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Email { get => email; set => email = value; }
        public int Telephone { get => telephone; set => telephone = value; }
    }

}
