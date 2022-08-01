using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12_FamilyTree.Models
{
    internal class Father:Person
    {
        private Son _son;
        public Son Son { set; get; }
        public List<Son>? Sons { get; set; }
        public List<Dauther>? Dauthers { get; set; }

        public Father(string name, string sex, int age) : base(name, sex, age)
        {
            Name = name??"undifined";
            Age = age;
            Sex = sex ?? "undifined";
            List<Dauther> daughters = new List<Dauther>();
            Dauthers = daughters;
            List<Son> sons = new List<Son>();
            Sons = sons;
        }
        public void AddSon(Son son)
        {
            Sons.Add(son);
        }
        public void AddDaughter(Dauther dauther)
        {
            Dauthers.Add(dauther);
        }
        public string GetFathersName()
        {
            return Name;
        }
        public void FatherInfo()
        {
            Console.WriteLine($"Info about me:\nName: {Name} Sex: {Sex} Age: {Age}\n My children");
            foreach (var s in Sons)
            {
                Console.WriteLine(s.Name.ToString());
            }
            foreach (var d in Dauthers)
            {
                Console.WriteLine(d.Name.ToString());
            }

        }
    }
}
