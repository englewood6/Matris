using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matris
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] dizi = new int[4, 4];
            Random rnd = new Random();
            int[] randomlar = new int[4];
            int[] artı5 = new int[4];

            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    randomlar[j] = rnd.Next(1, 100);
                    dizi[i, j] = randomlar[j];
                    Console.WriteLine(dizi[i,j] + " ");

                }
                Console.WriteLine();

            }
            for (int i = 1; i < 2; i++)
            {
                for (int k = 0; k < 4; k++)
                {
                    Console.WriteLine("Lütfen {0}x{1} elemanını giriniz" , i+1, k+1);
                    int sayi = Convert.ToInt32(Console.ReadLine());
                    artı5[k] = sayi;
                    dizi[i, k] = sayi;
                }

            }
            for (int i = 2; i < 3; i++)
            {
                for (int t = 0; t < 4; t++)
                {
                    dizi[i, t] = randomlar[t] * randomlar[t]; 
                }
            }
            for (int i = 3; i < 4; i++)
            {
                for (int y = 0; y < y; y++)
                {
                    dizi[i, y] = artı5[y] + 5;

                }

            }
            for (int i = 0; i < 4; i++)
            {
                for (int k = 0; k < 4; k++)
                {
                    Console.WriteLine(dizi[i,k] + " ");

                }
                Console.WriteLine();

            }
            Console.ReadLine();
        }

    }
}
