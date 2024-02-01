
using Xadrez3.Tabuleiro;

namespace Tabuleiro
{
    class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int QtdeMovimento { get; set; }
        public tabuleiro tab { get; set; }

        public Peca(Posicao posicao, tabuleiro tab, Cor cor)
        {
            this.posicao = posicao;
            this.tab = tab;
            this.cor = cor;
            this.QtdeMovimento = 0;
        }
    }
}
