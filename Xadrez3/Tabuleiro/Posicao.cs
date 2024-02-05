
namespace Tabuleiro
{
    class Posicao
    {
        public int Linha { get; set; }
        public int Coluna { get; set; }

        public Posicao(int linha,int coluna)
        {
            Linha = linha;
            Coluna = coluna;
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
