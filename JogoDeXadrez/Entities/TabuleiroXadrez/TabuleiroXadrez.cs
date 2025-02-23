using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDeXadrez.Entities.TabuleiroXadrez
{
    internal class TabuleiroXadrez
    {
        internal int[,] Tabuleiro { get; set; }
        internal int[] LinhaLateral { get; set; }
        internal char[] LinhaBaixo { get; set; }

        public TabuleiroXadrez() {
        }
        public void PrimeiroJogo()
        {
            Tabuleiro = new int[8, 8];
            for (int j = 0; j < 8; j++)
            {

                for (int i = 0; i < 8; i++)
                {
                    Tabuleiro[i, j] = (char)'_';
                }
            }


            LinhaLateral = new int[8];

            for (int i = 7, j = 0; i >= 0; i--, j++) 
            {
                LinhaLateral[i] = i + 1;
                Console.Write(LinhaLateral[i]);
                for (int  k = 0; k < 8; k++)
                { 
                    Console.Write(" " + (char)Tabuleiro[j, k]);
                }
                Console.WriteLine();
            }


            LinhaBaixo = new char[8];
            Console.Write("  ");
            for (int i = 0; i <= 7; i++)
            {
                LinhaBaixo[i] = (char)('a' + i);

                Console.Write(LinhaBaixo[i] + " ");
            }



        }
    }
}
