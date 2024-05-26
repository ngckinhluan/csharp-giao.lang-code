using static System.Runtime.InteropServices.JavaScript.JSType;

namespace IntegersOutV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // tính tổng hàm trả về tất cả 6 món
            int sumA = ComputeNumbers(out int sumO, out int countO, out int sumE, out int countE, out int countP);
            Console.WriteLine("Sum all: " + sumA);
            Console.WriteLine("Sum odds: " + sumO);
            Console.WriteLine("Count odds: " + countO);
            Console.WriteLine("Sum evens: " + sumE);
            Console.WriteLine("Count Evens: " + countE);
            Console.WriteLine("Count Primes: " + countP);
            // 1...10 1 2 3 4 
        }

        static bool IsPrime(int number)
        {
            // Viết code for đến căn bậc 2 tìm ước số
            // Nếu lỡ chia hết, false liền
            // Math.Sqrt(n) căn bậc 2
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }

        static int ComputeNumbers(out int sumOdds, out int countOdds, out int sumEvens, out int countEvens, out int countPrime)
        {
            sumOdds = 0;
            countOdds = 0;
            sumEvens = 0;
            countEvens = 0;
            countPrime = 0;
            var sumAll = 0;
            for (int i = 1; i <= 10; i++)
            {
                sumAll += i; // sumAll = sumAll + i;
                if (i % 2 == 0)
                {
                    countEvens++;
                    sumEvens += i;
                } // chẵn thì tổng chẵn, đếm chẵn
                else
                { 
                    countOdds++;
                    sumOdds += i;
                }

                if (IsPrime(i))
                {
                    countPrime++;
                }
            }
            return sumAll;
        }
    }
}


        // Challenge #1: Viết hàm trả về
        // tổng các số từ 1...100
        // tổng các số chẵn từ 1...100
        // ...
    

