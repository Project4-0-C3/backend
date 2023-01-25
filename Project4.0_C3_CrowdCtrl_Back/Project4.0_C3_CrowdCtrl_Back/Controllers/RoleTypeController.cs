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
    public class RoleTypeController : ControllerBase
    {
        private readonly DataContext _context;

        public RoleTypeController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<RoleType>> GetRoleTypes()
        {
            return await _context.RoleTypes.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetRoleTypeById(int id)
        {
            var roleType = await _context.RoleTypes.FindAsync(id);
            return roleType == null ? NotFound() : Ok(roleType);
        }

        [HttpPost/*, AllowAnonymous*/]
        public async Task<ActionResult> CreateRoleType(RoleType roleType)
        {
            await _context.RoleTypes.AddAsync(roleType);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(CreateRoleType), new { id = roleType.RoleTypeId }, roleType);

        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateRoleType(int id, RoleType roleType)
        {
            if (id != roleType.RoleTypeId) return BadRequest();
            _context.Entry(roleType).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeletRoleType(int id)
        {
            var roleTypeToDelete = await _context.RoleTypes.FindAsync(id);
            if (roleTypeToDelete == null) return NotFound();

            _context.RoleTypes.Remove(roleTypeToDelete);
            await _context.SaveChangesAsync();

            return NoContent();

        }
    }
}
