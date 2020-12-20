using ConsolePoker.Utilidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsolePoker.Estrategia
{
    class FullHouse : EstrategiaPontuacao
    {
        public override float Pontuacao(List<Cartas> cartasJogador)
        {
            var trinca = Util.TrincaDeQue(cartasJogador);
            float pontos = 0;

            switch (trinca)
            {
                case 14:
                    pontos += 614;
                    break;
                case 13:
                    pontos += 613;
                    break;
                case 12:
                    pontos += 612;
                    break;
                case 11:
                    pontos += 611;
                    break;
                case 10:
                    pontos += 610;
                    break;
                case 9:
                    pontos += 609;
                    break;
                case 8:
                    pontos += 608;
                    break;
                case 7:
                    pontos +=  607;
                    break;
                case 6:
                    pontos += 606;
                    break;
                case 5:
                    pontos +=  605;
                    break;
                case 4:
                    pontos +=  604;
                    break;
                case 3:
                    pontos += 603;
                    break;
                default:
                    pontos += 602;
                    break;
            }

            var par = Util.ParDeQue(cartasJogador);

            switch (par)
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
