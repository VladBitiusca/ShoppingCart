using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Service.Interfaces;
using ShoppingCart.Service.Models;
using System;

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

        [HttpPost]
        public IActionResult CreateBasket(BasketDto basket)
        {
            _basketsService.CreateBasket(basket);

            return StatusCode(201);
        }

        [HttpPut("{id}/article-line")]
        public IActionResult UpdateArticleLine(Guid id)
        {

            return NoContent();
        }

        [HttpGet("{id}")]
        public IActionResult GetBasket(Guid id)
        {
            var result = new ResponseBasket();
            return Ok(result);
        }

        [HttpPatch("{id}")]
        public IActionResult UpdateBasket(Guid id)
        {
            return Ok();
        }
    }
}
