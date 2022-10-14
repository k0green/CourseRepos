using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12_FamilyTree.Models
{
    internal class Son:Person
    {
        private Mother m;
        private Father f;
        public Son(string name, string sex, int age, Mother mother, Father father) : base(name, sex, age)
        {
            Name = name;
            Age = age;
            Sex = sex;
            m = mother;
            f = father;
        }
        public void SonInfo()
        {
            var ma = m.GetMothersName();
            var fa = f.GetFathersName();
            Console.WriteLine($"I'm {ma.ToString()} and {fa.ToString()} son\n Info about me:\nName: {Name} Sex: {Sex} Age: {Age}");
        }
    }
}
