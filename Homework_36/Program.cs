using System.Linq;
namespace homework
{
    class Program
    {   static void Print (string word)
        {
            System.Console.WriteLine(word);
        }
    
        static void Main()
        {   Print("Найти сумму элементов, стоящих на нечётных позициях.");
               int summa = 0;
            int[] Segment = new int [10];
            Random rand = new Random();
           
            Print("Заполните массив случайными числами.");
            for (int i = 0; i < Segment.Length; i++)
            { Segment [i] = rand.Next(1, 99);

               Console.WriteLine($"Заполнение массива {i}\t" + Segment[i]);    
                
            }  
                 for(int j=1; j<Segment.Length; j+=2)
               {
                  Console.WriteLine($"Четные числа в массиве {j}\t" + Segment[j]);
                  summa = summa + Segment[j];
               }  System.Console.WriteLine("Количество четных чисел в массиве: " + summa);
 
        }           
    }
}
