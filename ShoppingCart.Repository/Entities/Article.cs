using System;

namespace ShoppingCart.Repository.Entities
{
    public class Article : BaseEntity
    {
        public Guid BasketId { get; set; }

        public string Item { get; set; }

        public long Price { get; set; }

        public virtual Basket Basket { get; set; }
    }
}
