using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOM
{
    public class ProductDOM
    {
        int id;
        string name;
        String description;
        Decimal salesPrice;
        int quantity;

        public ProductDOM(int id, string description, Decimal salesPrice, string name, int quantity)
        {
            this.id = id;
            this.description = description;
            this.salesPrice = salesPrice;
            this.name = name;
            this.quantity = quantity;
        }

        public ProductDOM()
        {
        }

        public int Id { get => id; set => id = value; }
        public string Description { get => description; set => description = value; }
        public Decimal SalesPrice { get => salesPrice; set => salesPrice = value; }
        public string Name { get => name; set => name = value; }
        public int Quantity { get => quantity; set => quantity = value; }
    }
}
