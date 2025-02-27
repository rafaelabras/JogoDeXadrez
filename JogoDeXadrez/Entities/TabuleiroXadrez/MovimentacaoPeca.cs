using JogoDeXadrez.Entities.XadrezPecas;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDeXadrez.Entities.TabuleiroXadrez
{
    internal class MovimentacaoPeca
    {
        internal LogicaPecas LogicaPecas { get; set; }

        public MovimentacaoPeca()
        {

            /* Montar logica de captura aqui */



        }


        public bool MovimentacaoPeao(char[,] matriz, int numeroEntrar, int letraEntrar, int numeroSaida, int letraSaida) /* Letra = coluna,  Numero = linha */
      {
         
    
         if (numeroEntrar == 6 )
         {
            if (numeroSaida - numeroEntrar >= 2)
            {
                return false;
            }else{
                return true;
            }
            }
            else
            {
                if (numeroSaida - numeroEntrar > 1)
                {
                    return false;
                }
                else{
                    return true;
                }
         }

      }


    }
}
