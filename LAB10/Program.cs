using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB10
{
    internal class Program
    {
        static void Main(string[] args)
        {
                int chon;

                do
                {
                    Console.WriteLine("\n===== MENU VE HINH =====");
                    Console.WriteLine("1. Tam giac vuong dac");
                    Console.WriteLine("2. Tam giac vuong rong");
                    Console.WriteLine("3. Hinh vuong rong");
                    Console.WriteLine("0. Thoat");
                    Console.Write("Nhap lua chon: ");

                    if (!int.TryParse(Console.ReadLine(), out chon))
                    {
                        Console.WriteLine("Vui long nhap so hop le!");
                        continue;
                    }

                    if (chon == 0)
                        break;

                    if (chon < 1 || chon > 3)
                    {
                        Console.WriteLine("Lua chon khong hop le!");
                        continue;
                    }

                    Console.Write("Nhap kich thuoc n: ");

                    if (!int.TryParse(Console.ReadLine(), out int n)
                        || n <= 0 || n > 50)
                    {
                        Console.WriteLine("n phai tu 1 den 50!");
                        continue;
                    }

                    switch (chon)
                    {
                        case 1:
                            // Tam giac vuong dac
                            for (int i = 1; i <= n; i++)
                            {
                                for (int j = 1; j <= i; j++)
                                {
                                    Console.Write("* ");
                                }
                                Console.WriteLine();
                            }
                            break;

                        case 2:
                            // Tam giac vuong rong
                            for (int i = 1; i <= n; i++)
                            {
                                for (int j = 1; j <= i; j++)
                                {
                                    if (j == 1 || j == i || i == n)
                                        Console.Write("* ");
                                    else
                                        Console.Write("  ");
                                }
                                Console.WriteLine();
                            }
                            break;

                        case 3:
                            // Hinh vuong rong
                            for (int i = 1; i <= n; i++)
                            {
                                for (int j = 1; j <= n; j++)
                                {
                                    if (i == 1 || i == n ||
                                        j == 1 || j == n)
                                        Console.Write("* ");
                                    else
                                        Console.Write("  ");
                                }
                                Console.WriteLine();
                            }
                            break;
                    }

                } while (true);

                Console.WriteLine("Da thoat chuong trinh!");
            }
        }

    }
