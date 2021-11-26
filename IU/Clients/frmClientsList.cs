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
    public partial class frmClientsList : Form
    {
        public frmClientsList()
        {
            InitializeComponent();
        }

        private void Cargar_Click(object sender, EventArgs e)
        {
            ClientManager clientManager = new ClientManager();
            List<ClientDOM> clients = clientManager.clientsList();
            grdList.DataSource = clients;
        }
    }
}
