using System;
using System.Collections.Generic;
using AulaPOO_ProjetoProdutoSENAI.Interface;

namespace AulaPOO_ProjetoProdutoSENAI.Classes
{
    public class Marca : IMarcacs
    {
        public int Codigo { get; set; }
        public string NomeMarca { get; set; }
        public DateTime DataCadastro { get; set; }
        public List<Marca> ListaMarca = new List<Marca>();

        public Marca()
        {

        }
        public Marca(int _codigo, string _nomemarca)
        {
            this.NomeMarca = _nomemarca;
            this.Codigo = _codigo;
            DataCadastro = DateTime.Now;
        }


        public string Cadastrar(Marca marca)
        {
            ListaMarca.Add(marca);
            return "Marca cadastrada";
        }

        public string Deletar(Marca marca)
        {
           
            ListaMarca.Remove(marca);
            return "Marca Deletada";
        }

        public List<Marca> Listar()
        {
            return ListaMarca;
        }
    }
}