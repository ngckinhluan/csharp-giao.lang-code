using System.Threading.Channels;

namespace PassByAction
{
    // CHALLENGE: VIẾT HÀM THẦU CÁC HÀNH ĐỘNG NÀO ĐÓ BÊN NGOÀI ĐƯA VÀO
    //            HÀM THẦU CÁC DOCH5 VỤ IN ẤN NÀO ĐÓ: IN BÀI HÁT, IN SỐ, IN DÃY...
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            // Sqrt(25); // run
            DoOnDemand(delegate ()
            {
                Console.WriteLine("Cầm tay anh, dựa vai anh");
                Console.WriteLine("Code cùng anh, nơi này có C#");
            });

            DoOnDemand(() =>
            {
                Console.WriteLine("Chúng ta ko thuộc về nhau");
                Console.WriteLine("C# chắc có là của nhau");
            });

        }
        //           DoSomething(int n)
        static void DoOnDemand(Action f) // = hàm nào đó có style
                                         // = hàm ẩn danh hay hàm lambda
        {
            Console.WriteLine("Do - while - for - code as normal");
            // later, call back f
            f(); // f.Invoke();
        }
    }
}
