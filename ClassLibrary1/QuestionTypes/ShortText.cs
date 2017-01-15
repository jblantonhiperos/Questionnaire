using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.InputTypes;

namespace Models.QuestionTypes
{
    public class ShortText : IQuestionType
    {
        public int QuestionLength = 10;
        public List<IInputType> Inputs { get; set; }

        public bool IsValid(Answer answer)
        {
            return Inputs.All(i => i.IsValid(answer));
        }
    
        public ShortText()
        {
            Inputs.Add(new Textbox());
        }

    }
}
