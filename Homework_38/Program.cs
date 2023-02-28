using System.Linq;
namespace homework
{
    class Program
    {      static void Print (string word)
        {
            System.Console.WriteLine(word);
        }
        static void Main()
        {   Print("Найти разницу между максимальным и минимальным элементов массива");
            Double[] Segment = new Double [10];
              int i = 0;
            Random rand = new Random();
            for ( i = 0; i < Segment.Length; i++)
            {
                Segment [i] = Math.Round(rand.NextDouble()*100, 2);
               System.Console.WriteLine($"Заполнение массива {i}\t" + Segment[i]);
                
            }
                 System.Console.WriteLine("Максимальный элемент массива:\t" + Segment.Max());
                 System.Console.WriteLine("Минимальный элемент масссива:\t" + Segment.Min());
                 System.Console.WriteLine( "Разница:\t" + (Segment.Max()-Segment.Min()));
        }

    }

}



