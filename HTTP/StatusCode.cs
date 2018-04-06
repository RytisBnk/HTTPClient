using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Text.RegularExpressions;

namespace HTTP
{
    public class StatusCode
    {
        public static void Test()
        {
            byte[] file = File.ReadAllBytes("StatusCodes.json");

            string jsonString = Encoding.UTF8.GetString(file);
            jsonString = jsonString.Replace("\r\n\t", "");
            Dictionary<string, string> statusCodes = JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonString);
        }
        
    }
}
