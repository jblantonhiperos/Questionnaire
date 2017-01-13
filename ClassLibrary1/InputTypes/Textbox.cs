using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Models.InputTypes
{
    public class Textbox : InputType
    {
        public override object GetExpressionResponse(List<Response> responses)
        {
            return responses.FirstOrDefault(i => i.Name == "Text").Value;
        }
    }
}
