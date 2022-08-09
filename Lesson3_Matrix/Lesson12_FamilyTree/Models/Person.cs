using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12_FamilyTree.Models
{
    internal class Person
    {
        public string Name { get; set; }
        public string Sex { get; set; }
        public int Age { get; set; }

        public Person(string name, string sex, int age)
        {
            Name = name;
            Sex = sex;
            Age = age;

        }
    }
}
