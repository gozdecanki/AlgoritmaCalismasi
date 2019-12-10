using System;

namespace AlgoritmaCalısma
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1.soru  : ekrana girilen değeri ters çevirme   
             * 
             * Console.WriteLine("Bir kelime giriniz!");
                          string kelime= Console.ReadLine();
                          string terskelime = "";
                          Console.WriteLine(kelime);

                          for (int i=0;i<=kelime.Length-1;i++)
                          {
                             terskelime += kelime[kelime.Length-i-1];
                          }


                          Console.WriteLine(terskelime);*/


            /* 2.soru : Palindrome
             Console.WriteLine("Bir kelime giriniz!");
                        string kelime = Console.ReadLine();
                         string terskelime = "";
                         Console.WriteLine(kelime);

                        for (int i = 0; i <= kelime.Length - 1; i++)
                       {
                          terskelime += kelime[kelime.Length - i - 1];
                      }
                      if(kelime==terskelime)

                      {
                          Console.WriteLine(kelime + " bir palindromdur");
                      }
                      else
                      {
                          Console.WriteLine("palindrom değil");

                      }
                      */

            /* 3. soru :0-10 arasındaki sayıları ekrana yazdırma

               for(int i=0; i<11;i++)

               {
                   Console.WriteLine(i.ToString());
               }
           */

            /* 4. soru : array içindeki sayıları toplama

            int[] arr = { 10, 10, 12, 13, 15, 16, 18, 50, 4, 6, 8 };
            int toplam=0;

            for (int i = 0; i < arr.Length; i++)
            {
                toplam += arr[i];
            }


            Console.WriteLine(toplam.ToString());

         */

            /* 5. soru : tanımlı int arrayden en büyük elemanı bulun 

            int[] arr = { 10, 10, 12, 13, 15, 16, 18, 50, 4, 6, 8 };

            
            Console.WriteLine(arr.Max());
            */


            /* 6. soru: tanımlı int arrayden en küçük elemanı bulun 
             
            int[] intArray = { 10, 10, 12, 13, 15, 16, 18, 50, 4, 6, 8 };

            int minVal = intArray[0];
            for (int i = 1; i < intArray.Length; i++)
            {
                if (intArray[i] < minVal)
                    minVal = intArray[i];
            }

            Console.WriteLine(minVal);

           */

            /*7.soru tanımlı int arraydeki 10 sayının ortalamasına en yakın olanı bulalım 


            int[] arr = { 10, 30, 12, 13, 15, 16, 32, 50, 4, 6 };
            int toplam = 0;
            int ortalama = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                toplam += arr[i];
            }

            ortalama = toplam / arr.Length;

            int fark = Math.Abs((ortalama) - arr[0]);
            int yedek = 0;
            int enyakinsayi = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                yedek = Math.Abs(ortalama - arr[i]);
                if (yedek < fark)
                {
                    fark = yedek;
                    enyakinsayi = arr[i];

                }

            }


           Console.WriteLine("Ortalamaya en yakın sayı: " + enyakinsayi);
         */

            /* 8. soru :isim ve soyisminiz kullanıcının girdiği sayi kadar yazdırın
             * 
                        Console.WriteLine("ism ve soyisminizi giriniz");
                      string isim=  Console.ReadLine();

                        Console.WriteLine("sayı giriniz");
                        int sayi = Convert.ToInt32(Console.ReadLine());

                        for (int i=1;i<=sayi;i++)
                        {

                            Console.WriteLine(isim);
                        }

                */

            /* 9. soru sayıların negatif ve pozitif olup olmadığını bulma*/
            
           int[] arr = { -10, -30, -12, -13, -15, 16, 32, 50, 4, 6 };

            for (int i=0; i<arr.Length;i++)
            {
                if (arr[i]<0)
                {
                    Console.WriteLine(arr[i] + " pozitif");
                }
                else
                {
                    Console.WriteLine(arr[i] + " negatif");
                }
            }

    

            Console.ReadLine();


        
    }
    }
}
