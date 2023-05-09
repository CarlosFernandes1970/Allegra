using Allegra.Models;
using Allegra.Repositories.Interfaces;
using Allegra.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Allegra.Controllers
{
    public class CarrinhoCompraController : Controller
    {
        private readonly IJoiaRepository _joiaRepository;
        private readonly CarrinhoCompra _carrinhoCompra;

        public CarrinhoCompraController(IJoiaRepository joiaRepository, CarrinhoCompra carrinhoCompra)
        {
            _joiaRepository = joiaRepository;
            _carrinhoCompra = carrinhoCompra;
        }

        public IActionResult Index()
        {
            var itens = _carrinhoCompra.GetCarrinhoCompraItens();
            _carrinhoCompra.CarrinhoCompraItems = itens;

            var carrinhoCompraVM = new CarrinhoCompraViewModel
            {
                CarrinhoCompra = _carrinhoCompra,
                CarrinhoCompraTotal = _carrinhoCompra.GetCarrinhoCompraTotal()
            };


            return View(carrinhoCompraVM);
        }

        public IActionResult AdicionarItemNoCarrinhoCompra(int joiaId)
        {
            var itemSelecionado = _joiaRepository.Joias.FirstOrDefault(p => p.JoiaId == joiaId);

            if (itemSelecionado != null)
            {
                _carrinhoCompra.AdicionarAoCarrinho(itemSelecionado);
                
            }
            return RedirectToAction("Index");
        }

        public IActionResult RemoverItemNoCarrinhoCompra(int joiaId)
        {
            var itemSelecionado = _joiaRepository.Joias.FirstOrDefault(p => p.JoiaId == joiaId);

            if (itemSelecionado != null)
            {
                _carrinhoCompra.RemoverDoCarrinho(itemSelecionado);

            }
            return RedirectToAction("Index");
        }

    }
}
