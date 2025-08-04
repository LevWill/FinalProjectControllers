using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FinalProjectControllers.Data;
using FinalProjectControllers.Models;

namespace FinalProjectControllers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HobbiesController : ControllerBase
    {
        private readonly AppDbContext _context;
        public HobbiesController(AppDbContext context) => _context = context;

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Hobby>>> GetHobbies()
            => await _context.Hobbies.Take(5).ToListAsync();

        [HttpGet("{id}")]
        public async Task<ActionResult<Hobby>> GetHobby(int id)
        {
            var hobby = await _context.Hobbies.FindAsync(id);
            return hobby == null ? NotFound() : Ok(hobby);
        }

        [HttpPost]
        public async Task<ActionResult<Hobby>> PostHobby(Hobby hobby)
        {
            _context.Hobbies.Add(hobby);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetHobby), new { id = hobby.Id }, hobby);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutHobby(int id, Hobby hobby)
        {
            if (id != hobby.Id) return BadRequest();
            _context.Entry(hobby).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHobby(int id)
        {
            var hobby = await _context.Hobbies.FindAsync(id);
            if (hobby == null) return NotFound();
            _context.Hobbies.Remove(hobby);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}