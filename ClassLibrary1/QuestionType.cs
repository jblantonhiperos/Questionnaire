using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public interface IQuestionType
    {
        List<InputType> Inputs { get; set; }
        bool IsValid();
    }
}
