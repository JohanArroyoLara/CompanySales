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
    public partial class frmBillingReport : Form
    {

        RegularExpressions regularExpressions = new RegularExpressions();

        public frmBillingReport()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BillingManager billingManager = new BillingManager();
            
          
                if (cbClients.SelectedIndex == -1)
                {
                    MessageBox.Show("Porfavor seleccione nn cliente");
                }
                else
                {
                    int id = 0;
                    int counter = 0;
                    foreach (var item in clients)
                    {
                        if (cbClients.SelectedItem.ToString().Equals(clients.ElementAt(counter).FirstName))
                        {
                            id = clients.ElementAt(counter).Id;
                        }
                        counter = counter + 1;
                    }


                    int clientID = id;

                ClientManager clientManager = new ClientManager();
                DateTime date1 = dtpSince.Value;
                DateTime date2 = dtpTo.Value;

                if (date1.Date <= date2.Date)
                {

                    if (clientManager.getClient(int.Parse(txtID.Text)) != null)
                    {
                        List<BillingDOM> billings = billingManager.billingsReport(int.Parse(txtID.Text),
                                                    date1, date2);
                        grdBilling.DataSource = billings;
                        txtTotal.Text = billingManager.total(billings).ToString();
                    }
                    else
                    {

                        MessageBox.Show("No se encontró al cliente");
                    }

                }

                else
                {
                    MessageBox.Show("La segunda fecha no puede ser menor a la primera");
                }

            }
            else
            {
                MessageBox.Show("Por favor, digite una cédula");
            }
            
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            regularExpressions.onlyNumbers(e);
        }
    }
}
