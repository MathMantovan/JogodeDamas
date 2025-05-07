using Dama_console.jogo;
using tabuleiro;

namespace jogo
{
    class PartidaDeDamas
    {
        public Tabuleiro tab { get; private set; }
        public int turno{ get; private set; }
        public Cor jogadorAtual { get; private set; }
        public bool terminada {  get; private set; }
        public HashSet<Peca> capturadas{ get; private set; }

        public PartidaDeDamas()
        {
            this.tab = new Tabuleiro(8,8);
            this.turno = 1;
            this.jogadorAtual = Cor.Branca;
            this.terminada = false;
            capturadas = new HashSet<Peca>();
            colocarPecas();
        }

        public Peca executaMovimento(Posicao origem, Posicao destino)
        {
            Peca p = tab.retirarPeca(origem);
            Peca capturada = null;
            if (destino.linha - 2 == origem.linha || destino.linha + 2 == origem.linha)
            {
                capturada = tab.comerPeca(origem, destino);

            }
            tab.colocarPeca(p, destino);
            return capturada;
        }

        public void realizaJogada(Posicao origem, Posicao destino)
        {
            Peca capturada = executaMovimento(origem, destino);
            if (capturada != null) 
            { 
                capturadas.Add(capturada);
            }            
            turno++;
            mudaJogador();
        }


        private void mudaJogador()
        {
            if (jogadorAtual == Cor.Branca)
            {
                jogadorAtual = Cor.Azul;
            }
            else
            {
                jogadorAtual = Cor.Azul;

            }
        }

        private void colocarNovaPeca(Peca p, char coluna, int linha)
        {
            tab.colocarPeca(new PecaBranca(p.tab, p.cor), new PosicaoDamas(coluna, linha).toPosicao());
        }
        private void colocarPecas()
        {
            colocarNovaPeca(new PecaBranca(tab, Cor.Branca), 'a', 1);
            colocarNovaPeca(new PecaBranca(tab, Cor.Branca), 'a', 3);
            colocarNovaPeca(new PecaBranca(tab, Cor.Branca), 'b', 2);
            colocarNovaPeca(new PecaBranca(tab, Cor.Branca), 'c', 1);
            colocarNovaPeca(new PecaBranca(tab, Cor.Branca), 'c', 3);
            colocarNovaPeca(new PecaBranca(tab, Cor.Branca), 'd', 2);
            colocarNovaPeca(new PecaBranca(tab, Cor.Branca), 'e', 1);
            colocarNovaPeca(new PecaBranca(tab, Cor.Branca), 'e', 3);
            colocarNovaPeca(new PecaBranca(tab, Cor.Branca), 'f', 2);
            colocarNovaPeca(new PecaBranca(tab, Cor.Branca), 'g', 1);
            colocarNovaPeca(new PecaBranca(tab, Cor.Branca), 'g', 3);
            colocarNovaPeca(new PecaBranca(tab, Cor.Branca), 'h', 2);

            colocarNovaPeca(new PecaBranca(tab, Cor.Azul), 'h', 8);
            colocarNovaPeca(new PecaBranca(tab, Cor.Azul), 'h', 6);
            colocarNovaPeca(new PecaBranca(tab, Cor.Azul), 'g', 7);
            colocarNovaPeca(new PecaBranca(tab, Cor.Azul), 'f', 8);
            colocarNovaPeca(new PecaBranca(tab, Cor.Azul), 'f', 6);
            colocarNovaPeca(new PecaBranca(tab, Cor.Azul), 'e', 7);
            colocarNovaPeca(new PecaBranca(tab, Cor.Azul), 'd', 8);
            colocarNovaPeca(new PecaBranca(tab, Cor.Azul), 'd', 6);
            colocarNovaPeca(new PecaBranca(tab, Cor.Azul), 'c', 7);
            colocarNovaPeca(new PecaBranca(tab, Cor.Azul), 'b', 8);
            colocarNovaPeca(new PecaBranca(tab, Cor.Azul), 'b', 6);
            colocarNovaPeca(new PecaBranca(tab, Cor.Azul), 'a', 7);
        }




    }
}
