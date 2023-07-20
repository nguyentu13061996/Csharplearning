using System;

namespace task-4 {
    //Bài 23: Đếm số lượng “ước số” của số nguyên dương n
    class Program {
        static void Main(string[] args) {
            int n = 12;
            int b = 0;
            for (int i=1; i<=n; i++)
            {
                a = n % i;
                if (a == 0)
                {
                    b++;
                }
            }
            Console.WriteLine(b);
        }
    }
}