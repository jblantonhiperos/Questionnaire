using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuestionnaireModels;

namespace QuestionnaireModels
{
    public interface IInputType
    {
        string TypeName { get; set; }
        ISettings Settings { get; set; }
        bool IsValid(Answer input);
        object GetExpressionResponse(List<Response> response);
    }
}
