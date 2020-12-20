using System;
using System.Collections.Generic;
using System.Text;

namespace ConsolePoker
{
    class RoyalStraightFlush : EstrategiaPontuacao
    {
        public override float Pontuacao(List<Cartas> cartasJogador) 
        {
            return 914;
        }
    }
}
