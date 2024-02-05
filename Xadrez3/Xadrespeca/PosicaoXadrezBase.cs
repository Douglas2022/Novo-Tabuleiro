using Tabuleiro;

namespace Xadrez3.Xadrespeca
{
    public class PosicaoXadrezBase
    {
        public Posicao ToPosicao()
        {
            return new Posicao('a' - coluna, linha - 8);
        }
    }
}