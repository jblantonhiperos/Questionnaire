using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class InputType
    {
        public string TypeName { get; set; }
        public Settings Settings { get; set; }

        public virtual bool IsValid(object input)
        {
            return true;
        }

        public virtual object GetExpressionResponse(List<Response> response)
        {
            //HACK BUG TODO this is should not be implemented, but i need it to test my api
            return response.First().Value;
        }

    }
}
