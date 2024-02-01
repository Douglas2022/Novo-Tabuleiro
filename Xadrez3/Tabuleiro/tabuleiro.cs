using System;
using Tabuleiro;
namespace Xadrez3.Tabuleiro
{
    class tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas{ get; set; }

        private Peca[,] pecas;

        public tabuleiro(int Linhas, int Colunas)
        {
            this.Linhas = Linhas;
            this.Colunas = Colunas;
            pecas = new Peca[Linhas,Colunas];
        }

    }
   
}
