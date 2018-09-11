using BackendApplication.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackendApplication.Data.Repositories
{
    public class ClientRepository : Repository<Client>, IClientRepository
    {
        public void ClientSpecificAction(Client client)
        {
            throw new NotImplementedException();
        }
    }
}