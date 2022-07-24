using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    public struct Invent
    {
        private static Fruit apple = new Fruit("apple", 0.67, 6);
        private static Fruit pear = new Fruit("pear", 2.54, 7);
        private static Fruit banana = new Fruit("banana", 1.39, 8);
        private static Fruit coconut = new Fruit("coconut", 6.68, 9);
        private static Fruit watermelon = new Fruit("watermelon", 1, 10);
        private double Summ { get; set; }
        public Fruit[] Fruit { get; set; }
        public Invent(Fruit[] fruit) : this()
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
                        arr[NumOfMass] = apple;
                        SizeMass += 1;
                        break;
                    case 2:
                        arr[NumOfMass] = pear;
                        SizeMass += 1;
                        break;
                    case 3:
                        arr[NumOfMass] = banana;
                        SizeMass += 1;
                        break;
                    case 4:
                        arr[NumOfMass] = coconut;
                        SizeMass += 1;
                        break;
                    case 5:
                        arr[NumOfMass] = watermelon;
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