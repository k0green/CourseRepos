using System;
using System.IO;
using System.Linq;

namespace Lesson4_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Egor\Lesson4_Strings.txt";
            bool checks=false;
            do
           {            
            if (!File.Exists(path))
            {
                Console.WriteLine("Error file open");
                    checks = true;
            }
            else
            {
                Console.WriteLine("open file");
                    checks = false;
                }
           } while (checks == true);
            string text = File.ReadAllText(path);
            string[] text1 = text.Split(new char[] { '!', '?', '.' });            
            bool check = false;//проверка на желание
            do {
                Console.WriteLine(text);
            Console.WriteLine("Enter number of task\n1-Найти слова, содержащие максимальное количество цифр\n2-Найти самое длинное слово и определить\n"+
                "3-Заменить цифры от 0 до 9 на слова «ноль», «один», …, «девять».\n"+
                "4-Вывести на экран сначала вопросительные, а затем восклицательные предложения.\n5-Вывести на экран только предложения, " +
                "не содержащие запятых\n6-Найти слова, начинающиеся и заканчивающиеся на одну и ту же букву.");
            int task = Convert.ToInt32(Console.ReadLine());
            switch (task)
            {
                case 1:
                        string[] str =text.Split(' ');
                        int max = 0;
                        int index = 0;
                        for (int i = 0; i < str.Length; i++)
                        {
                            int currmax = 0;
                            for (int k = 0; k < str[i].Length; k++)
                            {
                                if (char.IsNumber(str[i][k]))
                                {
                                    currmax++;

                                }
                            }
                            if (currmax > max)
                            {
                                max = currmax;
                                index = i;
                            }
                        }
                        Console.WriteLine("Наибольше цифр в слове " + str[index]);
                        break;
                case 2:
                    string maxim = String.Empty;
                    string[] words = text.Split(' ');
                    for (int i = 0; i < words.Length; i++)
                    {                        
                        string word = words[i];
                        if (word != string.Empty && word.Length > maxim.Length)
                            maxim = word;
                    }
                    Console.WriteLine(maxim == String.Empty ? "Таких слов нет" : ($"The word is {maxim}"));
                    break;
                case 3:
                    text = text.Replace("1", "one");
                    text = text.Replace("2", "two");
                    text = text.Replace("3", "three");
                    text = text.Replace("4", "four");
                    text = text.Replace("5", "five");
                    text = text.Replace("6", "six");
                    break;
                case 4:
                        string[] question = text.Split('?');

                        foreach (string st in question)
                        {
                            string[] split = st.Split('.', '!');                            
                            Console.WriteLine(split[split.Length - 1]);
                        }

                        string[] exclamation = text.Split('!');

                        foreach (string st in exclamation)
                        {
                            string[] split = st.Split('.', '?');                            
                            Console.WriteLine(split[split.Length - 1]);
                        }
                        break;
                case 5:
                    for (int i = 0; i < text1.Length; i++)
                    {
                        bool hasCom = text1[i].Contains(",");
                        if(hasCom==false)
                        {
                            Console.WriteLine("This is sentense without comma mark");
                            Console.WriteLine(text1[i]);
                        }
                    }
                    break;
                case 6:                     
                        string[] array = text.Split(' ');
                        for (int i = 0; i < array.Length; i++)
                        {
                            if (array[i][0] == array[i][array[i].Length - 1])
                            {
                                Console.WriteLine(array[i]);
                            }
                        }
                        break;
                default:
                    Console.WriteLine("Enter error. Try again!");
                    break;
            }
            Console.WriteLine($"\n{ text}");
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
        }
    }
}
