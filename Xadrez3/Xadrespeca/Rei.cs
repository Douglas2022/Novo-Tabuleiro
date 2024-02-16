using Tabuleiro;
namespace Xadrez3.Tabuleiro
{
    class Rei : Peca
    {
        public Rei(tabuleiro tab, Cor cor) : base(tab, cor)
        {
            //me mostra onde ele pede a criação dessa 
        }
        public override string ToString()
        {
            return "R";
        }
    }
}