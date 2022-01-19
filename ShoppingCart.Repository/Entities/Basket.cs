using System;
using System.Collections.Generic;

namespace ShoppingCart.Repository.Entities
{
    public class Basket : BaseEntity
    {
        public string Customer { get; set; }

        public bool PaysVAT { get; set; }

        public virtual IList<Article> Articles { get; set; }
    }
}
