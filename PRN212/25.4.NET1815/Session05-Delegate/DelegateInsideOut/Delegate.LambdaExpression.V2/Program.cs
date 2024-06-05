namespace Delegate.LambdaExpression.V2
{
    // TA CHƠI HÀM CÓ ĐẦU VÀO, KO TRẢ VỀ GÌ CẢ, STYLE VOID F(INT)
    // CHALLENGE: IN CÁC SỐ TỪ 1...N
    // CHƠI ANONYMOUS, CHƠI LAMBDA
    delegate void OneInputNoOutput(int n);
    
    internal class Program
    {
        static void Main(string[] args)
        {
            // Print from 1 to n
            OneInputNoOutput f = (n) =>
            {
                for (int i = 1; i <= n; i++)
                {
                    if (n < 1)
                    {
                        Console.WriteLine("n must be greater than 0");
                        return;
                    }
                    Console.Write($"{i} ");

                }
                Console.WriteLine();

            };
            f(9);

            f = (n) =>
            {
                for (global::System.Int32 i = 0; i < n; i++)
                {
                    Console.WriteLine("I Love Uyen Nhi");
                }

            };
            f(4); 

        }
    }
}
