
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lab1_14_11
{
    class program
    {
        static void bai1()
        {
            int year;
            Console.Write("Nhap nam can kiem tra : ");
            year = int.Parse(Console.ReadLine());
            if ((year % 400 == 0 || year % 4 == 0) && year % 100 != 0)
            {
                Console.WriteLine("{0} la nam nhuan ", year);
            }
            else
            {
                Console.WriteLine("{0} khong phai nam nhuan ", year);
            }
        }
        static void giaiPTBac2(float a, float b, float c)
        {
            if (a == 0)
            {
                if (b == 0)
                {
                    Console.Write("Phuong trinh vo nghiem ");
                }
                else
                {
                    Console.Write("Phuong trinh co 1 nghiem : x = {0}", (-c / b));
                }
                return;
            }
            float delta = b * b - 4 * a * c;
            float x1;
            float x2;
            // Tinh nghiem
            if (delta > 0)
            {
                x1 = (float)((-b + Math.Sqrt(delta)) / (2 * a));
                x2 = (float)((-b - Math.Sqrt(delta)) / (2 * a));
                Console.Write("Phuong trinh co 2 nghiem : x1 = {0} va x2 {1}", x1, x2);
            }

            else if (delta == 0)
            {
                x1 = (-b / (2 * a));
                Console.Write("Phong trinh co nghiem kep: x1 = x2 = {0}", x1);
            }
            else
            {
                Console.Write("Phuong trinh vo nghiem!");
            }
        }
        static void Bai3()
        {
            Console.Write("Nhap thang : ");
            string Sthang = Console.ReadLine();
            Console.Write("Nhap nam : ");
            string Snam = Console.ReadLine();

            int th = int.Parse(Sthang);
            int nm = int.Parse(Snam);
            int songay = 0;

            if (th >= 1 && th <= 12)
            {
                switch (th)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12: songay = 31; break;
                    case 4:
                    case 6:
                    case 9:
                    case 11: songay = 30; break;

                    case 2:
                        if (nm % 400 == 0 || (nm % 4 == 0 && nm % 100 != 0))    // nam nhuan
                            songay = 29;
                        else
                            songay = 28;
                        break;
                }

                Console.Write("=> Thang " + th + "/" + nm + " co " + songay + " ngay\n");
            }
            else
                Console.Write("=> Thang khong hop le!\n");
            Console.ReadLine();
        }
        static void Bai4()
        {
            Console.Write("Nhap so thuc : ");
            string sThuc = Console.ReadLine();

            int n = int.Parse(sThuc);
            if (n > 8.5)
            {
                Console.WriteLine("Thang diem A ");
            }
            else if (n > 7)
            {
                Console.WriteLine("Thang diem B");
            }
            else if (n > 5.5)
            {
                Console.WriteLine("Thang diem C");
            }
            else if (n > 4)
            {
                Console.WriteLine("Thang diem D");
            }
            else
            {
                Console.WriteLine("Thang diem E");
            }
        }
        static void Bai5()
        {
            const int gia1 = 1480, gia2 = 1533, gia3 = 1786, gia4 = 2242, gia5 = 2503;
            const int bac1 = 50, bac2 = 100, bac3 = 200, bac4 = 300, bac5 = 400;
            Double thanhtien;

            Console.Write("Chi so dien dau :");   // Tien dien dau 
            double csd = Convert.ToDouble(Console.ReadLine());
            Console.Write("Chi so dien cuoi:");  // Tien dien cuoi
            double csc = Convert.ToDouble(Console.ReadLine());

            double kw = csc - csd;
            if ((kw > 0) && (kw <= bac1))
                thanhtien = gia1 * kw;
            else
                if (kw <= bac2)
                thanhtien = (bac1 * gia1) + (kw - bac1) * gia2;
            else
                if (kw <= bac3)
                thanhtien = (bac1 * gia1) + (bac2 * gia2) + (kw - bac2) * gia3;
            else
                if (kw <= bac4)
                thanhtien = (bac1 * gia1) + (bac2 * gia2) + (bac3 * gia3) + (kw - bac3) * gia4;
            else
                thanhtien = (bac1 * gia1) + (bac2 * gia2) + (bac3 * gia3) + (kw + bac3) + (kw - bac4) * gia5;
            Console.WriteLine("So tien phai tra {0}", thanhtien);
            Console.ReadLine();

        }
        static void Bai6()
        {
            float tien = 0;
            Console.Write("Nhap so ngay thue phong : ");
            string soNgay = Console.ReadLine();
            Console.Write("Nhap loai phong : ");
            string loaiPhong = Console.ReadLine();

            int sn = int.Parse(soNgay);
            char lp = char.Parse(loaiPhong);

            switch (lp)
            {
                case 'A':
                    tien = sn * 500000;
                    if (sn > 10)
                        tien = tien - tien * 10 / 100;
                    break;
                case 'B':
                    tien = sn * 400000;
                    if (sn > 10)
                        tien = tien - tien * 8 / 100;
                    break;
                case 'C':
                    tien = sn * 300000;
                    if (sn > 10)
                        tien = tien - tien * 8 / 100;
                    break;
            }
            Console.Write("So tien thue phong la {0} ", tien);
        }
        static void Bai7()
        {
            int a, b, c;
            Console.Write("Nhap ngay : ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhap thang : ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Nhap nam : ");
            c = int.Parse(Console.ReadLine());
            if (c > 0)
            {
                if (b > 0 && b < 13)
                {
                    if (b == 1 || b == 3 || b == 5 || b == 7 || b == 8 || b == 10 || b == 12)
                    {
                        if (a > 0 && a < 32)
                        {
                            Console.WriteLine("{0}/{1}/{2} hop le ", a, b, c);
                        }
                        else
                        {
                            Console.WriteLine("{0}/{1}/{2} khong hop le ", a, b, c);

                        }
                    }
                    else if (b == 4 || b == 6 || b == 9 || b == 11)
                    {
                        if (a > 0 && a < 31)
                        {
                            Console.WriteLine("{0}/{1}/{2} hop le ", a, b, c);
                        }
                        else
                        {
                            Console.WriteLine("{0}/{1}/{2} khong hop le ", a, b, c);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("{0}/{1}/{2} khong hop le ", a, b, c);
                }
            }
            else
            {
                Console.WriteLine("{0}/{1}/{2} khong hop le ", a, b, c);
            }
        }
        static void Bai8()
        {
            int ngay,thang,nam;

            Console.Write("Nhap ngay : ");
            ngay = int.Parse(Console.ReadLine());
            Console.Write("Nhap thang : ");
            thang = int.Parse(Console.ReadLine());
            Console.Write("Nhap nam : ");
            nam = int.Parse(Console.ReadLine());
            if (ngay >= 1 && ngay <= 31 && thang >= 1 && thang <= 12)
            {
                Console.Write("Ngay ke tiep cua{0}/{1}/{2} la{3}/{4}/{5}\n", ngay, thang, nam, ngay + 1, thang, nam);
                Console.Write("Ngay truoc cua{0}/{1}/{2} la{3}/{4}/{5}", ngay, thang, nam, ngay - 1, thang, nam);
            }
            else
                Console.Write("Vui long nhap ngay hay thang hop le:\n");
        }
        static void Bai9()
        {
            Console.Write("Nhap vao mot so: ");
            int number = int.Parse(Console.ReadLine());
            bool IsPrime = true;
            if (number < 2)
            {
                IsPrime = false;
            }
            for (int i = 2; i < number / 2; i++)
            {
                if (number % i == 0)
                {
                    IsPrime = false;
                    break;
                }
            }
            if (IsPrime)
            {
                Console.Write($"{number} la so nguyen to.");
            }
            else
            {
                Console.Write($"{number} khong phai so nguyen to.");
            }
            Console.ReadKey();
        }
        static int USCLN(int x, int y)
        {
            if (y == 0) return x;
            return USCLN(y, x % y);
        }
        static int BSCNN(int x, int y)
        {
            return (x * y) / USCLN(x, y);
        }
        static int CheckPrime(int n)
        {
            if (n < 2)
            {
                return 0;
            }
            for (int i = 2; i < n / 2; i++)
            {
                if (n % i == 0)
                {
                    return 0;
                    break;
                }
            }
            return 1;
        }
        static void cau12()
        {
            Console.WriteLine("Nhap so phan tu mang: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("a[" + i.ToString() + "]=");
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("So phan tu cua mang : {0}", a.Length);
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Phan tu thu {0} : {1}", i, a[i]);
            }
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] % 2 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine("So phan tu chan co trong mang : {0}", count);
            int max = 0;
            int min = 0;
            for (int i = 0; i < n; i++)
            {
                max = Math.Max(max, a[i]);
            }
            for (int i = 0; i < n; i++)
            {
                min = Math.Min(min, a[i]);
            }
            Console.WriteLine("Phan tu max trong mang: {0}", max);
            Console.WriteLine("Phan tu min trong mang: {0}", min);
            Console.Write("Liet ke cac so nguyen to trong mang: ");
            for (int i = 0; i < n; i++)
            {
                if (CheckPrime(a[i]) == 1)
                {
                    Console.Write("{0} ", a[i]);
                }
            }
            Console.WriteLine();
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] >= 0)
                {
                    sum += a[i];
                }
            }
            Console.WriteLine("Tong cac phan tu duong trong mang : {0}", sum);
        }
        static void menu()
        {
            Console.Write("Bai 1 : Kiem tra nam co phai nam nhuan\n");
            Console.Write("Bai 2 : Giai phuong trinh bac 2\n");
            Console.Write("Bai 3 : Cho biet thang co bao nhieu ngay \n");
            Console.Write("Bai 4 : Nhap so thuc, cho biet gia tri thang diem 10 bang chu ABCDEF \n");
            Console.Write("Bai 5 : Tinh tien dien\n");
            Console.Write("Bai 6 : Tinh tien thue phong\n");
            Console.Write("Bai 7 : Kiem xem ngay cho truoc co phai ngay hop le\n");
            Console.Write("Bai 8 : Cho biet ngay ke tiep va ngay ke truoc cua ngay do\n");
            Console.Write("Bai 9 : Cho biet phai so nguyen to\n");
            Console.Write("Bai 10 : Tim uoc so chung lon nhat\n");
            Console.Write("Bai 11 : Tim uoc so chung nho nhat\n");
            Console.Write("Bai 12 : Mang 1 chieu");
        }
        static void Main(String[] args)
        {
            float a, b, c;

            int chon = 1;
            menu();
            do
            {
                Console.Write("\nNhap lua chon : ");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        {
                            bai1();
                            break;
                        }
                    case 2:
                        {
                            Console.Write("Nhap he so bac 2, a = ");
                            String valA = Console.ReadLine();
                            a = Convert.ToInt32(valA);
                            Console.Write("Nhap he so bac 1, b = ");
                            String valB = Console.ReadLine();
                            b = Convert.ToInt32(valB);
                            Console.Write("Nhap he so bac 0, c = ");
                            String valC = Console.ReadLine();
                            c = Convert.ToInt32(valC);
                            giaiPTBac2(a, b, c);
                            break;
                        }
                    case 3:
                        {
                            Bai3();
                            break;
                        }
                    case 4:
                        {
                            Bai4();
                            break;
                        }
                    case 5:
                        {
                            Bai5();
                            break;
                        }
                    case 6:
                        {
                            Bai6();
                            break;
                        }
                    case 7:
                        {
                            Bai7();
                            break;
                        }
                    case 8:
                        {
                            Bai8();
                            break;
                        }
                    case 9:
                        {
                            Bai9();
                            break;
                        }
                    case 10:
                        {
                            int x, y;
                            Console.Write("Nhap so nguyen duong a = ");
                            String valA = Console.ReadLine();
                            x = Convert.ToInt32(valA);
                            Console.Write("Nhap so nguyen duong b = ");
                            String valB = Console.ReadLine();
                            y = Convert.ToInt32(valB);

                            Console.Write("USCLN cua {0} va {1} la: {2} \n", x, y, USCLN(x, y));
                            break;
                        }
                    case 11:
                        {
                            int x, y;
                            Console.Write("Nhap so nguyen duong a = ");
                            String valA = Console.ReadLine();
                            x = Convert.ToInt32(valA);
                            Console.Write("Nhap so nguyen duong b = ");
                            String valB = Console.ReadLine();
                            y = Convert.ToInt32(valB);
                            Console.Write("BSCNN cua cua {0} va {1} la: {2}", x, y, BSCNN(x, y));
                            break;
                        }
                    case 12:
                        {
                            cau12();
                            break;
                        }
                    default:
                        break;
                }

            } while (chon != 0);
        }
    }
}
