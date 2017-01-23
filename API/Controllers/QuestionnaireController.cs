using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using QuestionnaireModels;

namespace API.Controllers
{
    public class QuestionnaireController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<Questionnaire> Get()
        {
            throw new NotImplementedException();
        }

        // GET api/<controller>/5
        public Questionnaire Get(int id)
        {
            throw new NotImplementedException();
        }

        // POST api/<controller>
        public void Post([FromBody]Questionnaire value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]Questionnaire value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}
