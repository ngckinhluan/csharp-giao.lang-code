using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numerology
{
    public class NumberService
    {
        private static List<int> _arr = new List<int> { -10, -5, -1, 5, 10, 15, 20, 1, 3, 5, 7, 99, 101 };

        public static void PrintNumbers(Action<int> f)
        {
            foreach (var x in _arr)
            {
                f(x); // tao lần lượt gửi data cho mày, cho hàm f() hàm f() làm gì với data kệ
                // nếu f() check x > 0 mới in, PrintNumbers() chính là hàm in ra các số > 0
            }
        }
        // style cũ: thiết kế đủ các loại hàm cung cấp data! Đủ cỡ nào cũng ko đủ, do nhu cầu tính toán khác nhau trên bộ data: có người tính tổng chẳn, lẻ, âm, dương, nguyên tố chia hết cho 5, chia hết cho 10
        public static void Count(Predicate<int> f) // = hàm CheckNT(int x)
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

            Console.WriteLine($"Count: {count}");
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
