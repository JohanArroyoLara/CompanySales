using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOM
{
    public class OrderDOM
    {
        private int id;
        private int client_id;
        private string state;
        private DateTime date;
        private DateTime term;
        private decimal total;

        public OrderDOM(int id, int client_id, string state, DateTime date, DateTime term, decimal total)
        {
            this.id = id;
            this.client_id = client_id;
            this.state = state;
            this.date = date;
            this.term = term;
            this.total = total;
        }
        public OrderDOM()
        {

        }

        public int Id { get => id; set => id = value; }
        public int Client_ID { get => client_id; set => client_id = value; }
        public string State { get => state; set => state = value; }
        public DateTime Date { get => date; set => date = value; }
        public DateTime Term { get => term; set => term = value; }
        public decimal Total { get => total; set => total = value; }

    }
}
