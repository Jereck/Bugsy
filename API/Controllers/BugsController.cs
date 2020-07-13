using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BugsController : ControllerBase
    {
        private readonly StoreContext _context;
        public BugsController(StoreContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Bug>>> GetBugs()
        {
            var bugs = await _context.Bugs.ToListAsync();

            return Ok(bugs);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Bug>> GetBug(int id)
        {
            return await _context.Bugs.FindAsync(id);
        }
    }
}