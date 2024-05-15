using System.Text;
using System;

using System.Collections.Generic;
using System.Data;
using System.Linq;

using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static bool snt(long n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;

        }


        static bool scp(int n)
        {
            long sqr = (long)Math.Sqrt(n);
            if (sqr * sqr == n) return true;
            return false;

        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Phần tử thứ " + i + " : ");
                a[i] = int.Parse(Console.ReadLine());
            }

            int tongsnt = 0, tongscp = 0;
            for (int i = 0; i < n; i++)
            {
                if (snt(a[i]))
                {
                    tongsnt++;
                    Console.WriteLine(a[i] + " là số nguyên tố");
                }
                if (scp(a[i]))
                {
                    tongscp++;
                    Console.WriteLine(a[i] + " là số chính phương");
                }

            }
            Console.WriteLine("Có " + tongsnt + " số nguyên tố");
            Console.WriteLine("Có " + tongscp + " số chính phương");
            Console.ReadKey();
        }
    }
}