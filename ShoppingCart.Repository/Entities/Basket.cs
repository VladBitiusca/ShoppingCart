using ShoppingCart.Service.Models;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingCart.Repository.Entities
{
    public class Basket : BaseEntity
    {
        public string Customer { get; set; }

        public bool PaysVAT { get; set; }

        public virtual IList<Article> Articles { get; set; } = new List<Article>();

        public BasketDto MapToDto()
        {
            return new BasketDto
            {
                Id = Id,
                Customer = Customer,
                PaysVAT = PaysVAT,
                Articles = Articles.Select(a => a.MapToDto()).ToList()
            };
        }
    }
}
