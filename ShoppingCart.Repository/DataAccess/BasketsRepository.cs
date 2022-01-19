using ShoppingCart.Repository.DBContext;
using ShoppingCart.Repository.Entities;
using ShoppingCart.Service.Models;
using ShoppingCart.Service.Repository;
using System.Linq;

namespace ShoppingCart.Repository.DataAccess
{
    public class BasketsRepository : IBasketsRepository
    {
        private readonly ShopDbContext _context;

        public BasketsRepository(ShopDbContext context)
        {
            _context = context;
        }

        public void Create(BasketDto basket)
        {
            _context.Add(new Basket
            {
                Customer = basket.Customer,
                PaysVAT = basket.PaysVAT,
                Articles = basket.Articles.Select(a => new Article
                {
                    Item = a.Item,
                    Price = (long)a.Price
                }).ToList()
            });

            _context.SaveChanges();
        }
    }
}
