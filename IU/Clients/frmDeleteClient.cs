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
        private List<ClientDOM> clients = null;

        RegularExpressions regularExpressions = new RegularExpressions();
        public frmDeleteClient()
        {
            InitializeComponent();
            ClientManager clientM = new ClientManager();
           clients = clientM.clientsList();
            int counter = 0;
            foreach (var item in clients)
            {

               cbClient.Items.Add(clients.ElementAt(counter).FirstName);
                counter = counter + 1;
            }
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            ClientManager clientManager = new ClientManager();
            int id = 0;
            int counter = 0;
            foreach (var item in clients)
            {
                if (cbClient.SelectedItem.ToString().Equals(clients.ElementAt(counter).FirstName))
                {
                    id = clients.ElementAt(counter).Id;
                }
                counter = counter + 1;
            }
          

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

        private void txtClientID_KeyPress(object sender, KeyPressEventArgs e)
        {
            regularExpressions.onlyNumbers(e);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
