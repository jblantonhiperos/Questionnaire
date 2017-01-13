using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Models.InputTypes
{
    public class Textbox : IInputType
    {
        public string TypeName { get; set; }
        public Settings Settings { get; set; }

        public bool IsValid(object input)
        {
            return true;
        }
        public object GetExpressionResponse(List<Response> responses)
        {
            return responses.FirstOrDefault(i => i.Name == "Text").Value;
        }

    }
}
