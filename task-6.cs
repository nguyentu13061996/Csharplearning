using System;

namespace task-6 {
    //Bài 25: Tính tổng tất cả các “ước số chẵn” của số nguyên dương n
    class Program {
        static void Main(string[] args) {
            int n = 12;
            int b = 0;
            for (int i=1; i<=n; i++)
            {
                a = n % i;
                if (a == 0)
                {
                    if (i % 2 == 0)
                    {
                        b = b + i
                    }
                }
            }
            Console.WriteLine(b);
        }
    }
}