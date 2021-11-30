using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using DOM;

namespace IU
{
    public partial class frmAddProduct : Form
    {

        RegularExpressions regularExpressions = new RegularExpressions();

        public frmAddProduct()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            ProductManager productManager = new ProductManager();

            if (regularExpressions.allTextBoxesFilled(txtDescription, txtPrice,  txtQuantity))
            {

                ProductDOM product = new ProductDOM(int.Parse(txtCode.Text),
                                                txtDescription.Text,
                                                int.Parse(txtPrice.Text),
                                                txtName.Text,
                                                int.Parse(txtQuantity.Text));

                if (productManager.getProduct(product.Id) == null)
                {
                    productManager.addProduct(product);
                    MessageBox.Show("Producto agregado con éxito");
                }
                else
                {
                    MessageBox.Show("Ya existe un producto registrado con este id");
                }

            }
            else
            {
                MessageBox.Show("Por favor, rellene todas las casillas");
            }

            

           
        }

        private void txtCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            regularExpressions.onlyNumbers(e);
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            regularExpressions.onlyNumbers(e);
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            regularExpressions.onlyNumbers(e);
        }
    }
}
