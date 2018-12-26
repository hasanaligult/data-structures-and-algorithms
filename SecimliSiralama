using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secimlisıralama
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = { 5, 7, 2, 9, 6, 1, 4, 7 };
            secmelisiralama(dizi);
            foreach (var entry in dizi)
            {
                Console.WriteLine(entry);
            }

            Console.ReadLine();

        }
        public static void secmelisiralama(int[] dizi)
        {
            int n = dizi.Length;
            int yedek;
            int minindex;
            for(int i=0; i<n-1; i++)
            {
                minindex = i;
                for(int j=i;j<n;j++)
                {
                    if (dizi[j] < dizi[minindex])
                        minindex = j;
                }
                yedek = dizi[i];
                dizi[i] = dizi[minindex];
                dizi[minindex] = yedek;

            }
        }
    }
}
