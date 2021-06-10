using System;
using System.Collections.Generic;
using AulaPOO_ProjetoProdutoSENAI.Interface;

namespace AulaPOO_ProjetoProdutoSENAI.Classes
{
    public class Usuariocs : IUsuario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; }
        public List<Usuariocs> ListaUsuario = new List<Usuariocs>();
        public Usuariocs()
        {

        }

        public Usuariocs(int _codigo, string _nome, string _email, string _senha)
        {

            this.Codigo = _codigo;
            this.Nome = _nome;
            this.Email = _email;
            this.Senha = _senha;
            this.DataCadastro = DateTime.Now;

        }

        public string Cadastrar(Usuariocs usuario)
        {
            usuario.DataCadastro = DateTime.Now;
            ListaUsuario.Add(usuario);

            return $"Usuário {usuario.Nome} Cadastrado com sucesso";

        }

        public string Deletar(Usuariocs usuario)
        {
            Console.WriteLine("Qual é o nome do usuario que você deseja deletar?");
            string deletarusuario = Console.ReadLine();

            ListaUsuario.RemoveAll(x => x.Nome == deletarusuario);
            return $"Usuário {deletarusuario} deletado com sucesso";
        }
    }
}