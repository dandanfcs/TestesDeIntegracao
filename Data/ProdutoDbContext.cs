using Microsoft.EntityFrameworkCore;
using TestesDeIntegracao.Models;

namespace TestesDeIntegracao.Data
{

    public class ProdutoDbContext : DbContext
    {
        public ProdutoDbContext(DbContextOptions<ProdutoDbContext> options)
            : base(options)
        { }
        public DbSet<Produto> Produtos { get; set; }
    }
  
}

