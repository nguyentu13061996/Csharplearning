//Bài 28: Cho số nguyên dương n. Tính tổng các ước số nhỏ hơn chính nó
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
                    if (i < n)
                    {
                        b = b + i;
                    }
                }
            }
            Console.WriteLine(b);
        }
    }