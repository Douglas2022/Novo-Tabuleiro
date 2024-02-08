using Xadrez3.Tabuleiro;
namespace Tabuleiro
{
    class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int QtdeMovimento { get; protected set; }
        public tabuleiro tab { get; protected set; }

        public Peca(Posicao posicao,tabuleiro tab, Cor cor)
        {
            this.posicao = null;
            this.tab = tab;
            this.cor = cor;
            this.QtdeMovimento = 0;
        }
    }
}
