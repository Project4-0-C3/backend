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
    public class MoodTypeController : ControllerBase
    {
        private readonly DataContext _context;

        public MoodTypeController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<MoodType>> GetMoodTypes()
        {
            return await _context.MoodTypes.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetMoodTypeById(int id)
        {
            var moodType = await _context.MoodTypes.FindAsync(id);
            return moodType == null ? NotFound() : Ok(moodType);
        }

        [HttpPost/*, AllowAnonymous*/]
        public async Task<ActionResult> CreateMoodType(MoodType moodType)
        {
            await _context.MoodTypes.AddAsync(moodType);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(CreateMoodType), new { id = moodType.MoodTypeId }, moodType);

        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateMoodType(int id, MoodType moodType)
        {
            if (id != moodType.MoodTypeId) return BadRequest();
            _context.Entry(moodType).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeletMoodType(int id)
        {
            var moodTypeToDelete = await _context.MoodTypes.FindAsync(id);
            if (moodTypeToDelete == null) return NotFound();

            _context.MoodTypes.Remove(moodTypeToDelete);
            await _context.SaveChangesAsync();

            return NoContent();

        }
    }
}
