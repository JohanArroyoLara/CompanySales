using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DA;
using DOM;

namespace BL
{
    public class ClientManager
    {

        ClientsDAO clientsDAO = new ClientsDAO();

        public Boolean addClient(ClientDOM client)
        {
            return clientsDAO.addClient(client);
        }

        public ClientDOM getClient(int id)
        {
            return clientsDAO.getClient(id);
        }

        public Boolean removeClient(int id)
        {
           return clientsDAO.removeClient(id);
        }

        public void updateClient(ClientDOM client)
        {
            clientsDAO.updateClient(client);
        }

        public List<ClientDOM> clientsList()
        {
            return clientsDAO.clientsList();
        }

    }
}
