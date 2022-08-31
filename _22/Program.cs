using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Размерность массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("array[{0}] = ", i);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            int max = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[i - 1]) max = i;
            }
            Console.WriteLine("Минимальное значение массива: " + array[max]);
            Console.ReadLine();
        }
        
        static int[] GetArray(object a)
        {
            int n = (int)a;
            int[] array = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(0, 100);
            }
            return array;
        }
    }
}