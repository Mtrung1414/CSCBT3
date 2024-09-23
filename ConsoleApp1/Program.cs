using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Chon bai tap can thuc hien");
        Console.WriteLine("1. Kiem tra so chia het cho 3");
        Console.WriteLine("2. Hien thi bang cuu chuong");
        Console.WriteLine("3. Tinh tong giai thua den n");
        Console.WriteLine("4. Kiem tra so chinh phuong");
        Console.WriteLine("5. Kiem tra so ngay trong thang");
        Console.WriteLine("6. Tinh tong S theo cong thuc");
        Console.WriteLine("7. Tinh tong so le tu 1 den n");
        Console.WriteLine("8. Hien thi so ngto tu 1 den n");
        Console.WriteLine("9. Hien thi tam giac theo lua chon");
        Console.WriteLine("10. Hien thi day so Fibonacci");
        Console.Write("Nhap lua chon cua ban : ");


        int chon = int.Parse(Console.ReadLine());


        switch (chon)
        {
            case 1:
                BT1(); // Gọi bài tập 
                break;
            case 2:
                BT2();
                break;
            case 3:
                BT3();
                break;
            case 4:
                BT4();
                break;
            case 5:
                BT5();
                break;
            case 6:
                BT6();
                break;
            case 7:
                BT7();
                break;
            case 8:
                BT8();
                break;
            case 9:
                BT9();
                break;
            case 10:
                BT10();
                break;
            default:
                Console.WriteLine("Lựa chọn không hợp lệ.");
                break;
        }
    }


    static void BT1()
    {
        Console.WriteLine("Nhap mot so nguyen: ");
        int number = int.Parse(Console.ReadLine());

        KTchia3(number);
    }


    static void KTchia3(int num)
    {
        if (num % 3 == 0)
        {
            Console.WriteLine($"{num} la so chia het cho 3");
        }
        else
        {
            Console.WriteLine($"{num} khong phai la so chia het cho 3");
        }
    }


    static void BT2()
    {
        Console.WriteLine("Nhap mot so nguyen duong n: ");
        int n = int.Parse(Console.ReadLine());

        HienThiBangNhan(n);
    }


    static void HienThiBangNhan(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"Bang cuu chuong {i}:");
            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine($"{i} x {j} = {i * j}");
            }
            Console.WriteLine();
        }
    }
    static void BT3()
    {
        Console.Write("Nhap mot so nguyen duong n: ");
        int n = int.Parse(Console.ReadLine());

        if (n > 0)
        {
            long TongGiaiThua = TinhTongGiaiThua(n);
            Console.WriteLine($"Tong giai thua tu 1 den {n} la: {TongGiaiThua}");
        }
        else Console.WriteLine("Vui long nhap so nguyen > 0");
    }
    static long TinhTongGiaiThua(int n)
    {
        long s = 0;
        long giaithua = 1;
        for (int i = 1; i <= n; i++)
        {
            giaithua *= i;
            s += giaithua;
        }
        return s;
    }

    static bool KTChinhPhuong(int n)
    {
        int sqrt = (int)Math.Sqrt(n);

        return (sqrt * sqrt == n);
    }

    static void BT4()
    {
        Console.WriteLine("Nhap mot so nguyen n:");
        int n = int.Parse(Console.ReadLine());

        if (KTChinhPhuong(n))
        {
            Console.WriteLine($"{n} la so chinh phuong");
        }
        else
            Console.WriteLine($"{n} khong la so chinh phuong");
    }

    static int SoNgayTrongThang(int month, int year)
    {
        // Kiểm tra tính hợp lệ của tháng
        if (month < 1 || month > 12)
        {
            return -1; // Trả về -1 nếu tháng không hợp lệ
        }

        switch (month)
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                return 31; // Các tháng có 31 ngày
            case 4:
            case 6:
            case 9:
            case 11:
                return 30; // Các tháng có 30 ngày
            case 2:
                // Tháng 2 cần kiểm tra năm nhuận
                if (LaNamNhuan(year))
                {
                    return 29; // Tháng 2 có 29 ngày trong năm nhuận
                }
                else
                {
                    return 28; // Tháng 2 có 28 ngày trong năm không nhuận
                }
            default:
                return -1; // Trường hợp không hợp lệ
        }
    }

    // Hàm kiểm tra năm nhuận
    static bool LaNamNhuan(int year)
    {
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }

    static void BT5()
    {
        Console.Write("Nhap thang(1-12): ");
        int month = int.Parse(Console.ReadLine());

        Console.Write("Nhap nam ");
        int year = int.Parse(Console.ReadLine());

        int days = SoNgayTrongThang(month, year);

        if (days > 0)
        {
            Console.WriteLine($"Thang {month} Nam {year} Co {days} Ngay.");
        }
        else
        {
            Console.WriteLine("Thanng khong hop le.");
        }
    }

    static long TinhTongS(int n)
    {
        long sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += (long)Math.Pow(i, i); // Tính i^i và cộng vào tổng
        }
        return sum;
    }

    static void BT6()
    {
        Console.Write("Nhap mot so nguyen duong n: ");
        int n = int.Parse(Console.ReadLine());

        if (n > 0)
        {
            long sum = TinhTongS(n);
            Console.WriteLine($"Tong S = 1 + 2^2 + 3^3 + ... + {n}^{n} la: {sum}");
        }
        else
        {
            Console.WriteLine("Vui long nhap mot so nguyen duong lon hon 0.");
        }
    }

    static int TinhTongSoLe(int n)
    {
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            if (i % 2 != 0)
            {
                sum += i;
            }
        }
        return sum;
    }

    static void BT7()
    {
        Console.Write("Nhap mot so nguyen n: ");
        int n = int.Parse(Console.ReadLine());

        if (n > 0)
        {
            int tongLe = TinhTongSoLe(n);
            Console.WriteLine("Tong cac so le tu 1 den " + n + " la: " + tongLe);
        }
        else
        {
            Console.WriteLine("Vui long nhap mot so nguyen duong lon hon 0.");
        }
    }

    static bool KiemTraSoNguyenTo(int num)
    {
        if (num < 2)
        {
            return false;
        }
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    static void LietKeSoNguyenTo(int n)
    {
        for (int i = 2; i <= n; i++)
        {
            if (KiemTraSoNguyenTo(i))
            {
                Console.Write(i + " ");
            }
        }
        Console.WriteLine();
    }

    static void BT8()
    {
        Console.Write("Nhap mot so nguyen duong n: ");
        int n = int.Parse(Console.ReadLine());

        if (n > 1)
        {
            Console.WriteLine("Cac so nguyen to tu 1 den " + n + " la:");
            LietKeSoNguyenTo(n);
        }
        else
        {
            Console.WriteLine("Vui long nhap mot so nguyen lon hon 1.");
        }
    }

    static void BT9()
    {
        Console.Write("Nhap so hang n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Chon loai tam giac muon ve:");
        Console.WriteLine("1. Tam giac thuong");
        Console.WriteLine("2. Tam giac deu");
        Console.WriteLine("3. Tam giac xoay nguoc");

        int chon = int.Parse(Console.ReadLine());

        switch (chon)
        {
            case 1:
                Console.WriteLine("\nTam giac thuong:");
                VeTamGiacThuong(n);
                break;

            case 2:
                Console.WriteLine("\nTam giac deu:");
                VeTamGiacDeu(n);
                break;

            case 3:
                Console.WriteLine("\nTam giac xoay nguoc:");
                VeTamGiacXoayNguoc(n);
                break;

            default:
                Console.WriteLine("Lua chon khong hop le!");
                break;
        }
    }

    static void VeTamGiacThuong(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }

    static void VeTamGiacDeu(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n - i; j++)
            {
                Console.Write(" ");
            }
            for (int k = 1; k <= 2 * i - 1; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    static void VeTamGiacXoayNguoc(int n)
    {
        for (int i = n; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }

    static void BT10()
    {
        Console.Write("Nhap mot so nguyen duong n: ");
        int n = int.Parse(Console.ReadLine());

        if (n > 0)
        {
            Console.WriteLine($"Day Fibonacci tu 1 den {n} la:");
            HienThiDayFibonacci(n);
        }
        else
        {
            Console.WriteLine("Vui long nhap mot so nguyen duong.");
        }
    }
    static void HienThiDayFibonacci(int n)
    {
        int a = 0, b = 1;

        while (b <= n)
        {
            Console.Write(b + " ");
            int temp = a + b;
            a = b;
            b = temp;
        }
        Console.WriteLine();
    }
}
