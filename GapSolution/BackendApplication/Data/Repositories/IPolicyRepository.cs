using BackendApplication.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendApplication.Data
{
    interface IPolicyRepository: IRepository<Policy>
    {
        void PolicySpecificAction(Policy policy);
    }
}
