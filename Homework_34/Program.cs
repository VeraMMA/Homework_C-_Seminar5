// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
using System.Linq;
namespace homework
{
    class Program
    {
        static void Main()
        {
            int[] Segment = { 456, 897, 434, 254, 980, 531, 199 };

            int evenNumbersCount = 0;

            System.Console.WriteLine("Максимальный элемент массива:\t" + Segment.Max());
            System.Console.WriteLine("Минимальный элемент масссива:\t" + Segment.Min());

            for (int i = 0; i < Segment.Length; i++)
            {
                if (Segment[i] % 2 == 0)
                {  System.Console.WriteLine("Четные элементы массива:\t" + Segment[i]);
                    evenNumbersCount++;
                }  
            }  System.Console.WriteLine("Количество четных чисел в массиве: " + evenNumbersCount);
        }
    }
}
