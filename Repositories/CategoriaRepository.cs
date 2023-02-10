
using Ecommerce_MVC.Context;
using Ecommerce_MVC.Models;
using Ecommerce_MVC.Repositories.Interfaces;

namespace Ecommerce_MVC.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}