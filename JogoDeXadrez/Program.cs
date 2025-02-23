using JogoDeXadrez.Entities.TabuleiroXadrez;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            TabuleiroXadrez tabuleiro = new TabuleiroXadrez();
            tabuleiro.PrimeiroJogo();

            Console.ReadLine();


        }
    }
}