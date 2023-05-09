using Allegra.Models;

namespace Allegra.Repositories.Interfaces
{
    public interface IJoiaRepository
    {
        IEnumerable<Joia> Joias { get; }
        IEnumerable<Joia> JoiasPreferidas { get; }

        Joia GetJoiaById(int joiaId);
    }
}
