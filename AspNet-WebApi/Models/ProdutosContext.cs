using System.Data.Entity;

namespace AspNet_WebApi.Models
{
    public class ProdutosContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
    }
}