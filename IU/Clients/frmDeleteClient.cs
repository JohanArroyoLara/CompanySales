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
    public partial class frmDeleteClient : Form
    {

        RegularExpressions regularExpressions = new RegularExpressions();
        public frmDeleteClient()
        {
            InitializeComponent();
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            ClientManager clientManager = new ClientManager();

            if (regularExpressions.allTextBoxesFilled(txtClientID))
            {
                int id = int.Parse(txtClientID.Text);

                if (clientManager.getClient(id) != null)
                {
                    DialogResult result = MessageBox.Show("¿Seguro que desea eliminar al cliente?",
                        "ATENCIÓN", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        if (clientManager.removeClient(id))
                        {
                            MessageBox.Show("Cliente eliminado con éxito");
                        }
                        else
                        {
                            MessageBox.Show("Error eliminando al cliente");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No existen clientes registrados con esa cédula");
                }

            }
            else
            {
                MessageBox.Show("Por favor, digite un código");
            }

        }

        private void txtClientID_KeyPress(object sender, KeyPressEventArgs e)
        {
            regularExpressions.onlyNumbers(e);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
