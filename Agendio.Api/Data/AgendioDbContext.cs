using Microsoft.EntityFrameworkCore;

using AGENDIO.API.Models;

namespace AGENDIO.API.Data

{
    public class AgendioDbContext : DbContext
    {
        public AgendioDbContext(DbContextOptions<AgendioDbContext> options) : base(options) { }

        public DbSet<Dono> Donos { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Negocio> Negocios { get; set; }
        public DbSet<Servicos> Servicos { get; set; }
        public DbSet<Marcacao> Marcacoes { get; set; }
    }
}
