using System;
using System.Collections.Generic;
using System.Text;
using ConsolePoker.Utilidades;

namespace ConsolePoker.Estrategia
{
    class StraightFlush : EstrategiaPontuacao
    {
        public override float Pontuacao(List<Cartas> cartasJogador)
        {
            byte valorMaior = Util.MaiorValorCartaJogador(cartasJogador);

            switch (valorMaior)
            {
                case 14:
                    return 814;
                case 13:
                    return 813;
                case 12:
                    return 812;
                case 11:
                    return 811;
                case 10:
                    return 810;
                case 9:
                    return 809;
                case 8:
                    return 808;
                case 7:
                    return 807;
                case 6:
                    return 806;
                case 5:
                    return 805;
                case 4:
                    return 804;
                case 3:
                    return 803;
                default:
                    return 802;
            }
        }
    }
}
