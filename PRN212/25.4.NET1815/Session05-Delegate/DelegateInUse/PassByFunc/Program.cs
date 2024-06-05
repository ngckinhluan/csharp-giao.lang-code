using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace PassByFunc
{
    internal class Program
    {
        static private List<int> _arr = new List<int> { -5, -10, -1, 5, 10, 15, 20, 1, 3, 5, 7, 99, 101 };
        static void Main(string[] args)
        {
            // TÍNH TỔNG CHẴN
            Console.WriteLine("Sum of Even");
            SumOnDemand(CheckEven);

            // TÍNH TONG LẺ
            Console.WriteLine("Sum of Odds");
            SumOnDemand(n => n % 2 != 0);

            // TÍNH TỔNG CỦA TẤT CẢ
            SumOnDemand(x => true);
            // đưa x nào cũng là true, hàm trả về true cho mọi x
            // style cũ: thiết kế đủ cac loại hàm cung cấp data! Đủ cỡ nào cx ko là đủ, do nhu cầu tính toán khác nhau trên bộ data: có người tính chẵn, lẻ, âm, dương, nguyên tố, chia hết cho 5, chia 10,...
            // VIẾT HÀM ĐẾM CÁI GÌ ĐÓ TRONG DÃY SỐ TRÊN: ĐẾM CHẴN, ĐẾM LẺ, ĐẾM NGUYÊN TỐ, ĐẾM CHIA HẾT CHO 5, ĐẾM CHIA HẾT CHO 10.
            // NHÓM: GIÀNH KIỂM SOÁT, OUTSOURCE 1 PHẦN


        }

        public static void Count(Func<int, bool> f) // = hàm CheckNT(int x)
        {
            int count = 0;
            foreach (var x in _arr)
            {
                // nếu điều gì đúng thì ta count. Đưa điều đó vào đây hàm thích ứng với mọi kiểu đếm
                if (f(x))
                {
                    count++;
                }
            }
        }

        static bool CheckNum(int x) => true;

        static bool CheckEven(int n) => n % 2 == 0;



        // CHALLENGE: VIẾT HÀM TÍNH TỔNG CỦA 1 DÃY SỐ CHO TRUOC
        // VẪN DÃY SỐ ĐÓ, TÍNH TỔNG CỦA SỐ CHẴN
        // VẪN DÃY SỐ ĐÓ, ĐẾM CÁC SỐ LẺ
        // 5 10 15 20 2 4 6 8 1 3 5 7 9
        static void DoOnDemand(Predicate<int> f) // hàm bool F(int x)
        {
            List<int> arr = new List<int> { 5, 10, 15, 20, 2, 4, 6, 8, 1, 3, 5, 7, 9 };
        }
        // TÍNH TOÁN THEO ĐIỀU KIỆN ĐƯA VÀO
        // SUM: SUM CÁI GÌ (ĐIỀU KIỆN ĐƯA VÀO): SUM CHẴN, SUM LẺ, SUM NGUYÊN TỐ
        // COUNT: COUNT CÁI GÌ
        static void SumOnDemand(Func<int, bool> f) // = hàm bool F(int x)
        // CheckEvent(int x) -> true false
        {
            List<int> arr = new List<int> { 5, 10, 15, 20, 2, 4, 6, 8, 1, 3, 5, 7, 9 };
            int result = 0;
            foreach (var x in arr) // if đúng con x (tiêu chí nào đó) thì 
            // mình hàm TraiBao giành lại con x để làm gì tiếp
            {
                if (f(x)) // CheckEven(x)
                {
                    result += x;
                }
            }

            Console.WriteLine("Sum: " + result);


        }
    }
}
