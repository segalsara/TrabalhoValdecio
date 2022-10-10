using System;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using TrabalhoCursoApp.Entities;

namespace TrabalhoCursoApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            int menuescolha = 0;
            Produtos produtos = new Produtos();
            Produto produto = new Produto();
            while (menuescolha != 3)
            {
                switch (menuescolha){
                    case 0:
                        Tela.Menu();
                        menuescolha = int.Parse(Console.ReadLine());
                        break;
                    case 1:
                        Produto p = Tela.CadastrarProduto();
                        produtos.AdicionarProduto(p);
                        Console.WriteLine("Você deseja adicionar outro produto? S // N");
                        string resposta = Console.ReadLine();
                        if (resposta == "S")
                        {
                            menuescolha = 1;
                        }
                        else
                        {
                            Console.ReadLine();
                            menuescolha = 0;
                        }
                        break;
                    case 2:
                        /*int quantidade = produtos.produto.Count;
                        foreach (Produto produto in p.Custo)
                        {
                            Tela.ListaProduto(produtos.produto[p]);
                        }*/
                        Console.Clear();
                        int quantidade = produtos.produto.Count;
                        int posicao = 0;
                        Console.WriteLine("   |-------------------------------------------------------------|");
                        Console.WriteLine("   |                      LISTA DE PRODUTOS                      |");
                        Console.WriteLine("   |-------------------------------------------------------------|\n");
                        for (posicao = 0; posicao < quantidade; posicao++)
                        {
                            Console.WriteLine(posicao + 1 + "° produto: ");
                            Tela.ListaProduto(produtos.produto[posicao]);
                            Console.WriteLine("   |-------------------------------------------------------------| \n");
                        }
                        Console.WriteLine("VOCÊ DESEJA EXCLUIR ALGUM PRODUTO? S // N");
                        string excluir = Console.ReadLine();
                        if (excluir == "S")
                        {
                            Console.WriteLine("Você deseja exclui qual produto? ex: 1 .. n");
                            int escolhaExcluir = int.Parse(Console.ReadLine());
                            produtos.produto.Remove(produtos.produto[escolhaExcluir - 1]);
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Você deseja salvar os dados em um arquivo? S // N");
                            string escolhaA = Console.ReadLine();
                            if (escolhaA == "S")
                            {
                                Console.WriteLine("Escolha um nome para o arquivo: (Sem caracteres especiais e sem extensão .txt)");
                                produtos.nomearquivo = Console.ReadLine();
                                /*for (posicao = 0; posicao < quantidade; posicao++)
                                {
                                    produtos.GravarArquivo(produtos.produto[posicao]);
                                }*/
                                produtos.GravarArquivo();
                                produtos.GravarArquivoInfo();
                                menuescolha = 0;
                            }
                            else
                            {
                                menuescolha = 0;
                            }
                        }
                        break;
                    case 3:
                        break;
                }
            }
        }
    }
}