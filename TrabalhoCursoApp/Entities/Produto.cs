using System;
using System.Globalization;
using TrabalhoCursoApp;
namespace TrabalhoCursoApp.Entities
{
    public class Produto
    {
        public string Nome { get; set; }
        public int Codigo { get; set; }
        public double Custo { get; set; }
        public double Venda { get; set; }
        public int posicao { get; set; }
        public override string ToString()
        {
            return Codigo + "° produto: \n" +"Nome: " + Nome + " | \n" + "Codigo: " + 
                Codigo.ToString() + " | \n" + "Venda: " +
                Venda.ToString("F2",CultureInfo.InvariantCulture)+ " | \n" + "Custo: " +
                Custo.ToString("F2", CultureInfo.InvariantCulture) + " |\n \n";
        }
    }
}