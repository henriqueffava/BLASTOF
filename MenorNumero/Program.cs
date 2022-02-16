using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenorNumero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, menor = 0;

            Console.WriteLine("Determine o menor valor: ");
            Console.Write("Informe o primeiro valor: ");
            a = Convert.ToInt32(Console.ReadLine());
                menor = a;

            Console.Write("Informe o segundo valor: ");
            b = Convert.ToInt32(Console.ReadLine());
            if(b < menor)
            {
                menor = b;
                    }
            Console.Write("Informe o terceiro valor: ");
            c = Convert.ToInt32(Console.ReadLine());
            if (c < menor)
            {
                menor = c;
            }

            Console.WriteLine("O menor valor informado é: " + menor);
    
            Console.ReadLine ();    
        }
    }
}
