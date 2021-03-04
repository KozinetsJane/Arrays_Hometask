using System;

namespace Arrays_Hometask
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int [8] { 25, -30, 5, 98, -5, 78, 63, -10 };
            int minValue = num[0];
            int index = 0;
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] < minValue)
                {
                    minValue = num[i];
                    index = i;
                }
            }
            Console.WriteLine("Значение минимального отрицательного элемента в массиве:" + minValue + ", его индекс:" + index);
            Console.ReadKey();



        }
    }
}
