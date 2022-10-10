using System;
using TrabalhoCursoApp;
using System.IO;
namespace TrabalhoCursoApp.Entities
{
    public class Produtos
    {
        public List<Produto> produto { get; set; }
        public string diretorio { get; set; }
        public string nomearquivo { get; set; }
        public Produtos()
        {
            produto = new List<Produto>();
        }
        public void AdicionarProduto(Produto p)
        {
            produto.Add(p);
        }
        public void GravarArquivo()
        {
            diretorio = Directory.GetCurrentDirectory();
            diretorio = diretorio + @"\" + nomearquivo + ".txt";
            if (!System.IO.File.Exists(diretorio))
            {
                System.IO.File.Create(diretorio).Close();
            }
            //Está dando erro e só salva o ultimo produto
            int tamanho = produto.Count;
            string teste = "";
            for (int i = 0; i < tamanho; i++) 
            {
                Produto produtoP = new Produto();
                produtoP.posicao = i;
                string conteudo = produto[i].ToString();
                teste += conteudo;
            }
            File.WriteAllText(diretorio, teste);
        }
        public void GravarArquivoInfo()
        {
            Console.WriteLine("Os dados foram salvos em um arquivo com sucesso!");
            Console.WriteLine("Local do arquivo: " + diretorio);
            Console.ReadLine();
        }
    }
}
