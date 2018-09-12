using BackendApplication.Data.Repositories;
using BackendApplication.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BackendApplication.Controllers
{
    public class ClientController : ApiController
    {
        private ClientRepository _repository;

        public ClientController()
        {

            _repository = new ClientRepository();
        }
        public ClientController(ClientRepository repository)
        {
            _repository = repository;
        }       
        // GET: api/Client
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Client/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Client
        public void Post([FromBody]Client value)
        {
            _repository.Add(value);
        }

        // PUT: api/Client/5
        public void Put(int id, [FromBody]Client value)
        {
            _repository.toUpdate(value);
        }

        // DELETE: api/Client/5
        public void Delete(int id)
        {
        }
    }
}
