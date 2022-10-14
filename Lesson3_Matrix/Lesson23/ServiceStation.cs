using System;
using System.Collections.Generic;

namespace Lesson23
{
    public partial class ServiceStation
    {
        public int Id { get; set; }
        public string? Specialization { get; set; }
        public int? MechanicId { get; set; }

        public virtual Mechanic? Mechanic { get; set; }
    }
}
