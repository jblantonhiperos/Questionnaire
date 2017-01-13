using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Element
    {
        public string Name { get; set; }
        public Expression ScoreExpression { get; set; }
        public Expression ConditionExpression { get; set; }
    }
}
