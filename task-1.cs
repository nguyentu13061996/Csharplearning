using System;

namespace task_1
{
    // Bài 20: Liệt kê tất cả các "ước số" của số nguyên dương n
    class Program {
        static void Main(string[] args) {
            int n = 12;
            for (int i = 1; i <= n; i++) {
                int a = n % i;
                if (a == 0) {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
