using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.InputTypes;
using ExpressionEvaluator;

namespace Models
{
    public class Expression
    {
        
        public string ExpressionFormula { get; set; }
        public List<Element> Dependencies { get; set; }

        public object Evaluate()
        {
            TypeRegistry registry = ResolveDependencies();
            var p = new CompiledExpression(ExpressionFormula) { TypeRegistry = registry };
            p.Compile();
            return p.Eval();
        }

        public TypeRegistry ResolveDependencies()
        {
            // TODO if not valid
            // TODO if not answered
            TypeRegistry reg = new TypeRegistry();
            
            foreach (Element dependency in Dependencies)
            {
                reg.RegisterSymbol(dependency.Name, ((Element) dependency).ExpressionResponse);
            }
            return reg;
        }
    }
}
