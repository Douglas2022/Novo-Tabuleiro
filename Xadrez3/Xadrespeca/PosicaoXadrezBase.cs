using Tabuleiro;

namespace Xadrez3.Xadrespeca
{
    class PosicaoXadrezBase
    {
        public char Coluna { get; set; }
        public int Linha { get; set; }

        public Posicao TPosicao()
        {
            return new Posicao('a' - Coluna, Linha - 8);
        }
    }
}