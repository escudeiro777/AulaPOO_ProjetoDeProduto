using System.Collections.Generic;
using AulaPOO_ProjetoProdutoSENAI.Classes;

namespace AulaPOO_ProjetoProdutoSENAI.Interface
{
    public interface IProduto
    {
        string Cadastrar(Produto produto);
        List<Produto> Listar();
        string Deletar(Produto produto);
    }
}