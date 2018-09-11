using BackendApplication.Data;
using BackendApplication.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BackendApplication.Controllers
{
    public class PoliciesController : ApiController
    {
        private PolicyRepository _repository;

        public PoliciesController() {

            _repository = new PolicyRepository();
        }
        public PoliciesController(PolicyRepository repository)
        {
            _repository = repository;
        }
        // GET: api/Policies
        public IEnumerable<string> Get()
        {
            var parameter1 = new QueryParameters<Policy>(1, 5);
            var policies = _repository.FindBy(parameter1);

            return new string[] { "value1", "value2" };
        }

        // GET: api/Policies/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Policies
        public void Post([FromBody]Policy value)
        {            
            _repository.Add(value);
        }

        // PUT: api/Policies/5
        public void Put([FromBody]Policy value)
        {
            _repository.toUpdate(value);
        }

        // DELETE: api/Policies/5
        public void Delete(int id)
        {
            _repository.Delete(id);
        }
    }
}
