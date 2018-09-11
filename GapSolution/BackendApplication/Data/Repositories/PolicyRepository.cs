
using BackendApplication.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackendApplication.Data
{
    public class PolicyRepository : Repository<Policy>, IPolicyRepository

    {
        public void PolicySpecificAction(Policy policy)
        {
            throw new NotImplementedException();
        }
    }
}