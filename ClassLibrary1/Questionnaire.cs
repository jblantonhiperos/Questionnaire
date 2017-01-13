using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Questionnaire
    {
        public string Name { get; set; }
        public IOrderedEnumerable<Section> Sections { get; set; }
        public bool IsComplete { get; set; }
    }
}
