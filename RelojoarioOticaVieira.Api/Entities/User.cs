namespace RelojoariaOticaVieira.Api.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ShoppingCart? ShoppingCart { get; set; } 
    }
}
