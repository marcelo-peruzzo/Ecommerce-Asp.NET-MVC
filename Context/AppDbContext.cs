using Microsoft.EntityFrameworkCore;

namespace Ecommerce_MVC.Context
{
    public class AppDbContext : DbContext
    {
        //DbContextOptions carrega as informações de configurações necesarias para classe DbContext
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Lanche> Lanches { get; set; }
    }
}