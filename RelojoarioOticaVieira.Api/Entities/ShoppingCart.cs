namespace RelojoariaOticaVieira.Api.Entities
{
    public class ShoppingCart
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public ICollection<ShoppingCartItens> Itens { get; set; } = new List<ShoppingCartItens>();
    }
}
