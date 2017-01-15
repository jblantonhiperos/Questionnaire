using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionnaireModels
{
    public class ElementExpression : Expression
    {
        public ElementExpression()
        {
            
        }

        public List<Element> Dependencies { get; set; } // This may still be a property of the Question

        /// <summary>
        /// Converts Question and Section Variable Names to Values
        /// </summary>
        public override void ConvertExpressionVariables()
        {
        }
    }
}
