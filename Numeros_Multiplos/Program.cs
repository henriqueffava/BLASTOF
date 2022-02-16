using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeros_Multiplos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.Write("Informe o primeiro numero (a): ");
            a= Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe o segundo numero (b): ");
            b= Convert.ToInt32(Console.ReadLine());

            if (a % b == 0)
                {
                Console.WriteLine("O numero a: {0}, é multiplo do numero b: {1}", a, b);    
            }
            else
            {
                Console.WriteLine("O numero a: {0}, não é multiplo do numero b: {1}", a, b);
            }
            Console.ReadKey();
        }
    }
}
