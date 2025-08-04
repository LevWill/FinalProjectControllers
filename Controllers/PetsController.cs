using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FinalProjectControllers.Data;
using FinalProjectControllers.Models;

namespace FinalProjectControllers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetsController : ControllerBase
    {
        private readonly AppDbContext _context;
        public PetsController(AppDbContext context) => _context = context;

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pets>>> GetPets()
            => await _context.Pets.Take(5).ToListAsync();

        [HttpGet("{id}")]
        public async Task<ActionResult<Pets>> GetPet(int id)
        {
            var pet = await _context.Pets.FindAsync(id);
            return pet == null ? NotFound() : Ok(pet);
        }

        [HttpPost]
        public async Task<ActionResult<Pets>> PostPet(Pets pet)
        {
            _context.Pets.Add(pet);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetPet), new { id = pet.Id }, pet);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutPet(int id, Pets pet)
        {
            if (id != pet.Id) return BadRequest();
            _context.Entry(pet).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePet(int id)
        {
            var pet = await _context.Pets.FindAsync(id);
            if (pet == null) return NotFound();
            _context.Pets.Remove(pet);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}