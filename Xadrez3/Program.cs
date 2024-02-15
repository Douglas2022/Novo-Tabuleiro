using System;
using Tabuleiro;
using Xadrez3.Tabuleiro;
using Xadrez3.Xadrespeca;

namespace Xadrez3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
               PartidaDeXadrez Partida = new PartidaDeXadrez();
                Tela.ImprimirTabuleiro(Partida.tab);

            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}