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
    public class UserController : ControllerBase
    {
        private readonly DataContext _context;

        public UserController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<User>> GetUsers(int? role)
        {

            if (role != null) {
                return await _context.Users.Where(u => u.RoleTypeId == role).ToListAsync();
            } else { 
                return await _context.Users.Include(u => u.RoleType).ToListAsync();
            }
        }

        [HttpGet("{email},{password}")]

        public async Task<IActionResult> GetUserLogin(string email, string password)
        {
            var user = await _context.Users.Include(u => u.RoleType).FirstOrDefaultAsync(u => u.Email == email && u.Password == password);
            return user == null ? NotFound() : Ok(user); ;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserById(int id)
        {
            var user = await _context.Users.Include(u => u.EventUsers).Include(u => u.GroupGuards).Include(u => u.RoleType).FirstOrDefaultAsync(u => u.UserId == id);
            return user == null ? NotFound() : Ok(user);
        }

        [HttpPost/*, AllowAnonymous*/]
        public async Task<ActionResult> CreateUser(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(CreateUser), new { id = user.UserId }, user);

        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateUser(int id, User user)
        {
            if (id != user.UserId) return BadRequest();
            _context.Entry(user).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteUser(int id)
        {
            var userToDelete = await _context.Users.FindAsync(id);
            if (userToDelete == null) return NotFound();

            _context.Users.Remove(userToDelete);
            await _context.SaveChangesAsync();

            return NoContent();

        }
    }
}
