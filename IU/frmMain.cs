using IU.Billing;
using IU.Employees;
using IU.Order;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IU
{
    public partial class frmMain : Form
    {
        private int childFormNumber = 0;

        public frmMain()
        {
            InitializeComponent();
        }

       /* private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }*/

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e) {
            frmAddClient addClient = new frmAddClient();
            addClient.MdiParent = this;
            addClient.Show();
        }

        private void agregarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddProduct addProduct = new frmAddProduct();
            addProduct.MdiParent = this;
            addProduct.Show();
        }

        private void eliminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmDeleteClient deleteClient = new frmDeleteClient();
            deleteClient.MdiParent = this;
            deleteClient.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSearchClient searchClient = new frmSearchClient();
            searchClient.MdiParent = this;
            searchClient.Show();
        }

        private void todosLosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientsList clientsList = new frmClientsList();
            clientsList.MdiParent = this;
            clientsList.Show();
        }

        private void todosLosProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductsList productList = new frmProductsList();
            productList.MdiParent = this;
            productList.Show();
        }

        private void verOModificarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSearchProduct searchProduct = new frmSearchProduct();
            searchProduct.MdiParent = this;
            searchProduct.Show();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeleteProduct deleteProduct = new frmDeleteProduct();
            deleteProduct.MdiParent = this;
            deleteProduct.Show();
        }

        private void facturaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void reporteDeFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAddEmployee addEmployee = new frmAddEmployee();
            addEmployee.MdiParent = this;
            addEmployee.Show();
        }

        private void eliminarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmDeleteEmployee deleteEmployee = new frmDeleteEmployee();
            deleteEmployee.MdiParent = this;
            deleteEmployee.Show();
        }

        private void listaDeEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmployeesList frmEmployeesList = new frmEmployeesList();
            frmEmployeesList.MdiParent = this;
            frmEmployeesList.Show();
        }

        private void editarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSearchEmployee frmSearchEmployee = new frmSearchEmployee();
            frmSearchEmployee.MdiParent = this;
            frmSearchEmployee.Show();
        }

        private void agregarOrdenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddOrder frmSearchEmployee = new frmAddOrder();
            frmSearchEmployee.MdiParent = this;
            frmSearchEmployee.Show();
        }

        private void editarOrdenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditOrder frmSearchEmployee = new frmEditOrder();
            frmSearchEmployee.MdiParent = this;
            frmSearchEmployee.Show();
        }

        private void eliminarOrdenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeleteOrder frmDelete = new frmDeleteOrder();
            frmDelete.MdiParent = this;
            frmDelete.Show();
        }

        private void consultarOrdenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultOrder frmDelete = new frmConsultOrder();
            frmDelete.MdiParent = this;
            frmDelete.Show();
        }

        private void facturaciónToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAddBilling addBilling = new frmAddBilling();
            addBilling.MdiParent = this;
            addBilling.Show();
        }

        private void reporteDeFacturasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmBillingReport billingReport = new frmBillingReport();
            billingReport.MdiParent = this;
            billingReport.Show();
        }
    }
}
