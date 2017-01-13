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

        //TODO: this might need to happen client side
        public object ExpressionResponse
        {
            get { return Type.GetExpressionResponse(Answer.Responses); }
        }
    }
}
