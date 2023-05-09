using Allegra.Models;
using Allegra.Repositories;
using Allegra.Repositories.Interfaces;
using Allegra.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Allegra.Controllers
{
    public class JoiaController : Controller
    {
        private readonly IJoiaRepository _joiaRepository;

        public JoiaController(IJoiaRepository joiaRepository)
        {
            _joiaRepository = joiaRepository;
        }

        public IActionResult Index()
        {

            ViewData["Categoria"] = "Todas as Categorias";
            ViewData["Data"] = DateTime.Now;

            //ViewData["Titulo"] = "Todas as Jóias";
            // ViewData["Data"] = DateTime.Now;

            //var joias = _joiaRepository.Joias;

            //ViewBag.Total = "Total de jóias: ";
            // ViewBag.TotalCount = joias.Count();

            //return View(joias);

            var joiasListViewModel = new JoiaListViewModel();
            joiasListViewModel.Joias = _joiaRepository.Joias;
            //joiasListViewModel.CategoriaAtual = "Categoria Teste";
            return View(joiasListViewModel);
        }

        public IActionResult List()
        {
            var joias = _joiaRepository.Joias;

            ViewData["Categoria"] = "Todas as categorias";
            ViewData["Data"] = DateTime.Now;

            return View(joias);

        }

        public IActionResult ListCategoria(string categoria)
        {

            ViewData["Categoria"] = categoria;
            ViewData["Data"] = DateTime.Now;

            IEnumerable<Joia> joias;
            string categoriaAtual = string.Empty;

            if (string.IsNullOrEmpty(categoria))
            {
                joias = _joiaRepository.Joias.OrderBy(l => l.Nome);
                categoriaAtual = "Todas as Categorias";
            }
            else
            {
                /*if (string.Equals("Anéis", categoria, StringComparison.OrdinalIgnoreCase))
                {
                    joias = _joiaRepository.Joias
                        .Where(l => l.Categoria.CategoriaNome.Equals("Anéis"))
                        .OrderBy(l => l.Nome);
                }
                else if (string.Equals("Colares", categoria, StringComparison.OrdinalIgnoreCase))
                {
                    joias = _joiaRepository.Joias
                        .Where(l => l.Categoria.CategoriaNome.Equals("Colares"))
                        .OrderBy(l => l.Nome);
                }
                else if (string.Equals("Brincos", categoria, StringComparison.OrdinalIgnoreCase))
                {
                    joias = _joiaRepository.Joias
                       .Where(l => l.Categoria.CategoriaNome.Equals("Brincos"))
                       .OrderBy(l => l.Nome);
                }
                else
                {
                    joias = _joiaRepository.Joias
                        .Where(l => l.Categoria.CategoriaNome.Equals("Pulseiras"))
                        .OrderBy(l => l.Nome);
                }*/

                joias = _joiaRepository.Joias
                        .Where(l => l.Categoria.CategoriaNome.Equals(categoria))
                        .OrderBy(l => l.Nome);
                categoriaAtual = categoria;
            }

            var joiaListViewModel = new JoiaListViewModel
            {
                Joias = joias,
                CategoriaAtual = categoriaAtual
            };

            return View(joiaListViewModel);

        }

        public IActionResult Details(int joiaId)
        {
            var joia = _joiaRepository.Joias.FirstOrDefault(j => j.JoiaId == joiaId);
            return View(joia);
        }
    }
}