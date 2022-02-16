using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tempo_da_Partida
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double inicio, fim, tempo;

            Console.WriteLine("Digite o horario de inicio da partida: ");
            inicio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o horario final da partida: ");
            fim = Convert.ToDouble(Console.ReadLine());

               tempo = fim - inicio;
            Console.WriteLine("A partida durou: " +tempo +"horas");  

            Console.ReadKey();  
        }
    }
}
