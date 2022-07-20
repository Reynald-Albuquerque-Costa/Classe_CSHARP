using Classe.Src;
using System;

namespace Classe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Time SaoPaulo = new Time("São Paulo", Categoria.SerieA, 1930, "São Paulo");
            Time Cruzeiro = new Time("Cruzeiro", Categoria.SerieB, 1921, "Minas Gerais");
            Time Paysandu = new Time("Paysandu", Categoria.SerieC, 1914, "Para");
            Time PousoAlegre = new Time("Pouso Alegre", Categoria.SerieD, 1913, "Minas Gerais");

            Console.WriteLine(SaoPaulo.ToString());

        }
    }
}
