using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionnaireModels
{
    public class Element : Translatable
    {
        public string Name { get; set; }
        public List<Expression> ScoreExpressions { get; set; }
        
        /// <summary>
        /// Is made up of a User Expression Formula and Element Expression Formula. This allows the User Expression to be re-created
        /// everytime delegation is done so that the newly delegated user can see the question without any problems. It also allows
        /// the designer of Questionnaire the ability to specify users and groups of a question or section without worrying about looking
        /// at a more convoluted expression. (We are building the User/Group Permissions portion of the equation for them)
        /// </summary>
        public List<Expression> ConditionExpressions { get; set; }

        public string GetScoreFormula()
        {
            return "";
        }

        /// <summary>
        /// Creates a Relevance/Conditionality formula from the list of expressions
        /// </summary>
        /// <returns></returns>
        public string GetConditionFormula()
        {
            var formula = "";

            for (int i = 0; i < ConditionExpressions.Count;i++)
            {
                var exp = ConditionExpressions[i];

                if (i != 0)
                {
                    formula += " AND ";
                }

                formula += exp.ExpressionFormula;
            }

            return formula;
        }

        public  object ExpressionResponse;

    }
}
