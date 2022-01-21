using ShoppingCart.Service.Interfaces;
using ShoppingCart.Service.Models;
using ShoppingCart.Service.Repository;
using System;
using System.Collections.Generic;

namespace ShoppingCart.Service.Services
{
    public class BasketsService : IBasketsService
    {
        private readonly IBasketsRepository _basketsRepository;

        public BasketsService(IBasketsRepository basketsRepository)
        {
            _basketsRepository = basketsRepository;
        }

        public void CreateBasket(BasketDto basket)
        {
            _basketsRepository.Create(basket);
        }

        public IList<BasketDto> GetAll()
        {
            return _basketsRepository.GetAll();
        }

        public ResponseBasket GetBasket(Guid id)
        {
            return _basketsRepository.GetBasket(id);
        }

        public BasketDto PartialUpdate(Guid id, BasketDto basket)
        {
            return _basketsRepository.PartialUpdate(id, basket);
        }

        public BasketDto UpdateArticles(Guid basketId, ArticleDto article)
        {
            return _basketsRepository.UpdateArticles(basketId, article);
        }
    }
}
