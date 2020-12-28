using System;

namespace Project_Product_replay.Classes
{
    public class Login
    {
        public bool Logado { get; set; }

        public Login(){
            Logar();

            if(Logado == true){
                GerarMenu();
            }
        }

        public void GerarMenu(){

            Produto product = new Produto();
            Marca brand = new Marca();

            string option = "m";

            do
            {
                
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("Escolha uma opção abaixo:");
                Console.WriteLine("1 - Cadastrar Marca");
                Console.WriteLine("2 - Listar Marca");
                Console.WriteLine("3 - Excluir Marca");
                Console.WriteLine("4 - Cadastrar Produto");
                Console.WriteLine("5 - Listar Produto");
                Console.WriteLine("6 - Excluir Produto");
                Console.WriteLine("0 - Sair");

                option = Console.ReadLine();
                
                switch (option)
                {
                    case "1":

                        brand.Cadastrar();
                        break;

                    case "2":
                        brand.Listar();
                        break;

                    case "3":
                        Console.WriteLine("Digite um código para excluir a marca");
                        int codigo = int.Parse(Console.ReadLine());
                        brand.Deletar(codigo);
                        break;

                    case "4":
                        product.Cadastrar();
                        break;

                    case "5":
                        product.Listar();
                        break;

                    case "6":
                        Console.WriteLine("Digite um código para excluir um produto");
                        int codeProduct = int.Parse(Console.ReadLine());
                        product.Deletar(codeProduct);
                        break;



                    default:
                        break;
                }
                



                Console.ResetColor();
            } while (option != "0");

        }

        public void Logar() {

            Usuario user = new Usuario();

            Console.WriteLine("Digite o seu email: ");
            string emailLogin = Console.ReadLine();

            Console.WriteLine("Digite a sua senha: ");
            string senhaLogin = Console.ReadLine();
            
            if(emailLogin == user.Email && senhaLogin == user.Senha){
                Logado = true;
                Console.WriteLine("Login efetuado com sucesso! ");
            }else{
                Console.WriteLine("Falha ao realizar o login, tente novamente :( ");
            }

        }

        public void Deslogar(){
            Logado = false;
        }
        
        
    }
}