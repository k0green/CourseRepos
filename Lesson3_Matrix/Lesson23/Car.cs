using System;
using System.Collections.Generic;

namespace Lesson23
{
    public partial class Car
    {
        public Car()
        {
            Garages = new HashSet<Garage>();
        }

        public int Id { get; set; }
        public string? Number { get; set; }
        public string? Model { get; set; }
        public int? OwnerId { get; set; }

        public virtual Driver? Owner { get; set; }
        public virtual ICollection<Garage> Garages { get; set; }
    }
}
