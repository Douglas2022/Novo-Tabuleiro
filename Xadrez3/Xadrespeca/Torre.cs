using Tabuleiro;
using Xadrez3.Tabuleiro;

namespace Xadrez3
{
    class Torre : Peca
    {
        public Torre(tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }
        public override string ToString()
        {
            return "T";
        }
    }
}
