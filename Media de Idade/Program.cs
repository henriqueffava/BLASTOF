using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaDeIdade

{
    internal class Program
    {
        static void Main(string[] args)
        {
            double idadeI, idadeJ, idadeK, idadeX, idadeY, media;

            Console.WriteLine("Digite a idade de I: ");
            idadeI = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a idade de J: ");
            idadeJ = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a idade de K: ");
            idadeK = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a idade de X: ");
            idadeX = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a idade de Y: ");
            idadeY = Convert.ToDouble(Console.ReadLine());


            media = (idadeI + idadeJ + idadeK + idadeX + idadeY) / 5;
            Console.WriteLine("A media de idade é de: " + media);

            Console.ReadLine();

        }
    }
}
