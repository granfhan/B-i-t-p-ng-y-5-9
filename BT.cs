using System;


namespace ConsoleApp7
{
    internal class BT() { 
        public static void Bai1()
    {
        int[] arr;
        Console.Write("nhap so luong phan tu trong mang :");
        int n = Convert.ToInt32(Console.ReadLine());
        arr = new int[n];
        int a = 0;
        for (int i = 0; i < n; i++)
        {
            Console.Write($"nhap phan tu thu {i + 1} : ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
            a += arr[i];
        }
        Console.Write($"tong cac phan tu trong mang la : {a}\n");
    }
        public static void Bai2()
        {
            Console.Write("nhap chuoi : ");
            string a = Convert.ToString(Console.ReadLine());
            int r = a.Count(a => char.IsLetter(a));
            Console.WriteLine($"so luong ky tu khong bao gom dau cau va khoang cach trong chuoi la : {r}\n");
        }
        public static void Bai3()
        {
            int[] arr;
            Console.Write("Nhap so luong phan tu trong mang: ");
            int n = Convert.ToInt32(Console.ReadLine());
            arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap phan tu thu {i + 1}: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine($"Phan tu lon nhat trong mang la: {max}\n");
        }
        public static void Bai4()
        {
            Console.Write("Nhap chuoi: ");
            string a = Console.ReadLine();

            char[] charArray = a.ToCharArray();
            Array.Reverse(charArray);

            string reversed = new string(charArray);
            Console.WriteLine("Chuoi dao nguoc: " + reversed + "\n");
        }
        public static void Bai5()
        {
            int n;
            int[] arr;
            Console.Write("nhap so luong phan tu trong mang :");
            n = Convert.ToInt32(Console.ReadLine());
            arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap phan tu thu {i + 1}: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            bool test = true;
            for (int i = 0; i < n / 2; i++)
            {
                if (arr[i] != arr[n - 1 - i])
                {

                    test = false; break;
                }
            }
            if (test)
            { Console.WriteLine("day la mang doi xung\n"); }
            else { Console.WriteLine("day khong phai mang doi xung\n"); }
        }
        public static void Bai6()
        {
            Console.Write("nhap chuoi : ");
            string a = Convert.ToString(Console.ReadLine());
            Console.Write("nhap ky tu can dem : ");
            char b = Convert.ToChar(Console.ReadLine());
            char[] charArray = a.ToCharArray();
            int l = 0;
            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] == b)
                {
                    l++;
                }

            }
            Console.WriteLine($"so lan {b} xuat hien trong chuoi la : {l}\n");
        }
        public static void Main(string[] args)
        {
            BT.Bai1();
            BT.Bai2();
            BT.Bai3();
            BT.Bai4();
            BT.Bai5();
            BT.Bai6();
        }
    }
}
