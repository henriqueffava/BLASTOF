using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int multiplicando;

            Console.Write("Informe o numero que deseja saber a tabuada: ");
            multiplicando = Convert.ToInt32(Console.ReadLine());

            for (int multiplicador = 0; multiplicador <= 10; multiplicador++)
            {
                Console.WriteLine(string.Format("{0}*{1}={2}", multiplicando, multiplicador, multiplicando * multiplicador));

            } Console.ReadKey();    

        }
    }
}
