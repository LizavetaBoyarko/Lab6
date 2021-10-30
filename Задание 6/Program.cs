using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_6
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
                if (startString[i] != ' ')
                {
                    count += 1;
                }
                else
                {
                    if (count > max)
                    {
                        count = max;
                        ind = i - count;
                    }
                    count = 0;
                }
                if (count > max)
                {
                    max = count;
                    ind = i - count + 1;
                }

            }

            Console.WriteLine(startString.Substring(ind, max));
            Console.ReadKey();
        }
    }
}
