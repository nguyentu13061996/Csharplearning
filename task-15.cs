using System;

namespace task-15 {
    //Bài 34: Tính S(n) = CanBac2(n+CanBac2(n – 1 + CanBac2( n – 2 + … + CanBac2(2 + CanBac2(1)  có n dấu căn
    class Program {
        static void Main(string[] args) {
            int n = 12;
            double b = 0;
            for (int i = 0;i<=n;i++)
            {
                b = Math.Sqrt(i + Math.Sqrt(b));
            }
            Console.WriteLine(b);
        }
    }
}