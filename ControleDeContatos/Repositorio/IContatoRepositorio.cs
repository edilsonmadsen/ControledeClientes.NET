using ControleDeContatos.Models;
using System.Collections.Generic;

namespace ControleDeContatos.Repositorio
{
    public interface IContatoRepositorio
    {
        ContatoModelcs listarPorId(int id);
        List<ContatoModelcs> BuscarTodos();
        ContatoModelcs Adicionar(ContatoModelcs contato);
        ContatoModelcs Atualizar(ContatoModelcs contato);
        bool Apagar(int id);
    }
}
