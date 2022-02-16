using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> ListaA = new List<string>() { "1", "2", "3", "4" };
            List<string> ListaB = new List<string>() { "1", "2", "5", "8" };
            List<string> ListaAAndListaB = ListaA.Concat(ListaB).ToList();
            Console.Write("Concatenação da ListaA mais a ListaB: ");
            Console.WriteLine(String.Join(",", ListaAAndListaB));

            Console.ReadKey();
        }
    }

}
