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

        RegularExpressions regularExpressions = new RegularExpressions();

        public frmDeleteProduct()
        {
            InitializeComponent();
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            ProductManager productManager = new ProductManager();

            if (regularExpressions.allTextBoxesFilled(txtProductID))
            {
                int id = int.Parse(txtProductID.Text);

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
            else
            {
                MessageBox.Show("Por favor, digite un código");
            }

            
        }

        private void txtProductID_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            regularExpressions.onlyNumbers(e);
        }

    }
}
