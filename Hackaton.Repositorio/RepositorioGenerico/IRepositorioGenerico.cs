using System.Collections.Generic;

namespace Hackaton.Repositorio.RepositorioGenerico
{
    public interface IRepositorioGenerico<TDominio>
    {
        List<TDominio> SelecionarTodos();
        TDominio SelecionarPorId(int id);
        void Inserir(TDominio entidade);
        void Atualizar(TDominio entidade);
        void Excluir(TDominio entidade);
    }
}
