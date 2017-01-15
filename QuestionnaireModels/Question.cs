using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionnaireModels
{
    public class Question : Element
    {
        public IQuestionType Type { get; set; }

        /// <summary>
        /// The reason I created a list of Eval Answers and Approval Answers is that I  believe we can use "Answers" (may be not a great name
        /// for it) as a 
        /// </summary>
        public List<EvalAnswer> EvalAnswers { get; set; }
        public List<ApprovalAnswer> ApprovalAnswers { get; set; }

        /// <summary>
        /// Not a good name, but this would handle taking all of the individual scores from each of the EvalAnswers and provide an overall computed score
        /// </summary>
        public void CombineEvalAnswerScoring()
        {
            
        }

        public List<User> RetrieveCurrentEvalUsers()
        {
            var currentEvalList = new List<User>();

            foreach (var a in EvalAnswers)
            {
                var latestDelegationDate = a.UserLog.Keys.Max();
                var currentUser = a.UserLog[latestDelegationDate];

                currentEvalList.Add(currentUser);
            }

            return currentEvalList;
        }

        public List<User> RetrieveCurrentApprovalUsers()
        {
            //same as RetrieveCurrentEvalUsers but with Approvers
            var currentAppList = new List<User>();
            return currentAppList;
        }

        /// <summary>
        /// Not hashed out yet
        /// </summary>
        public void AddCurrentUsersToRelevanceExpression()
        {
            /*
            var currentEvalUsers = RetrieveCurrentEvalUsers();
            var currentApprovalUsers = RetrieveCurrentApprovalUsers();

            var b = new StringBuilder();
            b.Append(ConditionExpressions.ExpressionFormula);

            foreach (var u in currentEvalUsers)
            {
                ConditionExpression.ExpressionFormula += " AND UserType(User or Group) = " + u.Name;
            }
            */
            
        }

    }
}
