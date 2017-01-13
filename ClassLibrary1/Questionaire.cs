using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Questionaire
    {
        public string Name { get; set; }
        public IOrderedEnumerable<Section> Elements { get; set; }
        public bool IsComplete { get; set; }
    }
}
