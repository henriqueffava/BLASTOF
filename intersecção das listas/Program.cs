using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor1 = new int[] { 1, 2, 3, 3 };
            int[] vetor2 = new int[] { 1, 2, 5, 8 };

            StringBuilder builderInterseccao = new StringBuilder("Interseccção: ");

            for (int i = 0; i < vetor1.Length; i++)
            {
                

                var list = (from b in vetor1
                            where vetor1[i] == vetor2[i]
                            select vetor1[i]).FirstOrDefault();
                if (list > 0)
                {
                    builderInterseccao.Append(list).Append(" ");
                }
            }
            Console.WriteLine(builderInterseccao);
            Console.ReadKey();
        }
    }
}
