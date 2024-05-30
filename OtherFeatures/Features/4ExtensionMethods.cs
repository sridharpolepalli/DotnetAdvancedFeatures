using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace OtherFeatures
{   
    public static class MyExtensions
    {
        public static int WordCount(this string str)
        {
            if (string.IsNullOrWhiteSpace(str))
                return 0;

            string[] words = str.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }


        public static string ToJson(this object obj, JsonSerializerOptions options = null)
        {
            if (obj == null)
            {
                return string.Empty;
            }

            return JsonSerializer.Serialize(obj, options);
        }
    }
}
