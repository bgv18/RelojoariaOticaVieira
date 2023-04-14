using Microsoft.EntityFrameworkCore;
using RelojoariaOticaVieira.Api.Entities;
using RelojoarioOticaVieira.Api.Entities;

namespace RelojoariaOticaVieira.Api.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<ShoppingCart>? ShoppingCart { get; set; }
        public DbSet<ShoppingCartItens>? ShoppingCartItens { get; set; }
        public DbSet<Product>? Product { get; set; }
        public DbSet<Category>? Categorie { get; set; }
        public DbSet<User>? User { get; set; }
    }
}
