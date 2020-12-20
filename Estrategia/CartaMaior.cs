using ConsolePoker.Utilidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsolePoker.Estrategia
{
    class CartaMaior : EstrategiaPontuacao
    {
        public override float Pontuacao(List<Cartas> cartasJogador)
        {
            var maiorCarta = Util.MaiorValorCartaJogador(cartasJogador);
            float pontos = 0;

            switch (maiorCarta)
            {
                case 14:
                    pontos += 14;
                    break;
                case 13:
                    pontos += 13;
                    break;
                case 12:
                    pontos += 12;
                    break;
                case 11:
                    pontos += 11;
                    break;
                case 10:
                    pontos += 10;
                    break;
                case 9:
                    pontos += 9;
                    break;
                case 8:
                    pontos += 8;
                    break;
                case 7:
                    pontos += 7;
                    break;
                case 6:
                    pontos += 6;
                    break;
                case 5:
                    pontos += 5;
                    break;
                case 4:
                    pontos += 4;
                    break;
                case 3:
                    pontos += 3;
                    break;
                default:
                    pontos += 2;
                    break;
            }

            var segundaMaiorCarta = Util.SegundaValorCartaJogador(cartasJogador);

            switch (segundaMaiorCarta)
            {
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
