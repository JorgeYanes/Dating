using Dating.Api.Database;
using Dating.Api.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Dating.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly ILogger<UsersController> _logger;
        private readonly DataContext _context;

        public UsersController(DataContext context, ILogger<UsersController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<IEnumerable<AppUser>> GetUsers()
        {
            return _context.Users.ToList();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetUser(int id, CancellationToken cancellation)
        {
            return await _context.Users.FindAsync(id, cancellation);
        }

    }
}