using BL;
using DOM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IU.Billing
{
    public partial class frmDeleteBilling : Form
    {

        private List<BillingDOM> billings = null;
        private List<ClientDOM> clients = null;

        public frmDeleteBilling()
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

        private void btnDeleteBilling_Click(object sender, EventArgs e)
        {
            BillingManager clientManager = new BillingManager();
            if (cbBilling.SelectedIndex == -1)
            {
                MessageBox.Show("Porfavor seleccione una factura");
            }
            else
            {
                
                int id = 0;
                int counter = 0;
                foreach (var item in billings)
                {
                    if (cbBilling.SelectedItem.ToString().Equals(billings.ElementAt(counter).ID.ToString()))
                    {
                        id = billings.ElementAt(counter).ID;
                    }
                    counter = counter + 1;
                }


                if (clientManager.getBilling(id) != null)
                {
                    DialogResult result = MessageBox.Show("¿Seguro que desea eliminar la factura?",
                        "ATENCIÓN", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        if (clientManager.removeBilling(id))
                        {
                            MessageBox.Show("Factura eliminada con éxito");
                            cbBilling.Text = "";
                            cbBilling.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("Error eliminando la factura");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No existe la factura");
                }
            }
        }

        private void cbClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbClient.SelectedIndex == -1)
            {
                MessageBox.Show("Porfavor seleccione un cliente");
            }
            else
            {
                cbBilling.Items.Clear();
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

                cbBilling.Enabled = true;
                BillingManager billingManager = new BillingManager();
                billings = billingManager.billingsList(id);
                int counter2 = 0;
                foreach (var item in billings)
                {
                    cbBilling.Items.Add(billings.ElementAt(counter2).ID);
                    counter2 = counter2 + 1;
                }
            }
        }
    }
}
