using Allegra.Context;
using Allegra.Models;
using Allegra.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Allegra.Repositories
{
    public class JoiaRepository : IJoiaRepository
    {
        public readonly AppDbContext _context;
        public JoiaRepository (AppDbContext contexto)
        {
            _context = contexto;
        }
        public IEnumerable<Joia> Joias => _context.Joias.Include(c => c.Categoria);

        public IEnumerable<Joia> JoiasPreferidas => _context.Joias.Where(j => j.IsPreferido).Include(c => c.Categoria);

        public Joia GetJoiaById(int joiaId)
        {
            return _context.Joias.FirstOrDefault(j => j.JoiaId== joiaId) ;
        }
    }
}
