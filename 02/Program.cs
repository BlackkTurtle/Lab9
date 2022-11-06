using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var type = typeof(BlackBoxInteger);
            object blackBox = Activator.CreateInstance(type, true);
            while (true)
            {
                string[] str=Console.ReadLine().Split('_');
                if (str[0] != "End")
                {
                    string method = str[0];
                    object value = int.Parse(str[1]);
                    type.GetMethod(method, BindingFlags.NonPublic | BindingFlags.Instance).Invoke(blackBox, new[] { value });
                    Console.WriteLine(type.GetField("Value", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(blackBox));
                }
                else
                {
                    break;
                }
            }
        }
    }
}
