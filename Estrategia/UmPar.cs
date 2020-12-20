using ConsolePoker.Utilidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsolePoker.Estrategia
{
    class UmPar : EstrategiaPontuacao
    {
        public override float Pontuacao(List<Cartas> cartasJogador)
        {
            var valorPar = Util.ParDeQue(cartasJogador);
            float pontos = 0;

            switch (valorPar)
            {
                case 14:
                    pontos += 114;
                    break;
                case 13:
                    pontos += 113;
                    break;
                case 12:
                    pontos += 112;
                    break;
                case 11:
                    pontos += 111;
                    break;
                case 10:
                    pontos += 110;
                    break;
                case 9:
                    pontos += 109;
                    break;
                case 8:
                    pontos += 108;
                    break;
                case 7:
                    pontos += 107;
                    break;
                case 6:
                    pontos += 106;
                    break;
                case 5:
                    pontos += 105;
                    break;
                case 4:
                    pontos += 104;
                    break;
                case 3:
                    pontos += 103;
                    break;
                default:
                    pontos += 102;
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
