using Ecommerce_MVC.Models;

namespace Ecommerce_MVC.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}