using System.ComponentModel;
using System.Drawing;
using Dama_console.jogo;
using jogo;
using tabuleiro;

namespace Dama_console
{
    class Tela
    {
        public static void imprimirPartida(PartidaDeDamas partida)
        {
            imprimirTabuleiro(partida.tab);
            Console.WriteLine();
            imprimirCapturadas(partida);
            Console.WriteLine();
            Console.WriteLine("Turno: " + partida.turno);
            Console.WriteLine("Aguardando jogada do time " + partida.jogadorAtual.ToString());

        }

        public static void imprimirCapturadas(PartidaDeDamas partida)
        {
            Console.WriteLine("Peças capturadas: ");
            ConsoleColor aux = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Azul: ");
            Console.WriteLine(lerConjunto(partida.capturadas, Cor.Azul));           
            Console.ForegroundColor = aux;
            Console.Write("Branca: ");
            Console.Write(lerConjunto(partida.capturadas, Cor.Azul));

        }
        public static int lerConjunto(HashSet<Peca> capturadas, Cor cor)
        {
            return capturadas.Count(objt => objt.cor == cor);
        }
        public static void imprimirTabuleiro(Tabuleiro tab)
        {
            for (int i = 0; i < tab.linha; i++)
            {
                Console.Write(8 - i + " ");

                for (int j = 0; j < tab.coluna; j++)
                {
                    imprimirPeca(tab.peca(i, j));
                }
                Console.WriteLine();
            }
            Console.Write("  a b c d e f g h");


        }
        public static void imprimirTabuleiro(Tabuleiro tab, bool[,] posicoesPossiveis)
        {
            ConsoleColor fundoComun = Console.BackgroundColor;
            ConsoleColor fundoAlterado = ConsoleColor.DarkGray;

            for (int i = 0; i < tab.linha; i++)
            {
                Console.Write(8 - i + " ");

                for (int j = 0; j < tab.coluna; j++)
                {
                    if(posicoesPossiveis[i,j] == true)
                    {
                        Console.BackgroundColor = fundoAlterado;
                    }
                    else
                    {
                        Console.BackgroundColor = fundoComun;
                    }
                         imprimirPeca(tab.peca(i, j));
                }
                Console.WriteLine();
            }
            Console.Write("  a b c d e f g h");


        }

        public static PosicaoDamas lerPosicaoDamas()
        {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1] + "");
            return new PosicaoDamas(coluna, linha);
        }

        public static void imprimirPeca(Peca peca)
        {
            if (peca == null)
            {
                Console.Write("_ ");
            }
            else
            {
                if (peca.cor == Cor.Branca)
                {
                    Console.Write(peca);
                }
                else
                {
                    ConsoleColor aux = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(peca);
                    Console.ForegroundColor = aux;
                }
                Console.Write(" ");
            }
        }
    }
}
