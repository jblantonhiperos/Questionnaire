using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Models.InputTypes
{
    public class NumberBox : InputType
    {
        public override bool IsValid(object input)
        {
            float throwaway;
            return float.TryParse(input.ToString(), out throwaway);
        }
        public override object GetExpressionResponse(List<Response> responses)
        {
            return responses.FirstOrDefault(i => i.Name == "Number").Value;
        }
    }
}
