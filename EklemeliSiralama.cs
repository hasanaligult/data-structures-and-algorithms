using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eklemeli_sıralama
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10] { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6 };
            Console.WriteLine("\nOrjinal sayilar....");
            sayilariyaz(numbers);
            Console.WriteLine("\nSirali sayilar....");
            sayilariyaz(Insertionsort(numbers));
            Console.WriteLine("\n");
            Console.ReadLine();
        }
        public static void sayilariyaz(int[] array)
        {
            foreach(int i in array)
                Console.WriteLine(i.ToString() + " ");

        }
        static int[] Insertionsort(int[] sayilar)
        {
            for (int i = 0; i < sayilar.Length - 1; i++) 
            {
                for (int j = i + 1; j > 0; j--)

                {
                    if(sayilar[j-1]>sayilar[j])
                    {
                        int temp = sayilar[j - 1];
                        sayilar[j - 1] = sayilar[j];
                        sayilar[j] = temp;
                    }
                }
            }
            return sayilar;
        }
       
    }
}
