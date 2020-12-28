using System;

namespace Project_Product_replay.Classes
{
    public class Usuario
    {
        public int Codigo {get; set;}
        public string Nome {get; set;}
        public string Email { get; set; }
        public string Senha {get; set;}
        public DateTime DataCadastro {get; set;}

        
        
        public Usuario(){
            Cadastrar();
        }

        public Usuario(int code, string name, string _email, string password){

            Codigo = code;
            Nome = name;
            Email = _email;
            Senha = password;
            DataCadastro = DateTime.Now;
        }

        public void Cadastrar(){
            Nome = "Matheus";
            Email = "admin@gmail.com";
            Senha = "admin";
            DataCadastro = DateTime.Now;
        }

        public void Deletar(){
            Nome = "";
            Email = "";
            Senha = "";
            DataCadastro = DateTime.Parse("");
        }

        


    }
}