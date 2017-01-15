using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionnaireModels
{
    public interface IQuestionType
    {
        List<IInputType> Inputs { get; set; }
        bool IsValid(Answer answer);

    }
}
