using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Service.Interfaces;
using ShoppingCart.Service.Models;
using System;
using System.Collections.Generic;

namespace ShoppingCart.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BasketsController : ControllerBase
    {
        private readonly IBasketsService _basketsService;

        public BasketsController(IBasketsService basketsService)
        {
            _basketsService = basketsService;
        }

        [HttpGet]
        public ActionResult<IList<BasketDto>> GetAll()
        {
            return Ok(_basketsService.GetAll());
        }

        [HttpPost]
        public IActionResult CreateBasket(BasketDto basket)
        {
            _basketsService.CreateBasket(basket);

            return StatusCode(201);
        }

        [HttpPut("{id}/article-line")]
        public ActionResult<BasketDto> UpdateArticleLine(Guid id, [FromBody]ArticleDto article)
        {
            return Ok(_basketsService.UpdateArticles(id, article));
        }

        [HttpGet("{id}")]
        public ActionResult<ResponseBasket> GetBasket(Guid id)
        {
            var response = _basketsService.GetBasket(id);
            if (response == null)
            {
                return NotFound();
            }

            return Ok(response);
        }

        [HttpPatch("{id}")]
        public ActionResult<BasketDto> UpdateBasket(Guid id, BasketDto basket)
        {
            var response = _basketsService.PartialUpdate(id, basket);

            if (response == null)
            {
                return NotFound();
            }

            return Ok(response);
        }
    }
}
