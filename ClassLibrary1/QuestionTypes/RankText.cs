using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.InputTypes;

namespace Models.QuestionTypes
{
    public class RankText:IQuestionType
    {
        public List<IInputType> Inputs { get; set; }

        public bool IsValid(Answer input)
        {
            return Inputs.All(i => i.IsValid(input));
        }

        public RankText()
        {
            Inputs=new List<IInputType>
            {
                new NumberBox(),
                new Textbox() 
            };
        }
    }
}
