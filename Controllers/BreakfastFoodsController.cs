using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FinalProjectControllers.Data;
using FinalProjectControllers.Models;

namespace FinalProjectControllers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BreakfastFoodsController : ControllerBase
    {
        private readonly AppDbContext _context;
        public BreakfastFoodsController(AppDbContext context) => _context = context;

        [HttpGet]
        public async Task<ActionResult<IEnumerable<BreakfastFood>>> GetBreakfastFoods()
            => await _context.BreakfastFoods.Take(5).ToListAsync();

        [HttpGet("{id}")]
        public async Task<ActionResult<BreakfastFood>> GetBreakfastFood(int id)
        {
            var item = await _context.BreakfastFoods.FindAsync(id);
            return item == null ? NotFound() : Ok(item);
        }

        [HttpPost]
        public async Task<ActionResult<BreakfastFood>> PostBreakfastFood(BreakfastFood food)
        {
            _context.BreakfastFoods.Add(food);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetBreakfastFood), new { id = food.Id }, food);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutBreakfastFood(int id, BreakfastFood food)
        {
            if (id != food.Id) return BadRequest();
            _context.Entry(food).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBreakfastFood(int id)
        {
            var item = await _context.BreakfastFoods.FindAsync(id);
            if (item == null) return NotFound();
            _context.BreakfastFoods.Remove(item);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}