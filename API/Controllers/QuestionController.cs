using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using QuestionnaireModels;

namespace API.Controllers
{
    public class QuestionController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<Question> Get()
        {
            throw new NotImplementedException();
        }

        // GET api/<controller>/5
        public Question Get(int id)
        {
            throw new NotImplementedException();
        }

        // POST api/<controller>
        public void Post([FromBody]Question value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]Question value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}