using System;
using System.Collections.Generic;

namespace Lesson23
{
    public partial class Mechanic
    {
        public Mechanic()
        {
            ServiceStations = new HashSet<ServiceStation>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public int? Age { get; set; }
        public string? Phone { get; set; }
        public string? Specialization { get; set; }
        public int Level { get; set; }

        public virtual ICollection<ServiceStation> ServiceStations { get; set; }
    }
}
