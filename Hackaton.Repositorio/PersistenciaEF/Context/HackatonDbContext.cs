using System.Data.Entity;
using Hackaton.Dominio.hackaton;

namespace Hackaton.Repositorio.PersistenciaEF.Context
{
    public class HackatonDbContext : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }


    }
}
