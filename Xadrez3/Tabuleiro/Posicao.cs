
namespace Tabuleiro
{
    class Posicao
    {
        private int v1;
        private int v2;

        public int Linha { get; set; }
        public int Coluna { get; set; }

        public Posicao(int linha,int coluna, char v)
        {
            Linha = linha;
            Coluna = coluna;
        }

        public Posicao(int v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        //public Posicao(object value)
        // {
        // }

        public override string ToString()
        {
            return Linha
                + ", "
                + Coluna;
        }
    } 
}
