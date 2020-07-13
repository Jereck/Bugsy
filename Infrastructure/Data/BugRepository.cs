using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class BugRepository : IBugRepository
    {
        private readonly StoreContext _context;
        public BugRepository(StoreContext context)
        {
            _context = context;
        }

        public async Task<Bug> GetBugByIdAsync(int id)
        {
            return await _context.Bugs.FindAsync(id);
        }

        public async Task<IReadOnlyList<Bug>> GetBugsAsync()
        {
            return await _context.Bugs.ToListAsync();
        }
    }
}