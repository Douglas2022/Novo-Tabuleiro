using System;
using System.Runtime.ConstrainedExecution;
using Tabuleiro;
using Xadrez3.Tabuleiro;

namespace Xadrez3.Xadrespeca
{
    class PartidaDeXadrez
    {
        public tabuleiro tab { get; set; }
        private int turno;
        private  Cor JogadorAtual;
       // private int a;

        public PartidaDeXadrez()

        {
            tab = new tabuleiro(8,8);
            turno = 1;
            JogadorAtual =  Cor.Branca;
            ColocarPeca();
        }
        public void ExecutaMovimento(Posicao origem,Posicao destino)
        {
            Peca p = tab.RetirarPeca(origem);
            p.IncrementarQtdeMovimentos();
            Peca pecaCapturada = tab.RetirarPeca(destino);
            tab.ColocarPeca(p, destino);
        }
        private void ColocarPeca()
        {
            tab.ColocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrez('c', 1).toPosicao());

            

        }
    }
}
