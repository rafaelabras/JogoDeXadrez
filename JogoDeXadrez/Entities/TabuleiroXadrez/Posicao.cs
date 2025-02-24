using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDeXadrez.Entities.TabuleiroXadrez
{
    internal class Posicao
    {
        private char[] Coluna { get; set; }
        private int[] Linha { get; set; }
        public string Input { get; set; }

        public Posicao() {
            Coluna = new char[8];
            Linha = new int[8];
            for (int i = 0, j = 1; i <= 7; i++, j++)
            {
                Linha[i] = j;
            }

            for (int i = 0; i <= 7; i++)
            {
                Coluna[i] = (char)('a' + i);
            }

        }
        


    }
}
