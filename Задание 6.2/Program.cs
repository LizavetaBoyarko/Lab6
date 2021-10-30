using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение: ");
            string startString = Console.ReadLine();
            int len = startString.Length;
            int max = 0;
            int count = 0;
            int ind = 0;
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine("Введите предложение:");

                string startString = Console.ReadLine();
                startString = startString.ToLower();
                startString = startString.Replace(" ", "");

                char[] tmp = startString.ToCharArray();
                Array.Reverse(tmp);

                string reverseString = String.Concat<char>(tmp);

                int flag = 1;

                for (int i = 0; i < startString.Length; i++)
                {
                    if (startString[i] == reverseString[i])
                    {
                        flag = 1;
                        continue;
                    }
                    else
                    {
                        flag = 2;
                        break;
                    }

                }

                if (flag == 1)
                {
                    Console.WriteLine("Да, предложение палиндром");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Нет, предложение не палиндром");
                    Console.ReadKey();
                }

                Console.WriteLine("End");
                Console.ReadKey();
            }
    }
}
