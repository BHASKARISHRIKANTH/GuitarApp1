using ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ClassLibrary.Service
{
    public class Serializer
    {
        static string filepath = "Shrikanth.json";
        public static void Serialization(List<Guitar> guitars)
        {
            var json = JsonSerializer.Serialize(guitars);
            File.WriteAllText(filepath, json);

        }
        public static List<Guitar> Deserialize()
        {
            if (!File.Exists(filepath))
            {
                return new List<Guitar>();
            }
            var json = File.ReadAllText(filepath);
            return JsonSerializer.Deserialize<List<Guitar>>(json);
        }
    }
}

