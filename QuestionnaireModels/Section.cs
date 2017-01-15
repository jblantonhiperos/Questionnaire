using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QuestionnaireModels
{
    public class Section : Element
    {
        public IOrderedEnumerable<Element> Elements { get; set; }
    }
}