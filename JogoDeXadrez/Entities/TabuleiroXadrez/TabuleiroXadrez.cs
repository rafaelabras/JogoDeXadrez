using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
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
        internal Posicao posicao { get; set; } = new Posicao();
        internal LogicaPecas logicaPecas { get; set; } = new LogicaPecas();
        
        public TabuleiroXadrez() {
         /*----------------------------------------   Inicio da representacao grafica do tabuleiro    ----------------------------------------*/
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
                for (int k = 0; k < 8; k++)
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
            
            /*---------------------------------------- Fim da representacao grafica do tabuleiro  ----------------------------------------*/

        }

        public (int numero, int letra) EscolherPeca() /* Tupla (Permite o retorno de dois valores em um metodo porem e diferente de um array.)*/
        {
            /*---------------------------------------- Inicio da logica de escolher uma peca  ----------------------------------------*/
            Console.Write("Qual peca em qual posicao voce deseja mover? (ex : a5): ");
            posicao.Input = Console.ReadLine();
            int numero;
            int letra;
            char[] escolhas = posicao.Input.ToCharArray();
            letra = (char.ToUpper(escolhas[0]) - 'A');    /* Tecnica usada manipulando os valores UNICODE (ASCII) das letras para conseguir uma ordem numerica do valor da letra*/

            numero = ((int)char.GetNumericValue(escolhas[1]) - 1); /* Verifica se o primeiro valor inserido e um numero   / OBS: E necessario reduzir 1,
                                                               * pois se o usuario escolher 1 (ou outro numero) ira se refererir a posicao 0 no vetor pois em C# arrays comecam na posicao 0. */

            int[,] PecaEscolhida = new int [numero, letra];
            return (numero, letra);
            /*---------------------------------------- Fim da logica de escolher uma peca  ----------------------------------------*/
        }

        public void MoverPeca((int numero, int letra) PecaEscolhida)
        {
            Console.Write("Qual o destino de sua peca? (ex : a7): ");
            int numero;
            int letra;
            char[] escolhas = posicao.Input.ToCharArray();
            letra = (char.ToUpper(escolhas[0]) - 'A');
            numero = ((int)char.GetNumericValue(escolhas[1]) - 1);

 

        }









    }
}
