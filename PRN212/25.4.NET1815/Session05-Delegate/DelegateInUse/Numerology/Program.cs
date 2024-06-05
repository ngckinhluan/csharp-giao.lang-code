namespace Numerology
{
    public class Program
    {
        static void Main(string[] args)
        {
            // 1. IN HẾT DÃY SỐ CÓ TRONG NUMBER SERVICE
            NumberService.PrintNumbers(x => Console.Write($"{x} "));
  
            // 2. IN CÁC SỐ ÂM TRONG KHO
            Console.WriteLine("< 0");
            NumberService.PrintNumbers(x =>
            {
                if (x < 0) Console.Write($"{x} ");
            });

            // hàm lẻ nhận vào x làm gì với x kệ void F(int x) {... hay in luôn}
            Console.WriteLine();
            Console.WriteLine(" > 0");
            NumberService.Count(x => x > 0);
            Console.WriteLine(" < 0");
            NumberService.Count(x => x < 0);
        }
    }
}
