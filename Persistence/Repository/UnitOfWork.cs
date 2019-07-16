using System;
using System.Collections.Generic;
using System.Text;
using Core.Repository;

namespace Persistence.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataBaseContext context;
        public IServiceRepository Services { get; private set; }
        public IStyleRepository Styles { get; private set; }
        public IResourceProfileRepository ResourceProfiles { get; private set; }

        public UnitOfWork(DataBaseContext context)
        {
            this.context = context;
            this.Services = new ServiceRepository(this.context);
            this.Styles = new StyleRepository(context);
            this.ResourceProfiles = new ResourceProfileRepository(context);
        }

        public int Complete()
        {
            return context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
