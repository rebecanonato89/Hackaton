using Hackaton.Dominio.hackaton;
using Hackaton.Repositorio.PersistenciaEF.Context;
using Hackaton.Repositorio.RepositorioGenerico;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Hackaton.Repositorio.RepositorioEF
{
    public class RepositorioPessoa : IRepositorioGenerico<Pessoa>
    {
        public void Atualizar(Pessoa entidade)
        {
            throw new NotImplementedException();
        }

        public void Excluir(Pessoa entidade)
        {
            throw new NotImplementedException();
        }

        public void Inserir(Pessoa entidade)
        {
            throw new NotImplementedException();
        }

        public Pessoa SelecionarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Pessoa> SelecionarTodos()
        {
            using (HackatonDbContext contexto = new HackatonDbContext())
            {
                return contexto.Pessoas.ToList();
            }
        }
    }
}
