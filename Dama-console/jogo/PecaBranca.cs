using tabuleiro;
namespace jogo
{
    class PecaBranca : Peca
    {
        public PecaBranca(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
        }

        public override string ToString()
        {
            return "0";
        }
        private bool existeInimigo(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p != null && p.cor != cor;
        }



        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tab.linha, tab.coluna];

            Posicao posi = new Posicao(0, 0);

            //peças brancas
            if (cor == Cor.Branca)
            {
                posi.definirValores(posicao.linha - 1, posicao.coluna + 1);
                if (tab.posicaoValida(posi))
                {
                    if (tab.existePeca(posi))
                    {
                        if (existeInimigo(posi))
                        {
                            posi.definirValores(posicao.linha - 2, posicao.coluna + 2);
                            if (!tab.existePeca(posi))
                            {
                                mat[posi.linha, posi.coluna] = true;
                            }
                        }
                    }
                    else
                    {
                        mat[posi.linha, posi.coluna] = true;
                    }
                }

                posi.definirValores(posicao.linha - 1, posicao.coluna - 1);
                if (tab.posicaoValida(posi))
                {
                    if (tab.existePeca(posi))
                    {
                        if (existeInimigo(posi))
                        {
                            posi.definirValores(posicao.linha - 2, posicao.coluna - 2);
                            if (!tab.existePeca(posi))
                            {
                                mat[posi.linha, posi.coluna] = true;
                            }
                        }
                    }
                    else
                    {
                        mat[posi.linha, posi.coluna] = true;
                    }
                }


                posi.definirValores(posicao.linha + 1, posicao.coluna - 1);
                if (tab.posicaoValida(posi))
                {
                    if (tab.existePeca(posi))
                    {
                        if (existeInimigo(posi))
                        {
                            posi.definirValores(posicao.linha + 2, posicao.coluna - 2);
                            if (!tab.existePeca(posi))
                            {
                                mat[posi.linha, posi.coluna] = true;
                            }
                        }
                    }
                }
                posi.definirValores(posicao.linha + 1, posicao.coluna + 1);
                if (tab.posicaoValida(posi))
                {
                    if (tab.existePeca(posi))
                    {
                        if (existeInimigo(posi))
                        {
                            posi.definirValores(posicao.linha + 2, posicao.coluna + 2);
                            if (!tab.existePeca(posi))
                            {
                                mat[posi.linha, posi.coluna] = true;
                            }
                        }
                    }
                }
            }
            //peças pretas
            else
            {
                posi.definirValores(posicao.linha + 1, posicao.coluna + 1);
                if (tab.posicaoValida(posi))
                {
                    if (tab.existePeca(posi))
                    {
                        if (existeInimigo(posi))
                        {
                            posi.definirValores(posicao.linha + 2, posicao.coluna + 2);
                            if (!tab.existePeca(posi))
                            {
                                mat[posi.linha, posi.coluna] = true;
                            }
                        }
                    }
                    else
                    {
                        mat[posi.linha, posi.coluna] = true;
                    }
                }

                posi.definirValores(posicao.linha + 1, posicao.coluna - 1);
                if (tab.posicaoValida(posi))
                {
                    if (tab.existePeca(posi))
                    {
                        if (existeInimigo(posi))
                        {
                            posi.definirValores(posicao.linha + 2, posicao.coluna - 2);
                            if (!tab.existePeca(posi))
                            {
                                mat[posi.linha, posi.coluna] = true;
                            }
                        }
                    }
                    else
                    {
                        mat[posi.linha, posi.coluna] = true;
                    }
                }


                posi.definirValores(posicao.linha - 1, posicao.coluna - 1);
                if (tab.posicaoValida(posi))
                {
                    if (tab.existePeca(posi))
                    {
                        if (existeInimigo(posi))
                        {
                            posi.definirValores(posicao.linha - 2, posicao.coluna - 2);
                            if (!tab.existePeca(posi))
                            {
                                mat[posi.linha, posi.coluna] = true;
                            }
                        }
                    }
                }

                posi.definirValores(posicao.linha - 1, posicao.coluna + 1);
                if (tab.posicaoValida(posi))
                {
                    if (tab.existePeca(posi))
                    {
                        if (existeInimigo(posi))
                        {
                            posi.definirValores(posicao.linha - 2, posicao.coluna + 2);
                            if (!tab.existePeca(posi))
                            {
                                mat[posi.linha, posi.coluna] = true;
                            }
                        }
                    }
                }
            }
                return mat;
        }
    }
}
