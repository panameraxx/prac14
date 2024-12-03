using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = GetSize();
            int[] omas = Input(size);
            Output(omas);
            Console.ReadKey();
        }
        static void Output(int[] crocodile)
        {
            for (int i = 0; i < crocodile.Length; i++)
            {
                Console.WriteLine($"crocodile[{i}] = {crocodile[i]}");
            }
        }
        static int GetSize()
        {
            Console.Write("Введите размер массива = ");
            int size;
            while (! int.TryParse(Console.ReadLine(), out size) || size <= 0)
            {
                Console.Write("Ошибка");
            }
            return size;
        }
        static int[] Input(int size)
        {
            int[] crocodile = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write($"crocodile[{i}] = ");
                crocodile[i] = int.Parse(Console.ReadLine());
            }
            return crocodile;
        }
    }
}
