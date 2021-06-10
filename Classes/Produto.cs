using System;
using System.Collections.Generic;
using AulaPOO_ProjetoProdutoSENAI.Interface;

namespace AulaPOO_ProjetoProdutoSENAI.Classes
{
    public class Produto : IProduto
    {
        public int codigoP { get; set; }
        public string NomeProduto { get; set; }
        public float Preco { get; set; }
        public DateTime DataCadastro { get; set; }
        public Marca marca { get; set; }
        public Usuariocs CadastradoPor { get; set; }
        
        public List<Produto> ListaProduto = new List<Produto>(); 
        public Produto()
        {

        }
        public Produto(int _codigo, string _nomeproduto, float _preco, Marca _marca, Usuariocs _cadastradopor)  
        {
            this.codigoP = _codigo;
            this.NomeProduto = _nomeproduto;
            this.Preco = _preco;
            this.DataCadastro = DateTime.Now;
            this.marca = _marca;
            this.CadastradoPor = _cadastradopor;
        } 
        
        public string Cadastrar(Produto produto)
        {
            ListaProduto.Add(produto);
            return "Produto cadastrado com sucesso ";
        }

        public string Deletar(Produto produto)
        {
          ListaProduto.RemoveAll(x => x.NomeProduto == produto.NomeProduto);
            return "Produto deletado com sucesso";
        }

        public List<Produto> Listar()
        {
           return ListaProduto;
        }
    }
}