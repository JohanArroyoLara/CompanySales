using ContextDB;
using DOM;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA
{
    public class ClientsDAO
    {

        ComapanySalesDBEntities DBContext = new ComapanySalesDBEntities();

        public Boolean addClient(ClientDOM client) {
            
            Client newCliente = new Client();

            newCliente.ID = client.Id;
            newCliente.FirstName = client.FirstName;
            newCliente.Email = client.Email;
            newCliente.Telephone = client.Telephone;
            newCliente.Address = client.Address;

            DBContext.Client.Add(newCliente);

            try
            {
                if (DBContext.SaveChanges()==1)
                {
                    return true;
                }
            }
            catch (Exception)
            {
                
                return false;
            }

            return false;
        }

        public ClientDOM getClient(int id)
        {
            Client clienteToFind = DBContext.Client.Find(id);
            ClientDOM client = new ClientDOM();

            if (clienteToFind != null)
            {
                client.Id = clienteToFind.ID;
                client.FirstName = clienteToFind.FirstName;
                client.Email = clienteToFind.Email;
                client.Telephone = clienteToFind.Telephone;
                client.Address = clienteToFind.Address;

                return client;
            }
            else
            {
                return null;
            }

        }

        public void updateClient(ClientDOM client)
        {

            Client newClient = new Client();

            newClient.ID = client.Id;
            newClient.FirstName = client.FirstName;
            newClient.Email = client.Email;
            newClient.Telephone = client.Telephone;
            newClient.Address = client.Address;

            DBContext.Client.Attach(newClient);
            DBContext.Entry(newClient).State = EntityState.Modified;
            DBContext.SaveChanges();

        }

        public Boolean removeClient(int id)
        {
            try
            {
                Client newClient = DBContext.Client.Find(id);
                DBContext.Entry(newClient).State = EntityState.Deleted;
                DBContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }

        public List<ClientDOM> clientsList()
        {

            List<Client> list = new List<Client>();
            List<ClientDOM> returnList = new List<ClientDOM>();
            list = DBContext.Client.ToList();

            foreach (Client c in list)
            {
                returnList.Add(new ClientDOM(c.ID,c.FirstName,c.Address,c.Email,c.Telephone));
            }
                
            return returnList;
        }

    }
}
