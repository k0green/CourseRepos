using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15_CarCompany.Models
{
    internal class Bus:ICarTemplate
    {
        public string Company { get; set; }
        public string Model { get; set; }
        public int Id { get; set; }
        public int Year { get; set; }

    }
}
