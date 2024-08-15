using ApplicationCore.Avelam.Interfaces;
using ApplicationCore.Avelam.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Avelam.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderRepository _repository;

        public OrderController(IOrderRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(Order order)
        {
            try
            {
                await _repository.Create(order);
                return Ok(new { message = "Criado com sucesso"});
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAsync(Order order)
        {
            try
            {
                await _repository.Update(order);
                return Ok(new { message = "Atualizado com sucesso" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("id:long")]
        public async Task<IActionResult> DeleteAsync(long id)
        {
            try
            {
                await _repository.Delete(id);
                return Ok(new { message = "Atualizado com sucesso" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            try
            {
                return Ok(await _repository.GetAll());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("id:long")]
        public async Task<IActionResult> GetByIdAsync(long id)
        {
            try
            {
                Order order = await _repository.GetById(id);

                if (order is not null) return Ok(order);
                else return NotFound(new { message = "Pedido não encontrado" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
