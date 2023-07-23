//Bài 27: Đếm số lượng “ước số chẵn” của số nguyên dương n
    class Program {
        static void Main(string[] args) {
            int n = 12;
            int b = 0;
            double a;
            for (int i=1; i<=n; i++)
            {
                a = n % i;
                if (a == 0)
                {
                    if (i % 2 == 0)
                    {
                        b++;
                    }
                }
            }
            Console.WriteLine(b);
        }
    }