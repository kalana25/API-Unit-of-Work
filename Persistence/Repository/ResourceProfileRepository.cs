using System;
using System.Collections.Generic;
using System.Text;
using Core.Repository;
using Entities;

namespace Persistence.Repository
{
    public class ResourceProfileRepository:Repository<ResourceProfile>,IResourceProfileRepository
    {
        public ResourceProfileRepository(DataBaseContext context):base(context)
        {
        }

        public DataBaseContext DataBaseContext
        {
            get
            {
                return context as DataBaseContext;
            }
        }
    }
}
