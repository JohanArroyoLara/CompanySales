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
    public partial class frmSearchProduct : Form
    {

        RegularExpressions regularExpressions = new RegularExpressions();

        public frmSearchProduct()
        {
            InitializeComponent();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            enableTextBox();
            txtID.Enabled = false;
            btnSearch.Enabled = false;
            btnSaveChanges.Enabled = true;
            btnModify.Enabled = false;
        }
        private void enableTextBox()
        {
           
            txtDescription.Enabled = true;
            txtInventory.Enabled = true;
            txtPrice.Enabled = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ProductManager productManager = new ProductManager();
            ProductDOM product = new ProductDOM();

            if (regularExpressions.allTextBoxesFilled(txtID))
            {

                int id = int.Parse(txtID.Text);

                disableTextBox();
                btnSaveChanges.Enabled = false;

                product = productManager.getProduct(id);

                if (product != null)
                {
                    txtDescription.Text = product.Description;
                    txtInventory.Text = product.Quantity.ToString();
                    txtPrice.Text = product.SalesPrice.ToString();

                    btnModify.Enabled = true;
                }
                else
                {
                    btnModify.Enabled = false;
                    clearTextBox();
                    MessageBox.Show("No se encontró el producto");
                }

            }
            else
            {
                MessageBox.Show("Por favor, digite un código");
            }

            
        }

        private void disableTextBox()
        {
            txtDescription.Enabled = false;
            txtPrice.Enabled = false;
            txtInventory.Enabled = false;
            
        }
        private void clearTextBox()
        {
            txtDescription.Text = "";
            txtPrice.Text = "";
            txtInventory.Text = "";
            
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            ProductManager productManager = new ProductManager();
            ProductDOM product = new ProductDOM();

            int id = int.Parse(txtID.Text);

            if (regularExpressions.allTextBoxesFilled(txtID, txtDescription, txtPrice, txtInventory)) {

            product.Id = id;
            product.Description = txtDescription.Text;
            product.SalesPrice = int.Parse(txtPrice.Text);
            product.Name = txtName.Text;
            product.Quantity = int.Parse(txtInventory.Text);
            
            productManager.updateProduct(product);
            MessageBox.Show("Producto actualizado con éxito");
            clearTextBox();
            txtID.Text = "";
            disableTextBox();
            btnModify.Enabled = false;
            btnSaveChanges.Enabled = false;
            btnSearch.Enabled = true;
            txtID.Enabled = true;

            }
            else
            {
                MessageBox.Show("Por favor, rellene todas las casillas");
            }

        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            regularExpressions.onlyNumbers(e);
        }

        private void textInventory_KeyPress(object sender, KeyPressEventArgs e)
        {
            regularExpressions.onlyNumbers(e);
        }

        private void textPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            regularExpressions.onlyNumbers(e);
        }
    }
}
