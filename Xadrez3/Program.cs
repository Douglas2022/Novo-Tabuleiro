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

                while (!Partida.Terminada)
                {
                    Console.Clear();
                    Tela.ImprimirTabuleiro(Partida.tab);

                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao Origem = Tela.LerPosicaoXadrez().toPosicao();
                    Console.Write("Destino: ");
                    Posicao Destino = Tela.LerPosicaoXadrez().toPosicao();

                    Partida.ExecutaMovimento(Origem,Destino);
                }
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}