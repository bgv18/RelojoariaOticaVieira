using RelojoarioOticaVieira.Api.Entities;

namespace RelojoariaOticaVieira.Api.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetItens();
        Task<Product> GetItem(int id);
        Task<IEnumerable<Product>> GetItensPerCategory(int id);
    }
}
