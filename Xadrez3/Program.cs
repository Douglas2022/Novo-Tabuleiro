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
            PosicaoXadrez pos = new PosicaoXadrez('a', 1);

            Console.Write(pos);

            Console.WriteLine(pos.ToPosicao());

            Console.ReadLine();
        }
    }
}