using BackendApplication.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendApplication.Data.Repositories
{
    interface IClientRepository: IRepository<Client>
    {
        void ClientSpecificAction(Client client);
    }
}
