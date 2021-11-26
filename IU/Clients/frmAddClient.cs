using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using BL;
using DOM;

namespace IU
{
    public partial class frmAddClient : Form
    {

        RegularExpressions regularExpressions = new RegularExpressions();

        public frmAddClient()
        {
            InitializeComponent();
        }

        private void frmAddClient_Load(object sender, EventArgs e)
        {

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            

        }

        private void btnAccept_Click_1(object sender, EventArgs e)
        {
            ClientManager clientManager = new ClientManager();

            if (regularExpressions.allTextBoxesFilled(txtID, txtFirstName, txtLastName,
                                                        txtEmail, txtPhone))
            {

                ClientDOM client = new ClientDOM(int.Parse(txtID.Text), txtFirstName.Text, txtLastName.Text,
                                txtEmail.Text, int.Parse(txtPhone.Text));

                if (regularExpressions.validEmailFormat(client.Email) == true)
                {

                    if (clientManager.getClient(client.Id) == null)
                    {
                        clientManager.addClient(client);
                        MessageBox.Show("Cliente agregado con éxito");
                    }
                    else
                    {
                        MessageBox.Show("Ya existe un cliente registrado con esa cédula");
                    }

                }
                else
                {
                    MessageBox.Show("Digite un formato de correo válido\n" +
                        "ejemplo@ejemplo.com");
                }

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

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            regularExpressions.onlyNumbers(e);
        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            regularExpressions.onlyLetters(e);
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            regularExpressions.onlyLetters(e);
        }

        private void lblLastName_Click(object sender, EventArgs e)
        {

        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
