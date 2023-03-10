using Ecommerce_MVC.Repositories.Interfaces;
using Ecommerce_MVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce_MVC.Controllers
{
    public class LancheController : Controller
    {
        private readonly ILancheRepository _ilancheRepository;

        public LancheController(ILancheRepository ilancheRepository)
        {
            _ilancheRepository = ilancheRepository;
        }

        public IActionResult List()
        {
            //var lanches = _ilancheRepository.Lanches;
            //return View(lanches);
            var lanchesListViewModel = new LancheListViewModel();
            lanchesListViewModel.Lanches =  _ilancheRepository.Lanches;
            lanchesListViewModel.CategoriaAtual = "Categoria atual";

            return View(lanchesListViewModel);

        }
    }
}