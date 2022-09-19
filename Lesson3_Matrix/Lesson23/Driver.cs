using System;
using System.Collections.Generic;

namespace Lesson23
{
    public partial class Driver
    {
        public Driver()
        {
            Cars = new HashSet<Car>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public int? Age { get; set; }
        public string? Phone { get; set; }
        public int Experience { get; set; }

        public virtual ICollection<Car> Cars { get; set; }
    }
}
