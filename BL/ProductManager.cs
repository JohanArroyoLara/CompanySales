using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DA;
using DOM;

namespace BL
{
    public class ProductManager
    {
        ProductsDAO productsDAO = new ProductsDAO();

        public Boolean addProduct(ProductDOM product)
        {
            return productsDAO.addProduct(product);
        }

        public ProductDOM getProduct(int id)
        {
            return productsDAO.getProduct(id);
        }

        public Boolean removeProduct(int id)
        {
            return productsDAO.removeProduct(id);
        }

        public void updateProduct(ProductDOM product)
        {
            productsDAO.updateProduct(product);
        }

        public List<ProductDOM> productList()
        {
            return productsDAO.productsList();
        }
    }
}
