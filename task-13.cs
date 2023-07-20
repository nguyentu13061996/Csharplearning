
using System;

namespace task-13 {
    //Bài 32: Cho số nguyên dương n. Kiểm tra xem n có phải là số chính phương hay không
    class Program {
        static void Main(string[] args) {
            int n = 12;
            double b = Math.Sqrt(n);
            for (int i = 1;i<=b;i++)
            {
                if ( i * i == n)
                {
                    Console.WriteLine(n + " là số chính phương");
                }
                else
                {
                    Console.WriteLine(n + " không phải là số chính phương");
                }
            }
        }
    }
}