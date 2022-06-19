using System;

namespace Lesson3_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter amount of string:"); //создание матрицы
            int AmountOfSting = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter amount of column:");
            int AmountOfColumn= Convert.ToInt32(Console.ReadLine());
            int[,] Matrix = new int[AmountOfSting, AmountOfColumn];
            Console.WriteLine("Enter elements:");
            for (int i = 0; i < AmountOfSting; i++)
            {
                for (int j = 0; j < AmountOfColumn; j++)
                {
                    Console.Write($"Matrix[{i+1},{j+1}]=");
                    Matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Show elements:");
            for (int i = 0; i < AmountOfSting; i++)
            {
                for (int j = 0; j < AmountOfColumn; j++)               
                    Console.Write($"{Matrix[i, j]} ");       
                    Console.Write("\n");
            }

            bool check = false;//проверка на желание
            do
            {
                Console.WriteLine("Do you want to do some features?");
            Console.WriteLine("Enter:\n1-Find num of positive and negative nubers;\n" +
                "2-Sort string;");
            int NumOfFeature = Convert.ToInt32(Console.ReadLine());//выбор операции
            switch(NumOfFeature)
            {
                case 1:
                    int PositiveAmount = 0, NegativeAmount = 0; ;
                    for (int i = 0; i < AmountOfSting; i++)
                    {
                        for (int j = 0; j < AmountOfColumn; j++)
                        {
                            if (Matrix[i, j] > 0) 
                            {
                                PositiveAmount++;
                            }
                            else if(Matrix[i, j] < 0)
                            {
                                NegativeAmount++;
                            }
                        }
                    }
                    Console.WriteLine($"Number of positive numbers is {PositiveAmount}\n" +
                                  $"Number of negstive numbers is {NegativeAmount}");
                    break;
                case 2:

                    Console.WriteLine("Enter:\n1-Sort string ascending;\n2-Sort string descending;\n" +//выбор подоперации
                        "3-Sort for string inversion");
                    int NumOfTask = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("To do this operatoin you need to enter number of string," +//ввод строки которая будет меняться
                        " which you want to sort ");
                    int NumOfString = Convert.ToInt32(Console.ReadLine());
                    NumOfString -= 1;
                    int temp;
                    switch (NumOfTask)
                    {
                       case 1:
                            for (int i = 0; i < AmountOfColumn - 1; i++)//сортировка по возрастанию
                            {
                                for (int j = 0; j < AmountOfColumn - i - 1; j++)
                                {
                                    if (Matrix[NumOfString, j]> Matrix[NumOfString, j+1])
                                    {
                                        temp = Matrix[NumOfString, j];
                                        Matrix[NumOfString, j] = Matrix[NumOfString, j + 1];
                                        Matrix[NumOfString, j + 1] = temp;
                                    }
                                } 
                            }
                        break;
                       case 2:
                            for (int i = 0; i < AmountOfColumn - 1; i++)//сортировка по убыванию
                            {
                                for (int j = 0; j < AmountOfColumn - i - 1; j++)
                                {
                                    if (Matrix[NumOfString, j] < Matrix[NumOfString, j + 1])
                                    {
                                        temp = Matrix[NumOfString, j];
                                        Matrix[NumOfString, j] = Matrix[NumOfString, j + 1];
                                        Matrix[NumOfString, j + 1] = temp;
                                    }
                                }
                            }
                            break;
                        case 3:                            
                            for (int i = 0; i < AmountOfColumn/2; i++)//инверсирование
                            {
                                    temp = Matrix[NumOfString, i];
                                    Matrix[NumOfString, i] = Matrix[NumOfString, AmountOfColumn-i-1];
                                    Matrix[NumOfString, AmountOfColumn-i-1] = temp;
                            }
                            break;
                    }
                    break;
            }
            Console.WriteLine("Show new elements:");//вывод измененной матрицы
            for (int i = 0; i < AmountOfSting; i++)
            {
                for (int j = 0; j < AmountOfColumn; j++)
                    Console.Write($"{Matrix[i, j]} ");
                Console.Write("\n");
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
            } while (check == true);
            Console.ReadKey();
        }
    }
}
