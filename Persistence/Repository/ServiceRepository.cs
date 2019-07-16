using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using Core.Repository;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Persistence.Repository
{
    public class ServiceRepository : Repository<Service>, IServiceRepository
    {
        public ServiceRepository(DataBaseContext dbcontext):base(dbcontext)
        {
        }


        public async Task<IEnumerable<Service>> GetServicesBySpeciality(int specialityId)
        {
            return await DatabaseContext.Services
                .Include(s => s.Speciality)
                .Where(x => x.SpecialityId == specialityId)
                .ToListAsync();
        }

        public async Task<IEnumerable<Service>> GetServicesWithStyle(int pageIndex, int pageSize = 10)
        {
            return await DatabaseContext.Services
                .Include(s => s.Style)
                .OrderBy(s => s.Name)
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();
        }

        public DataBaseContext DatabaseContext
        {
            get { return context as DataBaseContext; }
        }
    }
}
