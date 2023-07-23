//Bài 31: Cho số nguyên dương n. Kiểm tra xem n có phải là số nguyên tố hay không
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
                    b++;                   
                }
            }
            if (b == 2)
            {
                Console.WriteLine(n + " là số nguyên tố");
            }
            else {
                Console.WriteLine(n + " không phải là số nguyên tố");
            }
        }
    }