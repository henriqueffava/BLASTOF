using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeros_Primos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int divisores = 0;

            Console.WriteLine("Informe um numero: ");
            numero = Convert.ToInt32(Console.ReadLine());   

            for (int i=1; i<=numero; i++)
            {
                if (numero % i == 0)
                    divisores++;
            }

            if (divisores == 2)
                Console.WriteLine("É um numero primo !");

            else
                Console.WriteLine("Não é um numero primo !");
            Console.ReadKey();
        } 
    }
}
