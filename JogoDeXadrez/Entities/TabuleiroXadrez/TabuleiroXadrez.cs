using JogoDeXadrez.Entities.XadrezPecas;
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
        internal char[,] Tabuleiro { get; set; } = new char[8, 8];
        internal int[] LinhaLateral { get; set; }
        internal char[] LinhaBaixo { get; set; }
        internal Posicao posicao { get; set; } = new Posicao();
        internal LogicaPecas logicaPecas { get; set; }
        internal MovimentacaoPeca movimentacaopeca { get; set; }
        
        public TabuleiroXadrez()
        {
            logicaPecas = new LogicaPecas(Tabuleiro);
            movimentacaopeca = new MovimentacaoPeca(logicaPecas);
            /*----------------------------------------   Inicio da representacao grafica do tabuleiro    ----------------------------------------*/

            for (int j = 0; j < 8; j++)
            {

                for (int i = 0; i < 8; i++)
                {

                    if (Tabuleiro[i, j] == '\0') /* O que e '\0' e por que ele esta nesse if? esse if foi criado como uma programacao defensiva pois o "logicaPecas = new LogicaPecas(Tabuleiro);" 
                                                  atribuiu valores ao tabuleiro, para nao substituir todos os valores com '_' vamos substituir todas casas vazias do vetores por '_', o valor PADRAO ao
                                                       inicializar um tipo primitivo char e '\0' e NAO "NULL". */
                    {
                        Tabuleiro[i, j] = (char)'_';
                    }

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

        public void RepresentacaoTabuleiro() /* Esse metodo foi criada pois, ao movimentar uma peca no tabuleiro ela precisa ser atualizada */
        {
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


            Console.Write("  ");
            for (int i = 0; i <= 7; i++)
            {
                LinhaBaixo[i] = (char)('a' + i);

                Console.Write(LinhaBaixo[i] + " ");
            }
        }




        public (int numero, int letra) EscolhaPeca() /* Tupla (Permite o retorno de dois valores em um metodo porem e diferente de um array.)*/
        {
            /*---------------------------------------- Inicio da logica de escolher uma peca  ----------------------------------------*/
            Console.Write("Qual peca em qual posicao voce deseja mover? (ex : a5): ");
            posicao.Input = Console.ReadLine();
            int numero;
            int letra;
            char[] escolhas = posicao.Input.ToCharArray();

            letra = char.ToUpper(escolhas[0]) - 'A';    /* Tecnica usada manipulando os valores UNICODE (ASCII) das letras para conseguir uma ordem numerica do valor da letra*/
            numero = 8 - ((int)char.GetNumericValue(escolhas[1])); 

            if (Tabuleiro[numero, letra] != '_')
            {
            return (numero, letra);
            }
            else { throw new ArgumentException("Insira uma posicao que contenha uma peca."); }
            /*---------------------------------------- Fim da logica de escolher uma peca  ----------------------------------------*/
        }

        public void MoverPeca((int numero, int letra) PecaEscolhida)
        {
            Console.Write("Qual o destino de sua peca? (ex : a7): ");
            posicao.Input = Console.ReadLine();
            int numero;
            int letra;
            char[] escolhas = posicao.Input.ToCharArray();
            letra = (char.ToUpper(escolhas[0]) - 'A');
            numero = 8 - ((int)char.GetNumericValue(escolhas[1]));

            if (Tabuleiro[numero, letra] == '_')
            {
                if (Tabuleiro[PecaEscolhida.numero, PecaEscolhida.letra] == 'P') /*           PEAO              */
                {
                    if ((movimentacaopeca.MovimentacaoPeao(Tabuleiro, PecaEscolhida.numero, PecaEscolhida.letra, numero, letra) == true))
                    {
                       
                        Tabuleiro[PecaEscolhida.numero, PecaEscolhida.letra] = '_';
                        Tabuleiro[numero, letra] = 'P';

                        Console.Clear();
                        RepresentacaoTabuleiro();
                    }
                }

                if (Tabuleiro[PecaEscolhida.numero, PecaEscolhida.letra] == 'T') /*           TORRE              */
                {
                    if ((movimentacaopeca.MovimentacaoTorre(Tabuleiro, PecaEscolhida.numero, PecaEscolhida.letra, numero, letra) == true))
                    {
                       

                        Tabuleiro[PecaEscolhida.numero, PecaEscolhida.letra] = '_';
                        Tabuleiro[numero, letra] = 'T';

                        Console.Clear();
                        RepresentacaoTabuleiro();
                    }
                }

                if (Tabuleiro[PecaEscolhida.numero, PecaEscolhida.letra] == 'C') /*           CAVALO              */
                {
                    if ((movimentacaopeca.MovimentacaoCavalo(Tabuleiro, PecaEscolhida.numero, PecaEscolhida.letra, numero, letra) == true))
                    {
                       

                        Tabuleiro[PecaEscolhida.numero, PecaEscolhida.letra] = '_';
                        Tabuleiro[numero, letra] = 'C';

                        Console.Clear();
                        RepresentacaoTabuleiro();
                    }
                }

                if (Tabuleiro[PecaEscolhida.numero, PecaEscolhida.letra] == 'B') /*           BISPO              */
                {
                    if ((movimentacaopeca.MovimentacaoBispo(Tabuleiro, PecaEscolhida.numero, PecaEscolhida.letra, numero, letra) == true))
                    {

                        Tabuleiro[PecaEscolhida.numero, PecaEscolhida.letra] = '_';
                        Tabuleiro[numero, letra] = 'B';

                        Console.Clear();
                        RepresentacaoTabuleiro();
                    }
                }

                if (Tabuleiro[PecaEscolhida.numero, PecaEscolhida.letra] == 'D') /*           DAMA              */
                {
                    if ((movimentacaopeca.MovimentacaoDama(Tabuleiro, PecaEscolhida.numero, PecaEscolhida.letra, numero, letra) == true))
                    {
                        
                        Tabuleiro[PecaEscolhida.numero, PecaEscolhida.letra] = '_';
                        Tabuleiro[numero, letra] = 'D';

                        Console.Clear();
                        RepresentacaoTabuleiro();
                    }
                }

                if (Tabuleiro[PecaEscolhida.numero, PecaEscolhida.letra] == 'R') /*           REI              */
                {
                    if ((movimentacaopeca.MovimentacaoRei(Tabuleiro, PecaEscolhida.numero, PecaEscolhida.letra, numero, letra) == true))
                    {

                        Tabuleiro[PecaEscolhida.numero, PecaEscolhida.letra] = '_';
                        Tabuleiro[numero, letra] = 'R';

                        Console.Clear();
                        RepresentacaoTabuleiro();
                    }
                }

            }
            else { throw new ArgumentException("Insira uma posicao valida."); }




        }









    }
}
