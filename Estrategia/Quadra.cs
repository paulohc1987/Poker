using ConsolePoker.Utilidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsolePoker.Estrategia
{
    class Quadra : EstrategiaPontuacao
    {
        public override float Pontuacao(List<Cartas> cartasJogador)
        {
            var quadra = Util.QuadraDeQue(cartasJogador);

            switch (quadra)
            {
                case 14:
                    return 714;
                case 13:
                    return 713;
                case 12:
                    return 712;
                case 11:
                    return 711;
                case 10:
                    return 710;
                case 9:
                    return 709;
                case 8:
                    return 708;
                case 7:
                    return 707;
                case 6:
                    return 706;
                case 5:
                    return 705;
                case 4:
                    return 704;
                case 3:
                    return 703;
                default:
                    return 702;
            }
        }
    }
}
