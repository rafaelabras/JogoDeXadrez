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
        GeralPecas[] Peao { get; set; } = new Peao[8];
        GeralPecas[] Torre { get; set; } = new Torre[2];
        GeralPecas[] Cavalo { get; set; } = new Cavalo[2];
        GeralPecas[] Bispo { get; set; } = new Bispo[2];
        GeralPecas Dama { get; set; } = new Dama('D');
        GeralPecas Rei { get; set; } = new Rei('R');

        public LogicaPecas(int[,] matriz)
        {

            /* Pecas do tabuleiro instanciadas */
            for (int i = 0; i < 8; i++)
            {
                Peao[i] = new Peao('P');
            }
            for (int i = 0; i < 2; i++)
            {
                Torre[i] = new Torre('T');
                Cavalo[i] = new Cavalo('C');
                Bispo[i] = new Bispo('B');
            }
            /* ------------------------------------- */


            /* Posicionando os PEOES no tabuleiro */
            for ( int i = 0;i < 8; i++)
            {
                matriz[7, i] = Peao[i].Nome;
            }
            
            /* Posicionando as TORRES no tabuleiro */
            
            matriz[8, 1] = Torre[0].Nome;
            matriz[8, 8] = Torre[1].Nome;

            /* Posicionando os CAVALOS no tabuleiro */
            matriz[8, 2] = Cavalo[0].Nome;
            matriz[8, 7] = Cavalo[1].Nome;

            /* Posicionando os BISPOS no tabuleiro */

            matriz[8, 3] = Bispo[0].Nome;
            matriz[8, 6] = Bispo[1].Nome;

            /* Posicionando a DAMA no tabuleiro */

            matriz[8, 4] = Dama.Nome;

            /* Posicionando o REI no tabuleiro */

            matriz[8, 4] = Rei.Nome;


        }



    }
}
