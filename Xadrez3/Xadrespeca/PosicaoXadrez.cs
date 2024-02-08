using Tabuleiro;
namespace Xadrez3
{
    class PosicaoXadrez
    {
        public char Coluna { get; set; }
        public int Linha { get; set; }

        public PosicaoXadrez(char coluna, int linha)
        {
            this.Coluna = coluna;
            this.Linha = linha;
        }
        public Posicao ToPosicao()
        {
            return new Posicao('a' - Coluna, Linha - 8);
        }

        public override string ToString()
        {
            return "" + Coluna + Linha;
        }
    }
}
