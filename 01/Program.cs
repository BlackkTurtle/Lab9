using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var type = typeof(HarvestingFields);
            while (true)
            {
                string str=Console.ReadLine();
                IEnumerable<FieldInfo> fields;
                if (str == "public")
                {
                    fields = type.GetFields(BindingFlags.Instance | BindingFlags.Public);
                }else if(str == "protected")
                {
                    fields = type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic).Where(field => field.IsFamily);
                }else if (str == "private")
                {
                    fields = type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic).Where(field => field.IsPrivate);
                }else if (str == "all")
                {
                    fields = type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
                }
                else
                {
                    break;
                }
                foreach (var fieldInfo in fields)
                {
                    string dostup = fieldInfo.Attributes.ToString().ToLower();
                    if (dostup == "family")
                        dostup = "protected";
                    Console.WriteLine(dostup+" "+ fieldInfo.FieldType.Name+" "+fieldInfo.Name);
                }
            }
        }
    }
}
