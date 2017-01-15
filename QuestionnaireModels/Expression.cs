using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionnaireModels
{
    public abstract class Expression
    {
        /*public Expression()
        {
            //ExpressionFormula = "1+2+3";
            //Dependencies = new List<Element>
            //{
            //    new ElementInstance()
            //    {
            //        ConditionExpression = null,
            //        Name = "a",
            //        ScoreExpression = null,
            //        Type = new NumberBox(),
            //        Answer = new Answer
            //        {
            //            CalculatedScore = 0,
            //            IsDelegated = false,
            //            IsSubmitted = true,
            //            Respondant = null,
            //            Responses = new List<Response>
            //            {
            //                new Response{Name="Number",Value="3"}
            //            }
            //        }
            //    }
            //};
        }*/
        
        public string ExpressionFormula { get; set; } // This is stored in the DB
        //public List<Element> Dependencies { get; set; } I believe this would only refer to ElementExpressions

        public void Evaluate()
        {
            /*
            TypeRegistry registry = ResolveDependencies();
            var p = new CompiledExpression(ExpressionFormula) { TypeRegistry = registry };
            p.Compile();
            return p.Eval();
             */
        }

        public abstract void ConvertExpressionVariables();
        
        /*
        public TypeRegistry ResolveDependencies()
        {
            /*
            // TODO if not instance
            // TODO if not answered
            TypeRegistry reg = new TypeRegistry();
            
            foreach (Element dependency in Dependencies)
            {
                reg.RegisterSymbol(dependency.Name, ((Element) dependency).ExpressionResponse);
            }
            return reg;
            
        }*/
    }
}
