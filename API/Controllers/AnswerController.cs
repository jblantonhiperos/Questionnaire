using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using QuestionnaireModels;

namespace API.Controllers
{
    public class AnswerController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<Answer> Get()
        {
            throw new NotImplementedException();
        }

        // GET api/<controller>/5
        public Answer Get(int id)
        {
            throw new NotImplementedException();
        }

        // POST api/<controller>
        public void Post([FromBody]Answer value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]Answer value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}