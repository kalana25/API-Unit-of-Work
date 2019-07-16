using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using System.Linq;
using Core.Repository;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Repository
{
    public class StyleRepository:Repository<Style>,IStyleRepository
    {
        public StyleRepository(DataBaseContext context):base(context)
        {

        }

        public IEnumerable<Style> GetCustomStyles(bool customStyle)
        {
            return DatabaseContext.Styles
                .Include(s=>s.Services)
                .Where(x => x.CustomStyle == customStyle)
                .ToList();
        }

        public IEnumerable<Style> GetStylesWithServices(int pageIndex, int pageSize)
        {
            return DatabaseContext.Styles
                .Include(s=>s.Services)
                .OrderBy(s=>s.Name)
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .ToList();
        }

        public DataBaseContext DatabaseContext
        {
            get { return context as DataBaseContext; }
        }

    }

}
