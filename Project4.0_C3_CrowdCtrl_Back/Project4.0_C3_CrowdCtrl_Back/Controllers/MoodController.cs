using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project4._0_C3_CrowdCtrl_Back.DAL;
using Project4._0_C3_CrowdCtrl_Back.Models;
using Project4._0_C3_CrowdCtrl_Back.Repositories;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Project4._0_C3_CrowdCtrl_Back.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class MoodController : ControllerBase
    {
        private readonly DataContext _context;

        public MoodController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<Mood>> GetMoods()
        {
            return await _context.Moods.Include(m => m.MoodType).Include(m => m.EventRecordingDevice).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetMoodById(int id)
        {
            var mood = await _context.Moods.Include(m => m.MoodType).Include(m => m.EventRecordingDevice).FirstOrDefaultAsync(m => m.MoodId == id);
            return mood == null ? NotFound() : Ok(mood);
        }

        [HttpPost/*, AllowAnonymous*/]
        public async Task<ActionResult> CreateMood(Mood mood)
        {
            await _context.Moods.AddAsync(mood);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(CreateMood), new { id = mood.MoodId }, mood);

        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateMood(int id, Mood mood)
        {
            if (id != mood.MoodId) return BadRequest();
            _context.Entry(mood).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeletMood(int id)
        {
            var moodToDelete = await _context.Moods.FindAsync(id);
            if (moodToDelete == null) return NotFound();

            _context.Moods.Remove(moodToDelete);
            await _context.SaveChangesAsync();

            return NoContent();

        }
    }
}
