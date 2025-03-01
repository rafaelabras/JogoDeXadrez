using JogoDeXadrez.Entities.XadrezPecas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDeXadrez.Entities.TabuleiroXadrez
{
    internal class MovimentacaoPeca
    {
        internal LogicaPecas logicaPecas { get; set; }

        public MovimentacaoPeca(LogicaPecas logica)
        {
            logicaPecas = logica;



            
        }


        public bool MovimentacaoPeao(char[,] matriz, int numeroEntrar, int letraEntrar, int numeroSaida, int letraSaida) /* Letra = coluna,  Numero = linha */
      {

            if (matriz[numeroEntrar, letraEntrar] == 'P')
            { if (numeroEntrar == 6)
                {
                    if (numeroSaida - numeroEntrar > 2) /* Logica do primeiro movimento do peao puder mover duas casas */
                    { return false; }
                    else
                    { return true; }
                }
                else { if (numeroSaida - numeroEntrar > 1) 
                    { return false; } 
                    else { return true; } }
            } else { throw new ArgumentException("A peca escolhida nao e um peao."); }

                /* logica da captura apenas do peao */
                if (matriz[letraSaida, numeroSaida] != '_' && numeroSaida - numeroEntrar == 1  && letraSaida - letraEntrar == 1 || letraSaida - letraEntrar == -1)
               {
                    return true;
                }
                else {
                    return false;}
         }
      

public bool MovimentacaoTorre(char[,] matriz, int numeroEntrar, int letraEntrar, int numeroSaida, int letraSaida) /* Letra = coluna,  Numero = linha */
        {
            if(matriz[numeroEntrar, letraEntrar] == 'T')
            {

           if (numeroSaida - numeroEntrar != 0 && letraEntrar == letraSaida)
            {
                return true;
            }if (numeroSaida - numeroEntrar == 0 && letraSaida != letraEntrar)
            {
                return true;
            }
            else { return false; }
            }else { throw new ArgumentException("A peca escolhida nao e uma torre."); }

        }

        public bool MovimentacaoCavalo(char[,] matriz, int numeroEntrar, int letraEntrar, int numeroSaida, int letraSaida)
        {
            if (matriz[numeroEntrar, letraEntrar] == 'C') { 

                if (numeroSaida - numeroEntrar == 2 || numeroSaida - numeroEntrar == -2 && letraSaida - letraEntrar == 1 || letraSaida - letraEntrar == -1)
            {
                return true;
            }
            else { if (numeroSaida - numeroEntrar == 1 || numeroSaida - numeroEntrar == -1 && letraSaida - letraEntrar == 2 || letraSaida - letraEntrar == -2)
                {
                    return true;
                }else { return false; }                 
        }
            }else { throw new ArgumentException("A peca escolhida nao e um cavalo."); }
        }

        public bool MovimentacaoBispo(char[,] matriz, int numeroEntrar, int letraEntrar, int numeroSaida, int letraSaida)
        {
            if (matriz[numeroEntrar, letraEntrar] == 'B')
            {
                int resultadoNumero = numeroSaida - numeroEntrar;
            int resultadoLetra = letraSaida - letraEntrar;

            if(resultadoLetra == resultadoNumero || resultadoLetra + resultadoNumero == 0)
            {
                return true;
            }
            else { return false; }
            } else { throw new ArgumentException("A peca escolhida nao e um bispo."); }

        }

        public bool MovimentacaoDama(char[,] matriz, int numeroEntrar, int letraEntrar, int numeroSaida, int letraSaida)
        {
            int resultadoNumero = numeroSaida - numeroEntrar;
            int resultadoLetra = letraSaida - letraEntrar;

            if (matriz[numeroEntrar, letraEntrar] == 'D')
            {

                if (resultadoLetra == resultadoNumero || resultadoLetra + resultadoNumero == 0 || numeroSaida - numeroEntrar != 0 && letraEntrar == letraSaida || numeroSaida - numeroEntrar == 0 && letraSaida != letraEntrar)
            {
                return true;
            }
            else { return false; }
            }else { throw new ArgumentException("A peca escolhida nao e uma dama."); }

        }

        public bool MovimentacaoRei(char[,] matriz, int numeroEntrar, int letraEntrar, int numeroSaida, int letraSaida)
        {
            if (matriz[numeroEntrar, letraEntrar] == 'R')
            {
             
            if ((Math.Abs(numeroSaida - numeroEntrar) <= 1) && (Math.Abs(letraSaida - letraEntrar) <= 1))
            {
                return true;
            }else { return false; }
            }else { throw new ArgumentException("A peca escolhida nao e um rei."); }
        }




    }
}
