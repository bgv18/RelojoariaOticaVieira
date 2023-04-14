using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelojoariaOticaVieira.Models.DTOs
{
    public class ShoppingCartItens
    {
        public int Id { get; set; }
        public int ShoppingCartId { get; set; }
        public int ProductId { get; set; }
        public decimal Quantity { get; set; }
        public string? ProductName { get; set; }
        public string? ProductDescription { get; set; }
        public string? ProductImageUrl { get; set; }
        public decimal Price { get; set; }
        public int TotalPrice { get; set; }
    }
}
