using FirstCrud_HT.Services;
using FirstCrudAPI_Hometask.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstCrud_HT.Controllers
{
    [ApiController]
    [Route("api/controller")]
    public class OrderController : ControllerBase
    {
        private readonly OrderService _orderService;

        public OrderController(OrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet("api/orders")]
        public IActionResult GetAllOrders([FromQuery] int pageToken, [FromQuery] int pageSize, [FromServices] OrderService orderService)
        {
            var result = _orderService.Get(order => true).Skip((pageToken - 1) * pageSize).Take(pageSize).ToList();
            return result.Any() ? Ok(result) : NotFound();
        }

        [HttpGet("api/orders/:id")]
        public async ValueTask<IActionResult> GetById([FromRoute] Guid orderId)
        {
            var result = await _orderService.GetByIdAsync(orderId);
            return result is not null ? Ok(result) : NotFound(orderId);
        }

        [HttpPost("api/orders")]
        public async ValueTask<IActionResult> CreateAsync(Order order)
        {
            var result = _orderService.CraeteAsync(order);
            return CreatedAtAction(nameof(GetById), new { orderId = order.Id }, result);
        }

        [HttpPut("api/orders")]
        public async ValueTask<IActionResult> UpdateAsync([FromBody] Order order)
        {
            var result = _orderService.UpdateAsync(order);
            return NoContent();
        }

        [HttpDelete]
        public async ValueTask<IActionResult> DeleteAsync([FromRoute] Guid orderId)
        {
            await _orderService.DaleteAsync(orderId);
            return NoContent();
        }
    }
}
