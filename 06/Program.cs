using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] str=Console.ReadLine().Split(' ');
            TrafficLight[] trafficLights = new TrafficLight[str.Length];
            for (int i = 0; i < 3; i++)
            {
                trafficLights[i] = new TrafficLight((Color)Enum.Parse(typeof(Color),str[i]));
            }
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                foreach (var trafficLight in trafficLights)
                {
                    trafficLight.ChangeColor();
                }
                Console.WriteLine(string.Join(" ", trafficLights.Select(l => l.ToString())));
            }
            Console.ReadLine();
        }
    }
}
