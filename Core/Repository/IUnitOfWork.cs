using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Repository
{
    public interface IUnitOfWork: IDisposable
    {
        IServiceRepository Services { get; }
        IStyleRepository Styles { get; }
        IResourceProfileRepository ResourceProfiles { get; }
        int Complete();
    }
}
