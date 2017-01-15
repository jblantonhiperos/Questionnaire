using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionnaireModels
{
    public abstract class Answer
    {
        //public bool IsDelegated { get; set; } NOT NEEDED BECAUSE OF UserLog
        public bool IsSubmitted { get; set; }
        public float CalculatedScore { get; set; } //Not sure if this is just part of an EvalAnswer or not
        public Dictionary<DateTime,User> UserLog { get; set; } // Allows for Delegation Tracking
        public Response Response { get; set; } // Don't need a list, a Response can hold a complex answer
        public List<string> Comment { get; set; }

    }
}
