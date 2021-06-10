using AulaPOO_ProjetoProdutoSENAI.Classes;

namespace AulaPOO_ProjetoProdutoSENAI.Interface
{
    public interface IUsuario
    {
        string Cadastrar(Usuariocs usuario);
        string Deletar(Usuariocs usuario);
    }
}