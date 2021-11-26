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

namespace IU.Billing
{
    public partial class frmAddBilling : Form
    {

        RegularExpressions regularExpressions = new RegularExpressions();

        public frmAddBilling()
        {
            InitializeComponent();
        }

        private void txtClientID_KeyPress(object sender, KeyPressEventArgs e)
        {
            regularExpressions.onlyNumbers(e);
        }

        private void txtProductCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            regularExpressions.onlyNumbers(e);
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            regularExpressions.onlyNumbers(e);
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            ProductManager productManager = new ProductManager();
            ProductDOM product = new ProductDOM();

            if (regularExpressions.allTextBoxesFilled(txtProductCode))
            {
                product = productManager.getProduct(int.Parse(txtProductCode.Text));

                if (product != null)
                {
                    txtPrice.Text = product.SalesPrice.ToString();
                }
                else
                {
                    MessageBox.Show("No se encontró el producto");
                    txtPrice.Text = "";
                }

            }
            else
            {
                MessageBox.Show("Por favor, digite un código");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (regularExpressions.allTextBoxesFilled(txtClientID, txtProductCode, txtQuantity,
                txtPrice))
            {

                ClientManager clientManager = new ClientManager();
                ProductManager productManager = new ProductManager();
                ProductDOM product = new ProductDOM();

                int clientID = int.Parse(txtClientID.Text);
                product = productManager.getProduct(int.Parse(txtProductCode.Text));

                
                if (int.Parse(txtQuantity.Text)<=product.InvetoryQuantity)
                {
                    if (clientManager.getClient(clientID) != null)
                    {

                        BillingManager billingManager = new BillingManager();

                        int subTotal = int.Parse(txtQuantity.Text) * int.Parse(txtPrice.Text);

                        BillingDOM billing = new BillingDOM(clientID,
                            int.Parse(txtProductCode.Text), int.Parse(txtQuantity.Text),
                            int.Parse(txtPrice.Text), subTotal);

                        if (billingManager.addBilling(billing))
                        {
                            MessageBox.Show("Facturación realizada con éxito");
                            //product.InvetoryQuantity = product.InvetoryQuantity - int.Parse(txtQuantity.Text);
                            //productManager.updateProduct(product);
                        }
                        else
                        {
                            MessageBox.Show("ERROR realizando la facturación");
                        }

                    }
                    else
                    {
                        MessageBox.Show("No existe un cliente con esa cédula");
                    }

                }
                else
                {
                    MessageBox.Show("La cantidad solicitada excede la del inventario\n" +
                        "Unidades en el inventario: " + product.InvetoryQuantity);
                }

            }
            else
            {
                MessageBox.Show("Por favor, rellene todas las casillas");
            }

        }

        private void txtSubTotal_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void txtQuantity_KeyUp(object sender, KeyEventArgs e)
        {
            if (regularExpressions.allTextBoxesFilled(txtQuantity, txtPrice))
            {
                int subTotal = int.Parse(txtQuantity.Text) * int.Parse(txtPrice.Text);
                txtSubTotal.Text = subTotal.ToString();
            }
            else
            {
                txtSubTotal.Text = "";
            }
            
        }
    }
}
