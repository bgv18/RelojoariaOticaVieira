using RelojoariaOticaVieira.Api.Entities;

namespace RelojoarioOticaVieira.Api.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
        public ICollection<ShoppingCartItens> Itens { get; set; } = new List<ShoppingCartItens>();
    }
}
