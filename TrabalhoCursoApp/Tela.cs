using System;
using System.Globalization;
using TrabalhoCursoApp.Entities;

namespace TrabalhoCursoApp
{
    public class Tela
    {
        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("|------------------------------------|");
            Console.WriteLine("|          Menu de Escolhas          |");
            Console.WriteLine("|------------------------------------|");
            Console.WriteLine("|1 - Cadastrar Produtos              |");
            Console.WriteLine("|2 - Lista de Produtos               |");
            Console.WriteLine("|3 - Sair                            |");
            Console.WriteLine("|------------------------------------|");
        }
        public static Produto CadastrarProduto()
        {
            Console.Clear();
            Produto p = new Produto();
            Console.WriteLine("_CADASTRAR PRODUTO_ \n");
            Console.Write("Digite o nome do produto:");
            p.Nome = Console.ReadLine();
            Console.Write("Digite o código do produto:");
            p.Codigo = int.Parse(Console.ReadLine());
            Console.Write("Digite o custo do produto:");
            p.Custo = double.Parse(Console.ReadLine());
            Console.Write("Digite as vendas do produto:");
            p.Venda = double.Parse(Console.ReadLine());
            return p;
        }
        public static void ListaProduto(Produto p)
        {
            /*Console.WriteLine("   |-------------------------------------------------------------|");
            Console.WriteLine("   |                      LISTA DE PRODUTOS                      |");
            Console.WriteLine("   |-------------------------------------------------------------|");
            Console.WriteLine("   | Nome Prod.  | Cod.Prod.  |  Valor Custo  |  Valor Venda     |");
            foreach (Produto t in p.Quantidade)
            {
                Console.WriteLine(p.ToString());
            }
            Console.WriteLine("   |-------------------------------------------------------------| \n");*/
            Console.WriteLine("   |" + "Descrição do Produto: " + p.Nome + " | ");
            Console.WriteLine("   |" + "Código do Produto...: " + p.Codigo + " | ");
            Console.WriteLine("   |" + "Valor Custo.........: " + p.Custo + " | ");
            Console.WriteLine("   |" + "Valor Venda.........: " + p.Venda + " | ");
        }
    }
}
