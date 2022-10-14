using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12_FamilyTree.Models
{
    internal class Mother:Person
    {
        private Dauther _dauther;
        public Dauther Daugher { set; get; }
        public List<Son>? Sons { get; set; }
        public List<Dauther>? Dauthers { get; set; } 

        public Mother(string name, string sex, int age):base(name, sex, age)
        {
            Name = name;
            Age = age;
            Sex=sex;
            List<Dauther> daughters=new List<Dauther>();
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
        public string GetMothersName()
        {
            return Name;
        }
        public void MotherInfo()
        {
            Console.WriteLine($"Info about me:\nName: {Name} Sex: {Sex} Age: {Age}\n My children");
            foreach(var s in Sons)
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
