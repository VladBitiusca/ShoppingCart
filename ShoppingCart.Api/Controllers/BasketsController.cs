using Microsoft.AspNetCore.Mvc;
using System;

namespace ShoppingCart.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BasketsController : ControllerBase
    {
        [HttpPost]
        public IActionResult CreateBasket()
        {

            return StatusCode(201);
        }

        [HttpPut("{id}/article-line")]
        public IActionResult UpdateBasket([FromRoute]Guid id)
        {

            return NoContent();
        }

        [HttpGet("{id}")]
        public IActionResult GetBasket([FromRoute]Guid id)
        {

            return Ok();
        }
    }
}
