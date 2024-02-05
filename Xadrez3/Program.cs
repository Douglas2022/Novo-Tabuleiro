﻿using System;
using Tabuleiro;
using Xadrez3.Tabuleiro;
namespace Xadrez3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                tabuleiro tab = new tabuleiro(8, 8);

                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 2));

                Tela.ImprimirTabuleiro(tab);

                Console.ReadLine();
            }
            catch (Exception ex)
            {
                {
                    Console.Write(ex.Message);
                }
                Console.ReadLine();
            }
        }
    }
}
