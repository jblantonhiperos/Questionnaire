using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QuestionnaireModels.InputTypes
{
    public class Textbox : IInputType
    {
        public string TypeName { get; set; }
        public ISettings Settings { get; set; }

        public bool IsValid(Answer answer)
        {
            return true;
        }
        public object GetExpressionResponse(List<Response> responses)
        {
            return responses.FirstOrDefault(i => i.Name == "Text").Value;
        }

    }
}
