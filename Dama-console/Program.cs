using Dama_console;
using tabuleiro;
using jogo;
using tabuleiro;
namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);
            try
            {
                PartidaDeDamas partida = new PartidaDeDamas();
                while (!partida.terminada)
                {
                    Console.Clear();
                    Tela.imprimirPartida(partida);
                    Console.WriteLine();
                    Console.WriteLine("Õrigem: ");
                    Posicao origem = Tela.lerPosicaoDamas().toPosicao();
                    Console.Clear();
                    bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);

                    Console.WriteLine();
                    Console.WriteLine("Destino: ");
                    Posicao destino = Tela.lerPosicaoDamas().toPosicao();

                    partida.realizaJogada(origem, destino);
                }

            }
            catch (TabuleiroException ex)
            {
                Console.WriteLine(ex.Message);
            }
           
            Console.ReadLine();

        }
    }
}