using Projeto_MVC.Models;

namespace Projeto_MVC.Repositorio
{
    public interface IContatoRepositorio
    {
        bool Apagar(int id);
        List<ContatoModel> BuscarTodos();
        ContatoModel Adicionar(ContatoModel contato);
        ContatoModel ListarPorID(int id);
        ContatoModel Atualizar(ContatoModel contato);
    }
}
