using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Models;

namespace API.Controllers
{
    [RoutePrefix("api/expression")]
    public class ExpressionController : ApiController
    {
        
        //[Route("{evaluate}")]
        public HttpResponseMessage Evaluate(Expression expression)
        {
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, expression.Evaluate());

            return response;
        }
    }
}
