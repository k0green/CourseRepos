using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{

    public class Inventory
    {
        Vegetable onion = new Vegetable("onion", 0.67, 1);
        Vegetable cucumber = new Vegetable("cucumber", 2.74, 2);
        Vegetable tomato = new Vegetable("tomato", 4.09, 3);
        Vegetable potato = new Vegetable("potato", 0.99, 4);
        Vegetable pumpkin = new Vegetable("pumpkin", 1.23, 5);
        private double Summ { get; set; }
        private Vegetable[] Vegetable { get; set; }
        public Inventory(Vegetable[] vegetable)
        {
            Vegetable = vegetable;
        }

        public void Price()
        {
            Vegetable[] arr = new Vegetable[100];
            for (int i = 0; i < Vegetable.Length; i++)
            {
                Console.WriteLine(Vegetable[i].Print());
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