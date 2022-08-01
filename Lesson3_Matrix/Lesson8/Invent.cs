using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
struct Invent
    {
        Fruit onion = new Fruit("apple", 0.67, 1);
        Fruit cucumber = new Fruit("pear", 2.74, 2);
        Fruit tomato = new Fruit("banana", 4.09, 3);
        Fruit potato = new Fruit("coconut", 0.99, 4);
        Fruit pumpkin = new Fruit("watermelon", 1.23, 5);
        private double Summ { get; set; }
        public Fruit[] Fruit { get; set; }
        public Invent(Fruit[] fruit):this()
        {
            Fruit = fruit;
        }

        public void Result()
        {
            Fruit[] arr = new Fruit[100];
            for (int i = 0; i < Fruit.Length; i++)
            {
                Console.WriteLine(Fruit[i].Display());
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
                        arr[NumOfMass] = onion;
                        SizeMass += 1;
                        break;
                    case 2:
                        arr[NumOfMass] = cucumber;
                        SizeMass += 1;
                        break;
                    case 3:
                        arr[NumOfMass] = tomato;
                        SizeMass += 1;
                        break;
                    case 4:
                        arr[NumOfMass] = potato;
                        SizeMass += 1;
                        break;
                    case 5:
                        arr[NumOfMass] = pumpkin;
                        SizeMass += 1;
                        break;
                    default:
                        Console.WriteLine("Error. Try again");
                        break;
                }
                Console.WriteLine("Do you want to continue(yes/no)?");//проверка на желание повторить
                string answer = Console.ReadLine();
                if (answer == "yes")
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
