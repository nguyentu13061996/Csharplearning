// Bài 32: Cho số nguyên dương n. Kiểm tra xem n có phải là số chính phương hay không
    class Program {
        static void Main(string[] args) {
            int n = 12;
            double b = Math.Sqrt(n);
            if (b == (int)b && b * b == n) {
                Console.WriteLine(n + " là số chính phương");
            }
            else {
                Console.WriteLine(n + " không phải là số chính phương");
            }
        }
    }
