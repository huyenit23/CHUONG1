using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB07
{
    internal class Program
    {
        static void Main(string[] args)
        {

                Console.Write("Nhap n: ");
                int n = int.Parse(Console.ReadLine());

                if (n <= 0)
                {
                    Console.WriteLine("n phai lon hon 0!");
                    return;
                }

                int tong = 0;
                int soChan = 0;
                int max, min;

                Console.Write("Nhap so thu 1: ");
                int x = int.Parse(Console.ReadLine());

                tong = x;
                max = x;
                min = x;

                if (x % 2 == 0)
                    soChan++;

                for (int i = 2; i <= n; i++)
                {
                    Console.Write($"Nhap so thu {i}: ");
                    x = int.Parse(Console.ReadLine());

                    tong += x;

                    if (x > max)
                        max = x;

                    if (x < min)
                        min = x;

                    if (x % 2 == 0)
                        soChan++;
                }

                double trungBinh = (double)tong / n;

                Console.WriteLine("\n--- KET QUA THONG KE ---");
                Console.WriteLine($"Tong = {tong}");
                Console.WriteLine($"Trung binh = {trungBinh:F2}");
                Console.WriteLine($"So lon nhat = {max}");
                Console.WriteLine($"So nho nhat = {min}");
                Console.WriteLine($"So luong so chan = {soChan}");
            }
        }

    }

