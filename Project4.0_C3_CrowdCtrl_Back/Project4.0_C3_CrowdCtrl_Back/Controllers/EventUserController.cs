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
    public class EventUserController : ControllerBase
    {
        private readonly DataContext _context;

        public EventUserController(DataContext context)
        {
            _context = context;
        }

        //[HttpGet]
        //public async Task<IEnumerable<EventUser>> GetEventUsers()
        //{
        //    return await _context.EventUsers.Include(e => e.User).Include(e => e.Event).ToListAsync();
        //}

        [HttpGet]
        public async Task<IEnumerable<EventUser>> GetEventUsers(int? @event, int? role)
        {
            if (@event != null && role != null)
            {
                return await _context.EventUsers.Include(e => e.User).Where(e => e.EventId == @event).Where(e => e.User.RoleTypeId == role).ToListAsync();
            }
            else
            {
                return await _context.EventUsers.Include(e => e.User).Include(e => e.Event).ToListAsync();

            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetEventUserById(int id)
        {
            var eventUser = await _context.EventUsers.Include(e => e.User).Include(e => e.Event).FirstOrDefaultAsync(i => i.EventUserId == id);
            return eventUser == null ? NotFound() : Ok(eventUser);
        }

        [HttpPost/*, AllowAnonymous*/]
        public async Task<ActionResult> CreateEventUser(EventUser eventUser)
        {
            await _context.EventUsers.AddAsync(eventUser);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(CreateEventUser), new { id = eventUser.EventUserId }, eventUser);

        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateEventUser(int id, EventUser eventUser)
        {
            if (id != eventUser.EventUserId) return BadRequest();
            _context.Entry(eventUser).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteEventUser(int id, int? eventId)
        {
            var eventUserToDelete = await _context.EventUsers.FindAsync(id);
            if (eventId != null) { 
                eventUserToDelete = await _context.EventUsers.Where(e => e.EventId == eventId).FirstAsync(e => e.UserId == id); 
            }
            if (eventUserToDelete == null) return NotFound();

            _context.EventUsers.Remove(eventUserToDelete);
            await _context.SaveChangesAsync();

            return NoContent();

        }
    }
}
