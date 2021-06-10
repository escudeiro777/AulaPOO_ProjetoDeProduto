using System.Collections.Generic;
using AulaPOO_ProjetoProdutoSENAI.Classes;

namespace AulaPOO_ProjetoProdutoSENAI.Interface
{
    public interface IMarcacs
    {
        public interface IMarca
        {
            string Cadastrar(Marca marca);
            string Deletar(Marca marca);
            List<Marca> Listar();
        }
    }
}