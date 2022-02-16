using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imprimir_lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] matrizI = new string[2, 2];
           

           matrizI[0,0] = "i1";
           matrizI[0,1] = "i2";
           matrizI[1,0] = "z1";
           matrizI[1,1] = "z2";

            string matriz = "";
            for (int linha = 0; linha < 2; linha++)
            {
                for(int coluna = 0; coluna < 2; coluna++)
                {
                    matriz += matrizI[linha, coluna] + " ";
                }
                Console.WriteLine(matriz);
                matriz = "";
            }
            Console.ReadKey();  
                
        }
    }
}
