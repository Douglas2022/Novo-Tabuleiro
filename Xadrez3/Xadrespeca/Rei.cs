using Tabuleiro;
namespace Xadrez3.Tabuleiro
{
    class Rei : Peca
    {
        public Rei(tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }
        public override string ToString()
        {
            return "R";
        }
    }
}