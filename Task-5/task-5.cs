//Bài 24: Liệt kê tất cả các “ước số lẻ” của số nguyên dương n
    class Program {
        static void Main(string[] args) {
            int n = 12;
            double a;
            for (int i=1; i<=n; i++)
            {
                a = n % i;
                if (a == 0)
                {
                    if (i % 2 != 0)
                    {
                       Console.WriteLine(i);
                    }
                }
            }        
        }
    }
