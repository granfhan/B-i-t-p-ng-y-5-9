using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class BT { 
         public static void SUM(int b)
    {
        int[] arr;
        Console.Write("nhap so luong phan tu trong mang : ");
        int n = Convert.ToInt32(Console.ReadLine());
        arr = new int[n];
        int a = 0;
        for (int i = 0; i < n; i++)
        {
            Console.Write($"nhap phan tu thu {i + 1} : ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
            a += arr[i];
        }
        Console.Write($"tong cac phan tu trong mang la : {a}");
    }
        public static void main()
        {
            Console.WriteLine("nhap so luong phan tu trong mang 1 : ");
            int n = Convert.ToInt32(Console.ReadLine());
            SUM(n);
        }
}
}
