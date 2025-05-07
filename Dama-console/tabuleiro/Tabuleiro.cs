namespace tabuleiro
{
    class Tabuleiro
    {
        public int linha { get; set; }
        public int coluna { get; set; }
        public Peca[,] pecas;

        public Tabuleiro(int linha, int coluna)
        {
            this.linha = linha;
            this.coluna = coluna;
            this.pecas = new Peca[linha, coluna];
        }

        public Peca peca(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }
        public Peca peca(Posicao pos)
        {
            return pecas[pos.linha, pos.coluna];
        }
        public bool existePeca(Posicao pos)
        {
            validarPosicao(pos);
            if (peca(pos) != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Peca comerPeca(Posicao origem, Posicao destino)
        {
            int linha = destino.linha - origem.linha;
            int coluna = destino.coluna - origem.coluna;
            Posicao PecaComida = new Posicao(0,0);
            Peca p;

            if (linha == -2)
            {
                if (coluna == -2)
                {
                    PecaComida.definirValores(origem.linha - 1, origem.coluna - 1);
                    p = retirarPeca(PecaComida);

                }
                else
                {
                    PecaComida.definirValores(origem.linha - 1, origem.coluna + 1);
                    p = retirarPeca(PecaComida);
                }
            }
            else
            {
                if (coluna == -2)
                {
                    PecaComida.definirValores(origem.linha + 1, origem.coluna - 1);
                    p = retirarPeca(PecaComida);
                }
                else
                {
                    PecaComida.definirValores(origem.linha + 1, origem.coluna + 1);
                    p = retirarPeca(PecaComida);
                }
            }
            return p;
            
        }

       
        

        public Peca retirarPeca(Posicao pos)
        {
            if (peca(pos) == null)
            {
                return null;
            }
            Peca aux = peca(pos);
            aux.posicao = null;
            pecas[pos.linha, pos.coluna] = null;
            return aux;
        }
        public void colocarPeca(Peca p, Posicao pos)
        {
            if (existePeca(pos))
            {
                throw new TabuleiroException("Ja existe peça nessa posição");
            }
            pecas[pos.linha, pos.coluna] = p;
            p.posicao = pos;
        }
        public bool posicaoValida(Posicao pos)
        {
            if (pos.linha < 0 || pos.linha >= linha || pos.coluna < 0 || pos.coluna >= coluna)
            {
                return false;
            }
            return true;
        }
        public void validarPosicao(Posicao pos)
        {
            if (!posicaoValida(pos))
            {
                throw new TabuleiroException("Posição invalida");
            }
        }
    }
}
