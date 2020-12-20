using ConsolePoker.Utilidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsolePoker.Estrategia
{
    class Trinca : EstrategiaPontuacao
    {
        public override float Pontuacao(List<Cartas> cartasJogador)
        {
            var trinca = Util.TrincaDeQue(cartasJogador);
            float pontos = 0;

            switch (trinca)
            {
                case 14:
                    pontos += 314;
                    break;
                case 13:
                    pontos += 313;
                    break;
                case 12:
                    pontos += 312;
                    break;
                case 11:
                    pontos += 311;
                    break;
                case 10:
                    pontos += 310;
                    break;
                case 9:
                    pontos += 309;
                    break;
                case 8:
                    pontos += 308;
                    break;
                case 7:
                    pontos += 307;
                    break;
                case 6:
                    pontos += 306;
                    break;
                case 5:
                    pontos += 305;
                    break;
                case 4:
                    pontos += 304;
                    break;
                case 3:
                    pontos += 303;
                    break;
                default:
                    pontos += 302;
                    break;
            }

            var MaiorCartaNaoRepetida = Util.MaximoValorUnico(cartasJogador);

            switch (MaiorCartaNaoRepetida)
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
