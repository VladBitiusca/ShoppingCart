using ShoppingCart.Service.Models;
using System;
using System.Collections.Generic;

namespace ShoppingCart.Service.Interfaces
{
    public interface IBasketsService
    {
        IList<BasketDto> GetAll();

        void CreateBasket(BasketDto basket);

        BasketDto UpdateArticles(Guid basketId, ArticleDto article);
        
        ResponseBasket GetBasket(Guid id);
        
        BasketDto PartialUpdate(Guid id, BasketDto basket);
    }
}
