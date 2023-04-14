using RelojoarioOticaVieira.Api.Entities;

namespace RelojoariaOticaVieira.Api.Entities
{
    public class ShoppingCartItens
    {
        public int Id { get; set; }
        public int ShoppingCartId { get; set; }
        public int ProductId { get; set; }
        public decimal Quantity { get; set; }
        public ShoppingCart? ShoppingCart { get; set; }
        public Product? Product { get; set; }
    }
}
