using System;
using System.Collections.Generic;
using System.Text;
using Entities;

namespace Core.Repository
{
    public interface IStyleRepository:IRepository<Style>
    {
        IEnumerable<Style> GetCustomStyles(bool customStyle);
        IEnumerable<Style> GetStylesWithServices(int pageIndex, int pageSize);
    }
}
