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
    public class EventRecordingDeviceController : ControllerBase
    {
        private readonly DataContext _context;

        public EventRecordingDeviceController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<EventRecordingDevice>> GetEventRecordingDevices()
        {
            return await _context.EventRecordingDevices.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetEventRecordingDeviceById(int id)
        {
            var eventRecordingDevice = await _context.EventRecordingDevices.FindAsync(id);
            return eventRecordingDevice == null ? NotFound() : Ok(eventRecordingDevice);
        }

        [HttpPost/*, AllowAnonymous*/]
        public async Task<ActionResult> CreateEventRecordingDevice(EventRecordingDevice eventRecordingDevice)
        {
            await _context.EventRecordingDevices.AddAsync(eventRecordingDevice);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(CreateEventRecordingDevice), new { id = eventRecordingDevice.EventRecordingDeviceId }, eventRecordingDevice);

        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateEventRecordingDevice(int id, EventRecordingDevice eventRecordingDevice)
        {
            if (id != eventRecordingDevice.EventRecordingDeviceId) return BadRequest();
            _context.Entry(eventRecordingDevice).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteEventRecordingDevice(int id)
        {
            var eventRecordingDeviceToDelete = await _context.EventRecordingDevices.FindAsync(id);
            if (eventRecordingDeviceToDelete == null) return NotFound();

            _context.EventRecordingDevices.Remove(eventRecordingDeviceToDelete);
            await _context.SaveChangesAsync();

            return NoContent();

        }
    }
}

