using ApplicationCore.Avelam.Interfaces;
using ApplicationCore.Avelam.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Avelam.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class SweetController : Controller
    {
        private readonly ISweetRepository _repository;

        public SweetController(ISweetRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(Sweet sweet)
        {
            try
            {
                await _repository.Create(sweet);
                return Ok(new { message = "Criado com sucesso" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAsync(Sweet sweet)
        {
            try
            {
                await _repository.Update(sweet);
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

        [HttpGet("id:int")]
        public async Task<IActionResult> GetByIdAsync(long id)
        {
            try
            {
                Sweet sweet = await _repository.GetById(id);

                if (sweet is not null) return Ok(sweet);
                else return NotFound(new { message = "Doce não encontrado" });

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
