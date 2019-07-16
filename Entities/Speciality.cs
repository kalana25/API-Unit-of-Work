using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Speciality
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Service> Services { get; set; }
    }
}
