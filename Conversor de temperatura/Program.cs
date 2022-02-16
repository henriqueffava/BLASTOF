using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor_de_temperatura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double f = 0;
            double c = 0;

            Console.Write("Entre com a temperatura na escala Celcius ");
            f = double.Parse(Console.ReadLine());

            c = (double) 5 / 9 * (f - 32);

            Console.Write("A temperatura convertida para Fahrenheit é: " + c);

            Console.ReadKey();  
                


        }
    }
}
