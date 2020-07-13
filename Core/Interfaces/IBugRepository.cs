using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interfaces
{
    public interface IBugRepository
    {
        Task<Bug> GetBugByIdAsync(int id);
        Task<IReadOnlyList<Bug>> GetBugsAsync();
    }
}