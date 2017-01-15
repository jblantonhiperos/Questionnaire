using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.QuestionTypeSettings
{
    public class ShortTextSettings:ISettings
    {
        public string QuestionText { get; set; }
        public string Culture { get; set; }
    }
}
