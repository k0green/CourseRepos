using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    public struct Invent
    {
        private double Summ { get; set; }
        public Fruit[] Fruits { get; set; }
        public Invent(Fruit[] fruit) : this()
        {
            Fruits = fruit;
        }
        public Fruit this[int index]
        {
            get
            {
                return Fruits[index];
            }
            set
            {
                Fruits[index] = value;
            }
        }
        public Fruit this[string name]
        {
            get
            {
                foreach (var fruit in Fruits)
                {
                    if (fruit.Name == name) return fruit;
                }
                throw new Exception("Error");
            }
            set
            {
                this[name] = value;
            }
        }
        public void Result()
        {
            Fruit[] arr = new Fruit[100];
            for (int i = 0; i < Fruits.Length; i++)
            {
                Console.WriteLine(Fruits[i].Display());
            }
            bool check = false;
            int NumOfMass = 0;
            int SizeMass = 0;
            do
            {
                Console.WriteLine("Enter Vegetable");
                int num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        arr[NumOfMass] = Fruits[0];
                        SizeMass += 1;
                        break;
                    case 2:
                        arr[NumOfMass] = Fruits[1];
                        SizeMass += 1;
                        break;
                    case 3:
                        arr[NumOfMass] = Fruits[2];
                        SizeMass += 1;
                        break;
                    case 4:
                        arr[NumOfMass] = Fruits[3];
                        SizeMass += 1;
                        break;
                    case 5:
                        arr[NumOfMass] = Fruits[4];
                        SizeMass += 1;
                        break;
                    default:
                        Console.WriteLine("Error. Try again");
                        break;
                }
                Console.WriteLine("Do you want to continue(yes/no)?");//проверка на желание повторить
                string answer = Console.ReadLine();
                if (answer == "yes" && answer != null)
                {
                    check = true;
                }
                else
                {
                    check = false;
                }
                NumOfMass++;
            } while (check == true);
            for (int i = 0; i < SizeMass; i++)
            {
                Console.WriteLine(arr[i].Display());
            }
            double sum = 0;
            for (int i = 0; i < SizeMass; i++)
            {
                sum += arr[i].Coast;
            }
            Console.WriteLine(sum);
        }
    }
}