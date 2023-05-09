using Allegra.Models;
using Microsoft.EntityFrameworkCore;

namespace Allegra.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)  : base(options)
    { 
    }
    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Joia> Joias { get; set; }

    public DbSet<CarrinhoCompraItem> CarrinhoCompraItens{ get; set; }

}
