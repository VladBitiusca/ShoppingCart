using Microsoft.EntityFrameworkCore;
using ShoppingCart.Repository.DBContext;
using ShoppingCart.Repository.Entities;
using ShoppingCart.Service.Models;
using ShoppingCart.Service.Repository;
using System;
using System.Collections.Generic;
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
            var entity = new Basket
            {
                Customer = basket.Customer,
                PaysVAT = basket.PaysVAT,
                Articles = basket.Articles.Select(a => new Article
                {
                    Item = a.Item,
                    Price = (long)a.Price
                }).ToList()
            };

            _context.Add(entity);

            _context.SaveChanges();
        }

        public IList<BasketDto> GetAll()
        {
            return _context.Baskets.Include(b => b.Articles).Select(b => b.MapToDto()).ToList();
        }

        public ResponseBasket GetBasket(Guid id)
        {
            var basket = GetById(id);

            if (basket == null)
            {
                return null;
            }

            return new ResponseBasket
            {
                Id = basket.Id,
                Customer = basket.Customer,
                PaysVAT = basket.PaysVAT,
                Articles = basket.Articles.Select(a => a.MapToDto()).ToList()
            };
        }

        public BasketDto UpdateArticles(Guid basketId, ArticleDto article)
        {
            var basket = GetById(basketId);

            if (basket == null)
            {
                return null;
            }

            basket.Articles.Add(new Article
            {
                Item = article.Item,
                Price = (long)article.Price,
                BasketId = basketId
            });

            _context.SaveChanges();

            return _context.Baskets.Find(basketId).MapToDto();
        }

        private Basket GetById(Guid basketId)
        {
            return _context.Baskets.Include(b => b.Articles).FirstOrDefault(b => b.Id == basketId);
        }
    }
}
