using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using System.Threading.Tasks;

namespace Core.Repository
{
    public interface IServiceRepository:IRepository<Service>
    {
        Task<IEnumerable<Service>> GetServicesBySpeciality(int specialityId);
        Task<IEnumerable<Service>> GetServicesWithStyle(int pageIndex, int pageSize);
    }
}
