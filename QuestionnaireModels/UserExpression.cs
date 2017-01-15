using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionnaireModels
{
    public class UserExpression : Expression
    {
        public UserExpression()
        {
            
        }

        /// <summary>
        /// Converts User and Group Names to Expression Variables. Not sure if this is needed
        /// </summary>
        public override void ConvertExpressionVariables()
        {
        }
    }
}
