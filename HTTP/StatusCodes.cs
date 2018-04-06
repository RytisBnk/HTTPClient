using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Text.RegularExpressions;
using System.Reflection;

namespace HTTP
{
    public class StatusCodes
    {
        public static Dictionary<string, string> GetStatusCodesList()
        {
            var address = Assembly.GetExecutingAssembly().Location;
            var path = Path.GetDirectoryName(address);

            byte[] file = File.ReadAllBytes(path + "\\StatusCodes.json");
            string jsonString = Encoding.UTF8.GetString(file);
            Dictionary<string, string> statusCodes = JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonString);

            return statusCodes;
        }
    }
}
