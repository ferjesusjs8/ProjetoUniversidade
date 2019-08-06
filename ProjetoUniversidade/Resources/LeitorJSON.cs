using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace ProjetoUniversidade.Resources
{
    public class LeitorJSON<T>
    {
        public static List<T> LerJson(string path)
        {
            var f = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
            using (StreamReader reader = new StreamReader(f + "/Resources/" + path))
            {
                string json = reader.ReadToEnd();
                List<T> items = JsonConvert.DeserializeObject<List<T>>(json);
                return items;
            }
        }
    }
}