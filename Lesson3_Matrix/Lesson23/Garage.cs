using System;
using System.Collections.Generic;

namespace Lesson23
{
    public partial class Garage
    {
        public int Id { get; set; }
        public string? CarType { get; set; }
        public int? SecurityLevel { get; set; }
        public int? CarId { get; set; }

        public virtual Car? Car { get; set; }
    }
}
