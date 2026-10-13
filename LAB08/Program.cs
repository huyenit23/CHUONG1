using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB08
{
    internal class Program
    {
        
            // Ham kiem tra so nguyen to
            static bool LaSoNguyenTo(int n)
        {
            if (n < 2)
                return false;

            for (int i = 2; i <= n / i; i++)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }
        static void Main(string[] args)
        {

         
            {
                Console.Write("Nhap n: ");
                int n = int.Parse(Console.ReadLine());

                if (n < 2)
                {
                    Console.WriteLine("Khong co so nguyen to nao khong vuot qua n.");
                    return;
                }

                Console.WriteLine($"Cac so nguyen to khong vuot qua {n} la:");

                for (int i = 2; i <= n; i++)
                {
                    if (LaSoNguyenTo(i))
                    {
                        Console.Write(i + " ");
                    }
                }

                Console.WriteLine();
            }
        }

    }
}

