using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB09
{
    internal class Program
    {
        static string DocChuSo(int n)
        {
            switch (n)
            {
                case 0: return "khong";
                case 1: return "mot";
                case 2: return "hai";
                case 3: return "ba";
                case 4: return "bon";
                case 5: return "nam";
                case 6: return "sau";
                case 7: return "bay";
                case 8: return "tam";
                case 9: return "chin";
                default: return "";
            }
        }

        static string DocSo(int n)
        {
            if (n < 0 || n > 99)
                return "So khong hop le!";

            if (n < 10)
                return DocChuSo(n);

            int chuc = n / 10;
            int donVi = n % 10;

            string ketQua = "";

            switch (chuc)
            {
                case 1:
                    ketQua = "muoi";
                    break;
                case 2:
                    ketQua = "hai muoi";
                    break;
                case 3:
                    ketQua = "ba muoi";
                    break;
                case 4:
                    ketQua = "bon muoi";
                    break;
                case 5:
                    ketQua = "nam muoi";
                    break;
                case 6:
                    ketQua = "sau muoi";
                    break;
                case 7:
                    ketQua = "bay muoi";
                    break;
                case 8:
                    ketQua = "tam muoi";
                    break;
                case 9:
                    ketQua = "chin muoi";
                    break;
            }

            if (chuc == 1 && donVi > 0)
            {
                ketQua += " " +
                    (donVi == 5 ? "lam" : DocChuSo(donVi));
            }
            else if (donVi == 1 && chuc > 1)
            {
                ketQua += " mot";
            }
            else if (donVi == 4 && chuc > 1)
            {
                ketQua += " tu";
            }
            else if (donVi == 5 && chuc > 1)
            {
                ketQua += " lam";
            }
            else if (donVi > 0)
            {
                ketQua += " " + DocChuSo(donVi);
            }

            return ketQua;
        }
        static void Main(string[] args)
        {
                  {
            {
                Console.Write("Nhap so nguyen tu 0 den 99: ");
                int n = int.Parse(Console.ReadLine());

                Console.WriteLine("Cach doc: " + DocSo(n));
            }
        }

    }
}
}
