using System;
using System.Collections.Generic;
using System.Text;

namespace ConsolePoker
{
    abstract class EstrategiaPontuacao
    {
        public abstract float Pontuacao(List<Cartas> cartasJogador);
    }
}
