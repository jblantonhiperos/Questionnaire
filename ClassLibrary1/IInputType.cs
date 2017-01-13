using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public interface IInputType
    {
        string TypeName { get; set; }
        Settings Settings { get; set; }
        bool IsValid(object input);
        object GetExpressionResponse(List<Response> response);
    }
}
