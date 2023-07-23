
//Bài 22:Tính tích tất cả các “ước số” của số nguyên dương n
    class Program {
        static void Main(string[] args) {
            int n = 12;
            int b = 1;
            int a;
            for (int i=1; i<=n; i++)
            {
                a = n % i;
                if (a == 0)
                {
                    b = b * i;
                }
            }
            Console.WriteLine(b);
        }
    }