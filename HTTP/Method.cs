using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

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

    public static class MethodResolver
    {
        public static Method Resolve(string methodName)
        {
            if (Regex.IsMatch(methodName, "[Gg][Ee][Tt]"))
            {
                return Method.GET;
            }
            else if (Regex.IsMatch(methodName, "[Pp][Oo][Ss][Tt]"))
            {
                return Method.POST;
            }
            else if (Regex.IsMatch(methodName, "[Pp][Uu][Tt]"))
            {
                return Method.PUT;
            }
            else if (Regex.IsMatch(methodName, "[Dd][Ee][Ll][Ee][Tt][Ee]"))
            {
                return Method.DELETE;
            }
            else if (Regex.IsMatch(methodName, "[Oo][Pp][Tt][Ii][Oo][Nn][Ss]"))
            {
                return Method.OPTIONS;
            }
            else if (Regex.IsMatch(methodName, "[Tt][Rr][Aa][Cc][Ee]"))
            {
                return Method.TRACE;
            }
            else throw new ArgumentException("Argument must be an HTTP method");
        }
    }
}
