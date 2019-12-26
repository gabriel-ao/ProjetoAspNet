using LojaVirtualV2.Models;
using Microsoft.EntityFrameworkCore;

namespace LojaVirtualV2.Database
{
    public class LojaVirtualContext : DbContext
    {
        public LojaVirtualContext(DbContextOptions<LojaVirtualContext> options) : base(options)
        {

        }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<NewLetterEmail> NewLetterEmail { get; set; }
        public DbSet<Colaborador> Colaboradores { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
    }
}
