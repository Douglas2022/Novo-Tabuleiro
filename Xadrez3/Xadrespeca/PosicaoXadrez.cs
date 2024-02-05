﻿using Tabuleiro;
namespace Xadrez3
{
    public class PosicaoXadrez 
    {
        public char coluna { get; set; }
        public int linha { get; set; }

        public PosicaoXadrez(char coluna,int linha)
        {
            this.coluna = coluna;   
            this.linha = linha;
        }
        public Posicao ToPosicao()
        {
            return new Posicao('a' - coluna, linha - 8);
        }
       
        public override string ToString()
        {
            return "" + coluna + linha;
        }
    }
}