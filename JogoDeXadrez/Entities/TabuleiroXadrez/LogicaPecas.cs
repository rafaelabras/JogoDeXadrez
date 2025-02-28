using JogoDeXadrez.Entities.XadrezPecas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDeXadrez.Entities.TabuleiroXadrez
{
    internal class LogicaPecas
    {
        internal GeralPecas[] Peao { get; set; } = new Peao[16];
        internal GeralPecas[] Torre { get; set; } = new Torre[4];
        internal GeralPecas[] Cavalo { get; set; } = new Cavalo[4];
        internal GeralPecas[] Bispo { get; set; } = new Bispo[4];
        internal GeralPecas[] Dama { get; set; } = new Dama[2];
        internal GeralPecas[] Rei { get; set; } = new Rei[2];

        public LogicaPecas() { }
        public LogicaPecas(char[,] matriz)
        {

            /* Pecas do tabuleiro instanciadas */
            for (int i = 0; i < 16; i++)
            {
                Peao[i] = new Peao('P');
            }
            for (int i = 0; i < 4; i++)
            {
                Torre[i] = new Torre('T');
                Cavalo[i] = new Cavalo('C');
                Bispo[i] = new Bispo('B');
            }
            for (int i = 0; i < 2; i++)
            {
                Dama[i] = new Dama('D');
                Rei[i] = new Rei('R');
            }

            /* ------------------------------------- */
            
            
            /* Posicionando os PEOES no tabuleiro */
            for ( int i = 0;i < 8; i++)
            {
                matriz[6, i] = (Peao[i].Nome);
            }
            for (int i = 8, j = 0; i < 16 && j < 8; i++, j++)
            {
                matriz[1, j] = (Peao[i].Nome);
            }

            /* Posicionando as TORRES no tabuleiro */

            matriz[7, 0] = Torre[0].Nome;
            matriz[7, 7] = Torre[1].Nome;
            matriz[0, 0] = Torre[2].Nome;
            matriz[0, 7] = Torre[3].Nome;

            /* Posicionando os CAVALOS no tabuleiro */
            matriz[7, 1] = Cavalo[0].Nome;
            matriz[7, 6] = Cavalo[1].Nome;
            matriz[0, 1] = Cavalo[2].Nome;
            matriz[0, 6] = Cavalo[3].Nome;

            /* Posicionando os BISPOS no tabuleiro */

            matriz[7, 2] = Bispo[0].Nome;
            matriz[7, 5] = Bispo[1].Nome;
            matriz[0, 2] = Bispo[0].Nome;
            matriz[0, 5] = Bispo[1].Nome;

            /* Posicionando a DAMA no tabuleiro */

            matriz[7, 3] = Dama[0].Nome;
            matriz[0, 3] = Dama[0].Nome;

            /* Posicionando o REI no tabuleiro */

            matriz[7, 4] = Rei[0].Nome;
            matriz[0, 4] = Rei[0].Nome;

        }



    }
}
