using System;
using System.Collections.Generic;
using System.Text;

namespace ConsolePoker
{
    public static class Validacao
    {
        public static Erro TemErros(string DadosEntrada)
        {
            var valoresCartas = DadosEntrada.Split(' ');
            if (valoresCartas.Length != 10)
            {
                Console.WriteLine("Foi informado incorretamente o número de cartas para esta mão : {0}", DadosEntrada);
                return Erro.NumeroCartasIncorreta;
            }

            for (int i = 0; i < 10; i++)
            {
                var valorCarta = valoresCartas[i].Split('H', 'D', 'S', 'C');

                if (valorCarta.Length != 2)
                {
                    Console.WriteLine("Existe uma carta com nipe inválido na seguinte carta {0}", valoresCartas[i]);
                    return Erro.NipeInvalido;
                }

                var numeroCartaValido = valorCarta[0].ToString().Replace("2", "").Replace("3", "").Replace("4", "").Replace("5", "").Replace("6", "").Replace("7", "").Replace("8", "").Replace("9", "").Replace("10", "").Replace("J", "").Replace("Q", "").Replace("K", "").Replace("A", "");
                if (!string.IsNullOrWhiteSpace(numeroCartaValido))
                {
                    Console.WriteLine("Existe uma carta com número invalido na seguinte carta {0}", valoresCartas[i]);
                    return Erro.CartaInvalida;
                }

            }

            return Erro.Nenhum;
        }

        public enum Erro : sbyte
        {
            Nenhum = 1,
            NumeroCartasIncorreta = -1,
            NipeInvalido = -2,
            CartaInvalida = -3,
        }
    }
}
