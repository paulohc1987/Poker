using ConsolePoker.Estrategia;
using ConsolePoker.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using static ConsolePoker.Validacao;

namespace ConsolePoker
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<string> ListEntrada = new List<string>();
                EntradaDados(ListEntrada);
                Console.WriteLine();

                foreach (var item in ListEntrada)
                {
                    if (Erro.Nenhum != Validacao.TemErros(item))
                        continue;

                    var valoresCartas = item.Split(' ');

                    List<Cartas> cartasBlack = new List<Cartas>();
                    List<Cartas> cartasWhite = new List<Cartas>();

                    SetandoCartasBlack(valoresCartas, cartasBlack);
                    SetandoCartasWhite(valoresCartas, cartasWhite);

                    cartasBlack.OrderBy(x => x.Valor);
                    cartasWhite.OrderBy(x => x.Valor);

                    float pontuacaoJogadorBlack = RetornaPontuacao(cartasBlack);
                    float pontuacaoJogadorWhite = RetornaPontuacao(cartasWhite);

                    if (pontuacaoJogadorBlack > pontuacaoJogadorWhite)
                        Console.WriteLine("Black wins.");
                    else
                    if (pontuacaoJogadorBlack < pontuacaoJogadorWhite)
                        Console.WriteLine("White wins.");
                    else
                        Console.WriteLine("Tie.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro inesperado que deve ser identificado e criado uma regra de validação para o mesmo", ex.StackTrace, ex.Message);
            }
        }

        private static float RetornaPontuacao(List<Cartas> listaCartajogador)
        {
            var listaOrdenadaJogador = Util.OdernarLista(listaCartajogador);

            if (Util.ExisteSequenciaCartas(listaOrdenadaJogador) && Util.MesmoNaipe(listaCartajogador) && Util.MaiorValorCartaJogador(listaCartajogador) == 14)
            {
                RoyalStraightFlush royalStraightFlush = new RoyalStraightFlush();
                return royalStraightFlush.Pontuacao(listaCartajogador);
            }
            else
              if (Util.ExisteSequenciaCartas(listaOrdenadaJogador) && Util.MesmoNaipe(listaCartajogador))
            {
                StraightFlush StraightFlush = new StraightFlush();
                return StraightFlush.Pontuacao(listaCartajogador);
            }
            else
              if (Util.TemQuadra(listaCartajogador))
            {
                Quadra quadra = new Quadra();
                return quadra.Pontuacao(listaCartajogador);
            }
            else
              if (Util.TemTrinca(listaCartajogador) && Util.TemPar(listaCartajogador))
            {
                FullHouse fullHouse = new FullHouse();
                return fullHouse.Pontuacao(listaCartajogador);
            }
            else
            if (Util.MesmoNaipe(listaCartajogador))
            {
                Flush flush = new Flush();
                return flush.Pontuacao(listaCartajogador);
            }
            else
            if (Util.ExisteSequenciaCartas(listaOrdenadaJogador))
            {
                Straight straight = new Straight();
                return straight.Pontuacao(listaCartajogador);
            }
            else
            if (Util.TemTrinca(listaOrdenadaJogador))
            {
                Trinca trinca = new Trinca();
                return trinca.Pontuacao(listaCartajogador);
            }
            else
            if (Util.TemDoisPares(listaOrdenadaJogador))
            {
                DoisPares doisPares = new DoisPares();
                return doisPares.Pontuacao(listaCartajogador);
            }
            else
              if (Util.TemPar(listaCartajogador))
            {
                UmPar umPar = new UmPar();
                return umPar.Pontuacao(listaCartajogador);
            }
            else
            {
                CartaMaior cartaMaior = new CartaMaior();
                return cartaMaior.Pontuacao(listaCartajogador);
            }
        }

        private static void SetandoCartasBlack(string[] valoresCartas, List<Cartas> cartasBlack)
        {
            for (int i = 0; i < 5; i++)
            {

                Cartas carta = new Cartas();
                if (!valoresCartas[i].Contains("10"))
                {
                    carta.Carta = valoresCartas[i][0].ToString();
                    carta.Valor = Convert.ToByte(valoresCartas[i][0].ToString().Replace("J", "11").Replace("Q", "12").Replace("K", "13").Replace("A", "14"));
                    carta.Naipe = valoresCartas[i][1];
                }
                else
                {
                    carta.Carta = "10";
                    carta.Valor = 10;
                    carta.Naipe = valoresCartas[i][2];
                }

                cartasBlack.Add(carta);
            }

        }

        private static void SetandoCartasWhite(string[] valoresCartas, List<Cartas> cartasWhite)
        {
            for (int i = 5; i < 10; i++)
            {

                Cartas carta = new Cartas();
                if (!valoresCartas[i].Contains("10"))
                {
                    carta.Carta = valoresCartas[i][0].ToString();
                    carta.Valor = Convert.ToByte(valoresCartas[i][0].ToString().Replace("J", "11").Replace("Q", "12").Replace("K", "13").Replace("A", "14"));
                    carta.Naipe = valoresCartas[i][1];
                }
                else
                {
                    carta.Carta = "10";
                    carta.Valor = 10;
                    carta.Naipe = valoresCartas[i][2];
                }

                cartasWhite.Add(carta);
            }

        }

        private static void EntradaDados(List<string> ListEntrada)
        {
            string novaLinha = string.Empty;
            do
            {
                Console.WriteLine("Favor informar uma linha com as 10 cartas dos 2 jogadores Black e White nesta ordem");
                string entrada = Console.ReadLine();
                ListEntrada.Add(entrada.ToUpper());
                Console.WriteLine("\nDeseja informa uma nova linha de cartas, digite 'S' ou 's' para sim ou qualquer outra tecla para não");
                novaLinha = Console.ReadLine();
            } while (novaLinha.ToUpper().Equals("S"));
        }
    }
}
