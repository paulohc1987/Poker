using ConsolePoker.Utilidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsolePoker.Estrategia
{
    class Flush : EstrategiaPontuacao
    {
        public override float Pontuacao(List<Cartas> cartasJogador)
        {
            var maiorCarta = Util.MaiorValorCartaJogador(cartasJogador);
            float pontos = 0;

            switch (maiorCarta)
            {
                case 14:
                    pontos += 514;
                    break;
                case 13:
                    pontos += 513;
                    break;
                case 12:
                    pontos += 512;
                    break;
                case 11:
                    pontos += 511;
                    break;
                case 10:
                    pontos += 510;
                    break;
                case 9:
                    pontos += 509;
                    break;
                case 8:
                    pontos += 508;
                    break;
                case 7:
                    pontos += 507;
                    break;
                case 6:
                    pontos += 506;
                    break;
                case 5:
                    pontos += 505;
                    break;
                case 4:
                    pontos += 504;
                    break;
                case 3:
                    pontos += 503;
                    break;
                default:
                    pontos += 502;
                    break;
            }

            var segundaMaiorCarta = Util.SegundaValorCartaJogador(cartasJogador);

            switch (segundaMaiorCarta)
            {
                case 14:
                    pontos += 0.14F;
                    break;
                case 13:
                    pontos += 0.13F;
                    break;
                case 12:
                    pontos += 0.12F;
                    break;
                case 11:
                    pontos += 0.11F;
                    break;
                case 10:
                    pontos += 0.10F;
                    break;
                case 9:
                    pontos += 0.09F;
                    break;
                case 8:
                    pontos += 0.08F;
                    break;
                case 7:
                    pontos += 0.07F;
                    break;
                case 6:
                    pontos += 0.06F;
                    break;
                case 5:
                    pontos += 0.05F;
                    break;
                case 4:
                    pontos += 0.04F;
                    break;
                case 3:
                    pontos += 0.03F;
                    break;
                default:
                    pontos += 0.02F;
                    break;
            }

            return pontos;
        }
    }
}
