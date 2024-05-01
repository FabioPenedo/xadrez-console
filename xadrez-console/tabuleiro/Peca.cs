namespace tabuleiro
{
    internal class Peca
    {
        public Posicao? Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QuantidedeMovimentos { get; set; }
        public Tabuleiro Tabuleiro { get; protected set; }

        public Peca(Cor cor, Tabuleiro tabuleiro)
        {
            this.Posicao = null;
            this.Cor = cor;
            this.QuantidedeMovimentos = 0;
            this.Tabuleiro = tabuleiro;
        }

        public void IncrementarQteMovimentos()
        {
            QuantidedeMovimentos++;
        }
    }
}
