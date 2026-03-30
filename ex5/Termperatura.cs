using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5
{
    internal class Termperatura
    {
        public float celsius()
        {
            Console.WriteLine("Insira uma temperatura em Celsius");
            float Celsius = float.Parse(Console.ReadLine());
            float Fahrenheit = Celsius * 9 / 5 + 32;
            Console.WriteLine(" Fahrenheit" +Fahrenheit);
            return Fahrenheit;
        }

    }
}
