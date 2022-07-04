using System;
using System.IO;
using System.Linq;

namespace Lesson4_Strings
{
    class Program
    {
        static void FindWordWithMaxNum(string text)
        {
            string[] str = text.Split(' ');
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
        }
        static void FindTheLongestWord(string text)
        {
            string maxim = String.Empty;
            string[] words = text.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                if (word != string.Empty && word.Length > maxim.Length)
                    maxim = word;
            }
            (string, string)tuple3=(maxim, "Таких слов нет");
            Console.WriteLine(tuple3.Item1 == String.Empty ? tuple3.Item2 : ($"The word is {tuple3.Item1}"));
        }
        static string ChangeNum(string text)
        {
            var tuple2=("1", "2", "3", "4", "5", "6");
            text = text.Replace(tuple2.Item1, "one");
            text = text.Replace(tuple2.Item2, "two");
            text = text.Replace(tuple2.Item3, "three");
            text = text.Replace(tuple2.Item4, "four");
            text = text.Replace(tuple2.Item5, "five");
            text = text.Replace(tuple2.Item6, "six");
            return text;
        }
        static void FindQestAndExcepMark(string text)
        {
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
        }
        static void SentenceWithoutCom(string text)
        {
            string[] text1 = text.Split(new char[] { '!', '?', '.' });
            for (int i = 0; i < text1.Length; i++)
            {
                bool hasCom = text1[i].Contains(",");
                if (hasCom == false)
                {
                    Console.WriteLine("This is sentense without comma mark");
                    Console.WriteLine(text1[i]);
                }
            }
        }
        static void SimilarLetter(string text)
        {
            string[] array = text.Split(' ');
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i][0] == array[i][array[i].Length - 1])
                {
                    Console.WriteLine(array[i]);
                }
            }
        }
        static (double summ, double otnimanie, double multiple, double delenie) MethodForMethod(int number)
        {
            int a = 5;
            return (number + a, number - a, number * a, number / a);
        }
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
            bool check = false;//проверка на желание
            do {
                Console.WriteLine(text);
                var tuple1 =(task:"Enter number of task", "1 - Найти слова, содержащие максимальное количество цифр","2 - Найти самое длинное слово и определить",
                "3-Заменить цифры от 0 до 9 на слова «ноль», «один», …, «девять».",
                "4-Вывести на экран сначала вопросительные, а затем восклицательные предложения.","5-Вывести на экран только предложения, " +
                "не содержащие запятых;","6-Найти слова, начинающиеся и заканчивающиеся на одну и ту же букву." );
                Console.WriteLine(tuple1.task);
                Console.WriteLine(tuple1.Item2);
                Console.WriteLine(tuple1.Item3);
                Console.WriteLine(tuple1.Item4);
                Console.WriteLine(tuple1.Item5);
                Console.WriteLine(tuple1.Item6);
                Console.WriteLine(tuple1.Item7);
                int task = Convert.ToInt32(Console.ReadLine());
                Commands comands = (Commands)task;
                switch (comands)
            {
                case Commands.FindWordWithMaxNum:
                        FindWordWithMaxNum(text);
                    break;
                case Commands.FindTheLongestWord:
                        FindTheLongestWord(text);
                    break;
                case Commands.ChangeNum:
                        text=ChangeNum(text);
                    break;
                case Commands.FindQestAndExcepMark:
                        FindQestAndExcepMark(text);
                    break;
                case Commands.SentenceWithoutCom:
                        SentenceWithoutCom(text);
                    break;
                case Commands.SimilarLetter:                     
                        SimilarLetter(text);    
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
            var tuple4 = MethodForMethod(6);
            Console.WriteLine($"Result work MethodForMethod is {tuple4}");
        }
        enum Commands
        {
            FindWordWithMaxNum=1,
            FindTheLongestWord=2,
            ChangeNum=3,
            FindQestAndExcepMark=4,
            SentenceWithoutCom=5,
            SimilarLetter=6,
        }
    }
}
