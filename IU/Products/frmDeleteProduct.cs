using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DOM;
using BL;

namespace IU
{
    public partial class frmDeleteProduct : Form
    {
        private List<ProductDOM> products = null;
        RegularExpressions regularExpressions = new RegularExpressions();

        public frmDeleteProduct()
        {
            InitializeComponent();
            ProductManager productM = new ProductManager();
            products = productM.productList();
            int counter = 0;
            foreach (var item in products)
            {

                cbmuebles.Items.Add(products.ElementAt(counter).Name);
                counter = counter + 1;
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            ProductManager productManager = new ProductManager();

            int id = 0;
            int counter = 0;
            foreach (var item in products)
            {
                if (cbmuebles.SelectedItem.ToString().Equals(products.ElementAt(counter).Name))
                {
                    id = products.ElementAt(counter).Id;
                }
                counter = counter + 1;
            }


            if (productManager.getProduct(id) != null)
                {
                    DialogResult result = MessageBox.Show("¿Seguro que desea eliminar el producto?",
                        "ATENCIÓN", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        if (productManager.removeProduct(id))
                        {
                            MessageBox.Show("Producto eliminado con éxito");
                        }
                        else
                        {
                            MessageBox.Show("Error eliminando el producto");
                        }
                        
                    }
                }
                else
                {
                    MessageBox.Show("No existen productos registrados con ese código");
                }

           

            
        }

        private void txtProductID_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            regularExpressions.onlyNumbers(e);
        }

    }
}
