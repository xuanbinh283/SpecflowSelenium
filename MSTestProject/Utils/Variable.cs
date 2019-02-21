using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace MSTestProject.Utils
{
    public static class Variable
    {
        private static IDictionary<string, string> _variables;

        public static string GetValue(string key)
        {
            // get the variable from json file if _variables is null
            if (_variables == null)
            {
                var jsonFilePath = $"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\\variables.json";
                using (StreamReader r = new StreamReader(jsonFilePath))
                {
                    var jsonStr = r.ReadToEnd();
                    if (!string.IsNullOrEmpty(jsonStr))
                    {
                        _variables = JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonStr);
                    }
                }
            }

            // Try to get the result in the static Dictionary
            string result;
            if (_variables.TryGetValue(key, out result))
            {
                return result;
            }
            else
            {
                return key;
            }
        }

    }
}
