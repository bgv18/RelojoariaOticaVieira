using Microsoft.EntityFrameworkCore;
using RelojoariaOticaVieira.Api.Context;
using RelojoarioOticaVieira.Api.Entities;

namespace RelojoariaOticaVieira.Api.Repositories
{
    public class ProductRepositoy : IProductRepository
    {
        private readonly AppDbContext _context;

        public ProductRepositoy(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Product> GetItem(int id)
        {
            var product = await _context.Product
                          .Include(c => c.Category)
                          .SingleOrDefaultAsync(c => c.Id == id);

            return product;
        }

        public async Task<IEnumerable<Product>> GetItens()
        {
            var products = await _context.Product
                          .Include(c => c.Category)
                          .ToListAsync();

            return products;
        }

        public async Task<IEnumerable<Product>> GetItensPerCategory(int id)
        {
            var product = await _context.Product
                          .Include(c => c.Category)
                          .Where(c => c.CategoryId == id)
                          .ToListAsync();

            return product;
        }
    }
}
