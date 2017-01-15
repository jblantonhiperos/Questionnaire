using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuestionnaireModels;

namespace ObjectSanityCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            var q = new Question();

            Expression ue = new UserExpression();
            Expression ee = new ElementExpression();
            ue.ExpressionFormula = "User == 'kpetrella'";
            ee.ExpressionFormula = "Q2 == 'Y'";

            q.ConditionExpressions.Add(ue);
            q.ConditionExpressions.Add(ee);

            Console.WriteLine(q.GetConditionFormula());
            Console.ReadLine();
        }
    }
}
