using DevFreela.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Core.Repositories
{
    public interface ICalendarioCQRepository
    {
        Task<List<CalendarioCQ>> GetAllAsync();
        Task<CalendarioCQ> GetByIdAsync(int id);
        Task AddAsync(CalendarioCQ calendarioCQ);       
        Task SaveChangesAsync();
    }
}
