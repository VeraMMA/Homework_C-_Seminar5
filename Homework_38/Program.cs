using System.Linq;
namespace homework
{
    class Program
    {
        static void Main()
        {
            int[] Segment = new int [10];

            Random rand = new Random();
            for (int i = 0; i < Segment.Length; i++)
            {
                Segment [i] = rand.Next(1, 99);
               System.Console.WriteLine($"Заполнение массива {i}\t" + Segment[i]);
                
            }
                 System.Console.WriteLine("Максимальный элемент массива:\t" + Segment.Max());
                 System.Console.WriteLine("Минимальный элемент масссива:\t" + Segment.Min());
                 System.Console.WriteLine( "Разница:\t" + (Segment.Max()-Segment.Min()));
        }

    }

}



