using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QuestionnaireModels.InputTypes
{
    public class NumberBox : IInputType
    {
        public string TypeName { get; set; }
        public Settings Settings { get; set; }

        public  bool IsValid(object input)
        {
            float throwaway;
            return float.TryParse(input.ToString(), out throwaway);
        }
        public  object GetExpressionResponse(List<Response> responses)
        {
            return this;
        }
    }
}
