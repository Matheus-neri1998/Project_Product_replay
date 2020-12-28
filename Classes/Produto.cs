using System;
using System.Collections.Generic;

namespace Project_Product_replay.Classes
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string NomeProduto {get; set;}
        public float Preco {get; set;}
        public DateTime DataCadastro {get; set;}
        public Marca marca = new Marca();
        public Usuario user = new Usuario();
        public List<Produto> ListaDeProdutos = new List<Produto>();

        public void Cadastrar(){

            Produto novoProduto = new Produto();

            Console.WriteLine("Digite o código do produto: ");
            novoProduto.Codigo = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o nome do produto: ");
            novoProduto.NomeProduto = Console.ReadLine();

            Console.WriteLine("Digite o preço do produto: ");
            novoProduto.Preco = float.Parse(Console.ReadLine());

            DataCadastro = DateTime.Today;

            novoProduto.marca = marca.Cadastrar();

            novoProduto.user = new Usuario();

            ListaDeProdutos.Add(novoProduto);

        }

        public void Listar(){

            Console.ForegroundColor = ConsoleColor.DarkBlue;

            foreach (Produto item in ListaDeProdutos)
            {
                Console.WriteLine($"Código: {item.Codigo}");
                Console.WriteLine($"Produto: {item.NomeProduto}");
                Console.WriteLine($"Preço: {item.Preco}");
                Console.WriteLine($"Data de Cadastro: {item.DataCadastro}");
                Console.WriteLine($"Marca: {item.marca}");
                Console.WriteLine($"Cadastrado por: {item.user}");
            }

            Console.ResetColor();

        }

        public void Deletar(int cod){

            Produto deleteProduct = ListaDeProdutos.Find(d => d.Codigo == cod);
            ListaDeProdutos.Remove(deleteProduct); 

        }
        
        
    }
}