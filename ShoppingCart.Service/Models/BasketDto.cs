using System;
using System.Collections.Generic;

namespace ShoppingCart.Service.Models
{
    public class BasketDto
    {
        public Guid Id { get; set; }

        public string Customer { get; set; }

        public bool PaysVAT { get; set; }

        public bool Close { get; set; }

        public bool Payed { get; set; }

        public IList<ArticleDto> Articles { get; set; } = new List<ArticleDto>();
    }
}
