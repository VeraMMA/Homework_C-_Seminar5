using System.Linq;
namespace homework
{
    class Program
    {   static void Print (string word)
        {
            System.Console.WriteLine(word);
        }
        static void Main()
        {   Print("Показать количество чётных чисел в массиве:");
            int[] Segment = new int [10];
            Random rand = new Random();
            int evenNumbersCount = 0;

            for (int i = 0; i < Segment.Length; i++)
            { Segment [i] = rand.Next(100, 999);
             
                if (Segment[i] % 2 == 0)
                {  System.Console.WriteLine("Четные элементы массива:\t" + Segment[i]);
                    evenNumbersCount++;
                }  
            }  System.Console.WriteLine("Количество четных чисел в массиве: " + evenNumbersCount);
        }
    }
}
