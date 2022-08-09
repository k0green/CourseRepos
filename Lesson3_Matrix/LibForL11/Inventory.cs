using System;

namespace Lesson8
{

    public class Inventory
    {
        Vegetable[] Vegetables;
        public Inventory(Vegetable[] vegetable)
        {
            Vegetables = vegetable;
        }
        public Vegetable this[int index]
        {
            get
            {
                return Vegetables[index];
            }
            set
            {
                Vegetables[index] = value;
            }
        }

        public Vegetable this[string name]//change idexer
        {
            get
            {
                foreach (var vegetable in Vegetables)
                {
                    if (vegetable.Name == name) return vegetable;
                }
                throw new Exception("Error");
            }
            set
            {
                this[name] = value;
            }
        }
        public void Price()
        {
            Vegetable[] arr = new Vegetable[100];
            for (int i = 0; i < Vegetables.Length; i++)
            {
                Console.WriteLine(Vegetables[i].Print());
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
                        arr[NumOfMass] = Vegetables[0];
                        SizeMass += 1;
                        break;
                    case 2:
                        arr[NumOfMass] = Vegetables[1];
                        SizeMass += 1;
                        break;
                    case 3:
                        arr[NumOfMass] = Vegetables[2];
                        SizeMass += 1;
                        break;
                    case 4:
                        arr[NumOfMass] = Vegetables[3];
                        SizeMass += 1;
                        break;
                    case 5:
                        arr[NumOfMass] = Vegetables[4];
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
                Console.WriteLine(arr[i].Print());
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