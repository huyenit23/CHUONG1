using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Nhap a: ");
                double a = double.Parse(Console.ReadLine());

                Console.Write("Nhap b: ");
                double b = double.Parse(Console.ReadLine());

                Console.Write("Nhap c: ");
                double c = double.Parse(Console.ReadLine());

                if (a == 0)
                {
                    // Truong hop phuong trinh bac nhat: bx + c = 0
                    if (b == 0)
                    {
                        if (c == 0)
                            Console.WriteLine("Phuong trinh vo so nghiem.");
                        else
                            Console.WriteLine("Phuong trinh vo nghiem.");
                    }
                    else
                    {
                        double x = -c / b;
                        Console.WriteLine($"Phuong trinh co nghiem x = {x:F2}");
                    }
                }
                else
                {
                    // Tinh delta
                    double delta = b * b - 4 * a * c;

                    if (delta < 0)
                    {
                        Console.WriteLine("Phuong trinh vo nghiem thuc.");
                    }
                    else if (delta == 0)
                    {
                        double x = -b / (2 * a);
                        Console.WriteLine($"Phuong trinh co nghiem kep x = {x:F2}");
                    }
                    else
                    {
                        double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                        double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                        Console.WriteLine($"Nghiem x1 = {x1:F2}");
                        Console.WriteLine($"Nghiem x2 = {x2:F2}");
                    }
                }
            }
        }

    }
}

