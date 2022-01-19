using System;

namespace ShoppingCart.Service.Models
{
    public class ArticleDto
    {
        public Guid Id { get; set; }

        public string Item { get; set; }

        public decimal Price { get; set; }
    }
}
