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
    internal class MovimentacaoPeca
    {
        internal LogicaPecas logicaPecas { get; set; }

        public MovimentacaoPeca(LogicaPecas logica)
        {
            logicaPecas = logica;



            
        }


        public bool MovimentacaoPeao(char[,] matriz, int numeroEntrar, int letraEntrar, int numeroSaida, int letraSaida) /* Letra = coluna,  Numero = linha */
      {

         if (numeroEntrar == 6 )
         {
                if (numeroSaida - numeroEntrar > 2) /* Logica do primeiro movimento do peao puder mover duas casas */
            {return false;}
                else
                {return true;}
            }   
            else {
                if (numeroSaida - numeroEntrar > 1)  /* Logica a partir do segundo movimento do peao em que ele podera mover apenas uma casa */
                {return false;}
                else{return true;}

                /* logica da captura apenas do peao */
                if (matriz[letraSaida, numeroSaida] != '_' && numeroSaida - numeroEntrar == 1  && letraSaida - letraEntrar == 1 || letraSaida - letraEntrar == -1)
               {
                    return true;
                }
                else {
                    return false;}
         }
      }
        public bool MovimentacaoTorre(char[,] matriz, int numeroEntrar, int letraEntrar, int numeroSaida, int letraSaida) /* Letra = coluna,  Numero = linha */
        {
           if (numeroSaida - numeroEntrar != 0 && letraEntrar == letraSaida)
            {
                return true;
            }if (numeroSaida - numeroEntrar == 0 && letraSaida != letraEntrar)
            {
                return true;
            }
            else { return false; }

        }

        public bool MovimentacaoCavalo(char[,] matriz, int numeroEntrar, int letraEntrar, int numeroSaida, int letraSaida)
        {
            if (numeroSaida - numeroEntrar == 2 || numeroSaida - numeroEntrar == -2 && letraSaida - letraEntrar == 1 || letraSaida - letraEntrar == -1)
            {
                return true;
            }
            else { if (numeroSaida - numeroEntrar == 1 || numeroSaida - numeroEntrar == -1 && letraSaida - letraEntrar == 2 || letraSaida - letraEntrar == -2)
                {
                    return true;
                }else { return false; }                 
        }
        }

        public bool MovimentacaoBispo(char[,] matriz, int numeroEntrar, int letraEntrar, int numeroSaida, int letraSaida)
        {
            int resultadoNumero = numeroSaida - numeroEntrar;
            int resultadoLetra = letraSaida - letraEntrar;

            if(resultadoLetra == resultadoNumero || resultadoLetra + resultadoNumero == 0)
            {
                return true;
            }
            else { return false; }

        }

        public bool MovimentacaoDama(char[,] matriz, int numeroEntrar, int letraEntrar, int numeroSaida, int letraSaida)
        {
            int resultadoNumero = numeroSaida - numeroEntrar;
            int resultadoLetra = letraSaida - letraEntrar;

            if (resultadoLetra == resultadoNumero || resultadoLetra + resultadoNumero == 0 || numeroSaida - numeroEntrar != 0 && letraEntrar == letraSaida || numeroSaida - numeroEntrar == 0 && letraSaida != letraEntrar)
            {
                return true;
            }
            else { return false; }


        }




    }
}
