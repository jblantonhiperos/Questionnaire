using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Answer
    {
        public bool IsDelegated { get; set; }
        public bool IsSubmitted { get; set; }
        public float CalculatedScore { get; set; }
        public User Respondant { get; set; }
        public List<Response> Responses { get; set; }
        public List<string> Comment { get; set; }

    }
}
