using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_de_Combustivel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Distancia, Litros, media;
            


            Console.WriteLine("Digite a distancia em KM: ");
            Distancia = Convert.ToDouble(Console.ReadLine());
           
            Console.WriteLine("Digite quantos litros voce abasteceu seu veiculo: ");
            Litros = Convert.ToDouble(Console.ReadLine());

            media = (Distancia / Litros);

            Console.WriteLine("O seu veiculo esta percorrendo: " + media +"KM por litro"); 
            

            Console.ReadLine();

        }
    }
}
