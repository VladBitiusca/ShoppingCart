using System;
using System.ComponentModel.DataAnnotations;

namespace ShoppingCart.Repository.Entities
{
    public class BaseEntity
    {
        [Key]
        public Guid Id { get; set; }
    }
}