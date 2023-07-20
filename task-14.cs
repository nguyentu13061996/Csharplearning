using System;

namespace task-14 {
    //Bài 33: Tính S(n) = CanBac2(2+CanBac2(2+….+CanBac2(2 + CanBac2(2)))) có n dấu căn
    class Program {
        static void Main(string[] args) {
            int n = 12;
            double b = 0;
            for (int i = 0;i<=n;i++)
            {
                b = Math.Sqrt(2 + b);
            }
            Console.WriteLine(b);
        }
    }
}