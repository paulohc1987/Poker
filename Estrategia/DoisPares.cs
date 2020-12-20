using ConsolePoker.Utilidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsolePoker.Estrategia
{
    class DoisPares : EstrategiaPontuacao
    {
        public override float Pontuacao(List<Cartas> cartasJogador)
        {
            var ParMaior = Util.valorMaximoDosPares(cartasJogador);
            float pontos = 0;

            switch (ParMaior)
            {
                case 14:
                    pontos += 214;
                    break;
                case 13:
                    pontos += 213;
                    break;
                case 12:
                    pontos += 212;
                    break;
                case 11:
                    pontos += 211;
                    break;
                case 10:
                    pontos += 210;
                    break;
                case 9:
                    pontos += 209;
                    break;
                case 8:
                    pontos += 208;
                    break;
                case 7:
                    pontos += 207;
                    break;
                case 6:
                    pontos += 206;
                    break;
                case 5:
                    pontos += 205;
                    break;
                case 4:
                    pontos += 204;
                    break;
                case 3:
                    pontos += 203;
                    break;
                default:
                    pontos += 202;
                    break;
            }

            var ParMenor = Util.valorMinimoDosPares(cartasJogador);

            switch (ParMenor)
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
