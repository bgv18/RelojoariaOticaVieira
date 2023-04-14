using System.ComponentModel.DataAnnotations;

namespace RelojoariaOticaVieira.Models.DTOs
{
    public class ShoppingCartItemAddDTO
    {
        [Required]
        public int ShoppingCartId { get; set; }
        [Required]
        public int ProductId { get; set; }
        [Required]
        public int Quantity { get; set; }
    }
}
