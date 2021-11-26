using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContextDB;
using DOM;
using System.Data.Entity;
namespace DA
{
    public class ProductsDAO
    {
        ComapanySalesDBEntities DBContext = new ComapanySalesDBEntities();

        public Boolean addProduct(ProductDOM product)
        {

            Product newProduct = new Product();

            newProduct.ID = product.Id;
            newProduct.Description = product.Description;
            newProduct.Price = product.SalesPrice;
            newProduct.Quantity = product.InvetoryQuantity;
            DBContext.Product.Add(newProduct);

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

        public ProductDOM getProduct(int id)
        {
            Product findProduct = DBContext.Product.Find(id);
            ProductDOM product = new ProductDOM();

            if (findProduct != null)
            {
                product.Id = findProduct.ID;
                product.Description = findProduct.Description;
                product.SalesPrice = findProduct.Price;
                product.InvetoryQuantity = findProduct.Quantity;

                return product;
            }
            else
            {
                return null;
            }

        }

        public void updateProduct(ProductDOM product)
        {

            Product newProduct = new Product();

            newProduct.ID = product.Id;
            newProduct.Description = product.Description;
            newProduct.Price = product.SalesPrice;
            newProduct.Quantity = product.InvetoryQuantity;

            DBContext.Product.Attach(newProduct);
            DBContext.Entry(newProduct).State = EntityState.Modified;
            DBContext.SaveChanges();

        }

        public Boolean removeProduct(int id)
        {
            try
            {
                Product newProduct = DBContext.Product.Find(id);
                DBContext.Entry(newProduct).State = EntityState.Deleted;
                DBContext.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
           
        }

        public List<ProductDOM> productsList()
        {
            List<Product> list = new List<Product>();
            List<ProductDOM> returnList = new List<ProductDOM>();
            list = DBContext.Product.ToList();

            foreach (Product product in list)
            {
                returnList.Add(new ProductDOM(product.ID, product.Description,
                                              product.Price, product.Quantity));
            }

            return returnList;
        }
    }
}
