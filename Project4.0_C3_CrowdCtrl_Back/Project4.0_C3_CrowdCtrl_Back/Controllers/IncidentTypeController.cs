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
    public class IncidentTypeController : ControllerBase
    {
        private readonly DataContext _context;

        public IncidentTypeController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<IncidentType>> GetIncidentTypes()
        {
            return await _context.IncidentTypes.Include(i => i.Incidents).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetIncidentTypeById(int id)
        {
            var incidentType = await _context.IncidentTypes.Include(i => i.Incidents).FirstOrDefaultAsync(i => i.IncidentTypeId == id);
            return incidentType == null ? NotFound() : Ok(incidentType);
        }

        [HttpPost/*, AllowAnonymous*/]
        public async Task<ActionResult> CreateIncidentType(IncidentType incidentType)
        {
            await _context.IncidentTypes.AddAsync(incidentType);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(CreateIncidentType), new { id = incidentType.IncidentTypeId }, incidentType);

        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateIncidentType(int id, IncidentType incidentType)
        {
            if (id != incidentType.IncidentTypeId) return BadRequest();
            _context.Entry(incidentType).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteIncidentType(int id)
        {
            var incidentTypeToDelete = await _context.IncidentTypes.FindAsync(id);
            if (incidentTypeToDelete == null) return NotFound();

            _context.IncidentTypes.Remove(incidentTypeToDelete);
            await _context.SaveChangesAsync();

            return NoContent();

        }
    }
}


