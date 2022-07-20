using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe.Src
{
    internal class Time
    {
        public string Nome { get; set; }

        Categoria Divisao { get; set; }

        public int AnoOrigem { get; set; }

        public string Estado { get; set; }

        public Time(string nome, Categoria divisao, int anoOrigem, string regiao)
        {
            Nome = nome;
            Divisao = divisao;
            AnoOrigem = anoOrigem;
            Estado = regiao;
        }

        public override string ToString()
        {
            return $"\nO nome é: {Nome}" +
                   $"\nA Série que ele atua é: {Divisao}" +
                   $"\nO ano que nasceu: {AnoOrigem}" +
                   $"\nO estado onde fica é: {Estado}";

        }
    }
    
    public enum Categoria
    {
        SerieA,
        SerieB,
        SerieC,
        SerieD

    }
}
