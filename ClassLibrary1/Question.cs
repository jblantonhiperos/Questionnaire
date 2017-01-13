using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Models
{
    public class Question:Element
    {
        public IQuestionType Type { get; set; }
        public Answer Answer { get; set; }

        public object QuestionResponse()
        {
            return Type.Inputs;
        }
        //TODO: this might need to happen client side

    }
}
