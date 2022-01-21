using ShoppingCart.Service.Models;
using System;
using System.Collections.Generic;

namespace ShoppingCart.Service.Repository
{
    public interface IBasketsRepository
    {
        void Create(BasketDto basket);
        
        IList<BasketDto> GetAll();

        BasketDto UpdateArticles(Guid basketId, ArticleDto article);
        
        ResponseBasket GetBasket(Guid id);
        
        BasketDto PartialUpdate(Guid id, BasketDto basket);
    }
}
