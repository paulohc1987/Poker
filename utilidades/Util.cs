using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsolePoker.Utilidades
{
    public static class Util
    {
        public static bool ExisteSequenciaCartas(List<Cartas> cartasJogadorOrdenada)
        {
            for (int i = 0; i < 4; i++)
            {
                if (cartasJogadorOrdenada[i].Valor+1  != cartasJogadorOrdenada[i+1].Valor)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool MesmoNaipe(List<Cartas> cartasJogadorOrdenada)
        {
            for (int i = 0; i < 4; i++)
            {
                if (cartasJogadorOrdenada[i].Naipe != cartasJogadorOrdenada[i+1].Naipe)
                {
                    return false;
                }
            }
            return true;
        }

        public static byte MaiorValorCartaJogador(List<Cartas> cartasJogadorOrdenada)
        {
            return cartasJogadorOrdenada.Select(x => x.Valor).Max();          
        }

        public static byte SegundaValorCartaJogador(List<Cartas> cartasJogadorOrdenada)
        {
            int indice = cartasJogadorOrdenada.FindIndex(x => x.Valor == MaiorValorCartaJogador(cartasJogadorOrdenada));
            cartasJogadorOrdenada.Remove(cartasJogadorOrdenada[indice]);
            return cartasJogadorOrdenada.Select(x => x.Valor).Max();
        }

        public static byte? QuadraDeQue(List<Cartas> cartasJogadorOrdenada)
        {
            if (cartasJogadorOrdenada[0].Valor == cartasJogadorOrdenada[2].Valor && cartasJogadorOrdenada[0].Valor == cartasJogadorOrdenada[3].Valor && cartasJogadorOrdenada[0].Valor == cartasJogadorOrdenada[4].Valor)
            {
                return cartasJogadorOrdenada[0].Valor;
            }
            if (cartasJogadorOrdenada[1].Valor == cartasJogadorOrdenada[2].Valor && cartasJogadorOrdenada[1].Valor == cartasJogadorOrdenada[3].Valor && cartasJogadorOrdenada[1].Valor == cartasJogadorOrdenada[4].Valor)
            {
                return cartasJogadorOrdenada[1].Valor; 
            }
            if (cartasJogadorOrdenada[0].Valor == cartasJogadorOrdenada[1].Valor && cartasJogadorOrdenada[0].Valor == cartasJogadorOrdenada[3].Valor && cartasJogadorOrdenada[0].Valor == cartasJogadorOrdenada[4].Valor)
            {
                return cartasJogadorOrdenada[0].Valor;
            }
            if (cartasJogadorOrdenada[0].Valor == cartasJogadorOrdenada[1].Valor && cartasJogadorOrdenada[0].Valor == cartasJogadorOrdenada[2].Valor && cartasJogadorOrdenada[0].Valor == cartasJogadorOrdenada[4].Valor)
            {
                return cartasJogadorOrdenada[0].Valor;
            }
            if (cartasJogadorOrdenada[0].Valor == cartasJogadorOrdenada[1].Valor && cartasJogadorOrdenada[0].Valor == cartasJogadorOrdenada[2].Valor && cartasJogadorOrdenada[0].Valor == cartasJogadorOrdenada[3].Valor)
            {
                return cartasJogadorOrdenada[0].Valor;
            }
            return null;
        }

        public static bool TemTrinca(List<Cartas> cartasJogadorOrdenada)
        {
            int contagem = cartasJogadorOrdenada.GroupBy(p => p.Valor).Where(x => x.Count() == 3).Sum(x => x.Count());
            return contagem == 3 ? true : false;
        }

        public static int TrincaDeQue(List<Cartas> cartasJogadorOrdenada)
        {
            int valorTrinca = cartasJogadorOrdenada.GroupBy(p => p.Valor).Where(x => x.Count() == 3).Sum(x => x.Key);
            return valorTrinca;
        }

        public static int ParDeQue(List<Cartas> cartasJogadorOrdenada)
        {
            int valorPar = cartasJogadorOrdenada.GroupBy(p => p.Valor).Where(x => x.Count() == 2).Sum(x => x.Key);
            return valorPar;
        }

        public static bool TemQuadra(List<Cartas> cartasJogadorOrdenada)
        {
            int contagem = cartasJogadorOrdenada.GroupBy(p => p.Valor).Where(x => x.Count() == 4).Sum(x => x.Count());
            return contagem == 4 ? true : false;
        }

        public static bool TemPar(List<Cartas> cartasJogadorOrdenada)
        {
            int contagem = cartasJogadorOrdenada.GroupBy(p => p.Valor).Where(x => x.Count() == 2).Sum(x => x.Count());
            return contagem == 2 ? true : false;
        }
        public static bool TemDoisPares(List<Cartas> cartasJogadorOrdenada)
        {
            int valoresParesCont = cartasJogadorOrdenada.GroupBy(p => p.Valor).Where(x => x.Count() == 2).ToList().Count();
            return valoresParesCont == 2 ? true: false;
        }

        public static byte valorMaximoDosPares(List<Cartas> cartasJogadorOrdenada)
        {
            byte valorMaximoPares = cartasJogadorOrdenada.GroupBy(p => p.Valor).Where(x => x.Count() == 2).ToList().Max(p => p.Key);
            return valorMaximoPares;
        }

        public static byte valorMinimoDosPares(List<Cartas> cartasJogadorOrdenada)
        {
            byte valorMinimoPares = cartasJogadorOrdenada.GroupBy(p => p.Valor).Where(x => x.Count() == 2).ToList().Min(p => p.Key);
            return valorMinimoPares;
        }

        public static List<Cartas> OdernarLista(List<Cartas> cartasJogadorOrdenada)
        {
            List<Cartas> listaOrdenada = cartasJogadorOrdenada.OrderBy(x => x.Valor).ToList();
            return listaOrdenada;
        }

        public static byte MaximoValorUnico(List<Cartas> cartasJogadorOrdenada)
        {
            byte cartaMaximaDistinta = cartasJogadorOrdenada.GroupBy(p => p.Valor).Where(x => x.Count() == 1).Max(p => p.Key);
            return cartaMaximaDistinta;
        }
    }
}
