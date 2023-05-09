using Allegra.Models;

namespace Allegra.ViewModels
{
    public class JoiaListViewModel
    {
        public IEnumerable<Joia> Joias { get; set; }
        public string CategoriaAtual { get; set; }
    }
}
