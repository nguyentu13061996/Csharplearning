//Bài 35: Tính S(n) = CanBac2(n! + CanBac2((n-1)! +CanBac2((n – 2)! + … + CanBac2(2!) + CanBac2(1!)))) có n dấu căn
    class Program {
        static void Main(string[] args) {
            int n = 2;
            double a = 1;
            double b = 1;
            for (int i = n; i >= 1; i--)
            {
                a = i * a;
                b = Math.Sqrt(a + b);
            }
            Console.WriteLine(b);
        }
    }
    