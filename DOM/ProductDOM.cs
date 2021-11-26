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
        String description;
        Decimal salesPrice;
        int invetoryQuantity;

        public ProductDOM(int id, string description, Decimal salesPrice, int invetoryQuantity)
        {
            this.id = id;
            this.description = description;
            this.salesPrice = salesPrice;
            this.invetoryQuantity = invetoryQuantity;
        }

        public ProductDOM()
        {
        }

        public int Id { get => id; set => id = value; }
        public string Description { get => description; set => description = value; }
        public Decimal SalesPrice { get => salesPrice; set => salesPrice = value; }
        public int InvetoryQuantity { get => invetoryQuantity; set => invetoryQuantity = value; }
    }
}
