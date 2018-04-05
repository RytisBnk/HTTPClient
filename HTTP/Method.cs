using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTTP
{
    [Flags]
    public enum Method
    {
        GET,
        POST,
        PUT,
        DELETE, 
        OPTIONS,
        TRACE
    }
}
