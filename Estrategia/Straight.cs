using ConsolePoker.Utilidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsolePoker.Estrategia
{
    class Straight : EstrategiaPontuacao
    {
        public override float Pontuacao(List<Cartas> cartasJogador)
        {
            var maiorCarta = Util.MaiorValorCartaJogador(cartasJogador);

            switch (maiorCarta)
            {
                case 14:
                    return 414;
                case 13:
                    return 413;
                case 12:
                    return 412;
                case 11:
                    return 411;
                case 10:
                    return 410;
                case 9:
                    return 409;
                case 8:
                    return 408;
                case 7:
                    return 407;
                case 6:
                    return 406;
                case 5:
                    return 405;
                case 4:
                    return 404;
                case 3:
                    return 403;
                default:
                    return 402;
            }
        }
    }
}
