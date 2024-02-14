using System;
using Tabuleiro;
namespace Xadrez3
{
    class PosicaoXadrez
    {
       // private int coluna;

        public char Coluna { get; set; }
        public int Linha { get; set; }

        public PosicaoXadrez(char coluna, int linha)
        {
            this.Coluna = coluna;
            this.Linha = linha;
        }
       // public Posicao ToPosicao(char v) => new Posicao(8 - Linha, Coluna - 'a');

        public override string ToString()
        {
            return "" + Coluna + Linha;
        }

        //internal object ToPosicao()
       // {
          //  throw new NotImplementedException();
       // }
    }
}
