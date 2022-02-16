using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palavra_Palindromo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string palavra, inverso, caractere;
            int i;
            Console.WriteLine("Informe a palavra que deseja saber se é um Palindromo: ");
            palavra = Convert.ToString(Console.ReadLine());
            i = palavra.Length;
            inverso = "";
            for(int x=i-1; x>=0; x--)
            {
                caractere = palavra.Substring(x, 1);
                inverso = inverso + caractere;
                           }
            Console.WriteLine("inverso da palavra: ");
            Console.WriteLine(inverso);
            if (palavra == inverso)
            {
                Console.WriteLine(" É palindromo !");

            }
            else
            {
                Console.WriteLine("Não é palindromo !");

            }

            Console.ReadKey();
        }
    }
}
