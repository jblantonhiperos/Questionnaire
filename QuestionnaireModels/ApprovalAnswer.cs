using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionnaireModels
{
    public class ApprovalAnswer : Answer
    {
        public int ApprovalRound { get; set; } // Indicates which round of approvals the answer is a part of (1 based, if it matches the 
                                               // ApprovalRoundCount of the Questionnaire it is the Final approval)
    }
}
