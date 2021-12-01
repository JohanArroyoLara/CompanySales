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

namespace IU.Order
{
    public partial class frmConsultOrder : Form
    {
        public frmConsultOrder()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonCharge_Click(object sender, EventArgs e)
        {
            OrderManager order = new OrderManager();
            dataGridView1.DataSource = order.orderdetaiList();
        }
    }
}
