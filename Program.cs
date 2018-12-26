using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1-Kabarcık Sıralama:");
            Console.WriteLine("2-Birleştirmeli Sıralama:");
            Console.WriteLine("3-Hızlı Sıralama:");
            Console.WriteLine("4-Seçimli Sıralama:");
            Console.WriteLine("5-Eklemeli Sıralama:");
            Console.WriteLine("6-Ağaç Sıralama:");
            Console.WriteLine("9-Çıkış:");
            Console.WriteLine("\nEleman sayısı giriniz:");
            int elmsayisi = Convert.ToInt32(Console.ReadLine());
            label:
            Console.WriteLine("\nSıralama türü seçiniz:");
            int siralama = int.Parse(Console.ReadLine());
            if (siralama == 9)
            {
                return;
            }
           
            int[] dizi = new int[elmsayisi];
            Random rastgele = new Random();
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rastgele.Next(-100, 1000);

            }

            if (siralama == 1)
            {
                
                Stopwatch sw = Stopwatch.StartNew();
                kabarcikSirala(dizi);
                sw.Stop();
                Console.WriteLine("\nTime: {0} ms.", sw.ElapsedMilliseconds.ToString());
                goto label;
            }
            else if (siralama == 4)
            {
               
                Stopwatch sw = Stopwatch.StartNew();
                secmelisiralama(dizi);
                sw.Stop();
                Console.WriteLine("\nTime: {0} ms.", sw.ElapsedMilliseconds.ToString());
                goto label;
            }
            else if (siralama == 3)
            {

               
                Stopwatch sw = Stopwatch.StartNew();
                QuickSort(dizi, 0, dizi.Length - 1);
                sw.Stop();
                Console.WriteLine("\nTime: {0} ms.",sw.ElapsedMilliseconds.ToString());
                goto label;
                
            }
            else if (siralama == 5)
            {
               
                Stopwatch sw = Stopwatch.StartNew();
                Insertionsort(dizi);
                sw.Stop();
                Console.WriteLine("\nTime: {0} ms.", sw.ElapsedMilliseconds.ToString());
                goto label;
            }
            else if (siralama == 2)
            {
               
                Stopwatch sw = Stopwatch.StartNew();
                birlestirmelisiralama(dizi, 0, dizi.Length - 1);
                sw.Stop();
                Console.WriteLine("\nTime: {0} ms.", sw.ElapsedMilliseconds.ToString());
                goto label;
            }
            else if (siralama == 6)
            {
                
                List<int> Tree_ornekler = new List<int>(dizi);
                Tree_ornekler.Sort();
                Stopwatch sw = Stopwatch.StartNew();
                Tree_ornekler.CopyTo(dizi);
                foreach (int Tree_ornek in Tree_ornekler)
                sw.Stop();
                Console.WriteLine("\nTime: {0} ms.", sw.ElapsedMilliseconds.ToString());
                goto label;
            
            }

      



            Console.ReadLine();
        }

        public static void kabarcikSirala(int[] siralanacakDizi)
        {

            int i = 1, j, deger;
            int diziAdet = siralanacakDizi.Length;
            while (i < diziAdet)
            {
                j = diziAdet - 1;
                while (j >= 1)
                {
                    if (siralanacakDizi[j - 1] > siralanacakDizi[j])
                    {
                        deger = siralanacakDizi[j];
                        siralanacakDizi[j] = siralanacakDizi[j - 1];
                        siralanacakDizi[j - 1] = deger;
                    }
                    j--;
                }
                i++;
            }
        }

        public static void diziYazdir(int[] dizi)
        {

            for (int i = 0; i < dizi.Length; i++)
            {
                Console.WriteLine(dizi[i]);
            }
            Console.ReadKey();
        }

        public static void secmelisiralama(int[] dizi)
        {
            int n = dizi.Length;
            int yedek;
            int minindex;
            for (int i = 0; i < n - 1; i++)
            {
                minindex = i;
                for (int j = i; j < n; j++)
                {
                    if (dizi[j] < dizi[minindex])
                        minindex = j;
                }
                yedek = dizi[i];
                dizi[i] = dizi[minindex];
                dizi[minindex] = yedek;

            }
        }

        public static void QuickSort(int[] dizi, int baslangic, int bitis)
        {
            int i;
            if (baslangic < bitis)
            {
                i = parca(dizi, baslangic, bitis);
                QuickSort(dizi, baslangic, i - 1);
                QuickSort(dizi, i + 1, bitis);

            }
        }

        public static int parca(int[] A, int baslangic, int bitis)
        {
            int gecici;
            int x = A[bitis];
            int i = baslangic - 1;
            for (int j = baslangic; j <= bitis - 1; j++)
            {
                if (A[j] <= x)
                {
                    i++;
                    gecici = A[i];
                    A[i] = A[j];
                    A[j] = gecici;


                }

            }
            gecici = A[i + 1];
            A[i + 1] = A[bitis];
            A[bitis] = gecici;
            return i + 1;

        }

        static int[] Insertionsort(int[] sayilar)
        {
            for (int i = 0; i < sayilar.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (sayilar[j - 1] > sayilar[j])
                    {
                        int temp = sayilar[j - 1];
                        sayilar[j - 1] = sayilar[j];
                        sayilar[j] = temp;
                    }
                }
            }
            return sayilar;
        }

        public static void birlestirmelisiralamadizi(int[] dizi, int basla, int orta, int bitis)
        {
            int[] gecici = new int[bitis - basla + 1];
            int i = basla, j = orta + 1, k = 0;
            while (i <= orta && j <= bitis)
            {
                if (dizi[i] < dizi[j])
                {
                    gecici[k] = dizi[i];
                    k++;
                    i++;
                }
                else
                {
                    gecici[k] = dizi[j];
                    k++;
                    j++;
                }
            }
            while (i <= orta)
            {
                gecici[k] = dizi[i];
                k++;
                i++;
            }
            while (j <= bitis)
            {
                gecici[k] = dizi[j];
                k++;
                j++;
            }
            k = 0;
            i = basla;
            while (k < gecici.Length && i <= bitis)
            {

                dizi[i] = gecici[k];
                k++;
                i++;
            }
        }

        public static void birlestirmelisiralama(int[] dizi, int basla, int bitis)
        {
            if (basla < bitis)
            {
                int orta = (basla + bitis) / 2;
                birlestirmelisiralama(dizi, basla, orta);
                birlestirmelisiralama(dizi, orta + 1, bitis);
                birlestirmelisiralamadizi(dizi, basla, orta, bitis);
            }
        }



       
    }
   

        
}
