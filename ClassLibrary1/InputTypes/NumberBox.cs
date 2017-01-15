using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Models.InputTypes
{
    public class NumberBox : IInputType
    {
        public string TypeName { get; set; }
        public ISettings Settings { get; set; }

        public bool IsValid(Answer answer)
        {
            float throwaway;
            return answer.Responses.Any(i => i.Name == "Number")
                   && float.TryParse(answer.Responses.First(i => i.Name == "Number").Value.ToString(), out throwaway);
        }

        public  object GetExpressionResponse(List<Response> responses)
        {
            return responses.FirstOrDefault(i => i.Name == "Number").Value;
        }
    }
}
