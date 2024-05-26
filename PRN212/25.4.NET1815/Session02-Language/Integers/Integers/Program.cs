using System.Globalization;

namespace Integers
{
    internal class Program
    {
        static void Main(string[] args) // svm tab
        {
            string msg = @$"Sum odds from 1..10: {SumOddNumbers()}";
            Console.WriteLine(msg);
        }
        // C6:
        // Sql: Select Sum, Count, Average,..
        //      From...
        //      Where...
        //      Group By...
        //      Having...
        // Lỡ 1 lần đi qua tập data, tính luôn nhiều giá trị!!!
        // Kẹt: Hàm trong Java, C, C# nói chung chỉ trả về 1 giá trị
        // Vậy có cách nào để giúp hàm trả về nhiều giá trị hay không khi chỉ gọi hàm 1 lần, giống select gộp nhiều hàm???
        // Có: Out, và Ref


        // C5: Viết hàm tính tổng tất cả các số lẻ từ 1...10
        // Expected Value: 1 3 5 7 9 = 25
        // Actual        : ??? Chờ chạy app đã
        static int SumOddNumbers()
        {
            var sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 != 0) 
                    sum += i;
            }

            return sum;
        }

        //static void Main(string[] args)
        //{
        //    PrintIntegerList();
        //    PrintEvenNumbers();
        //    Console.WriteLine("Please write your number: ");
        //    int n;
        //    try
        //    {
        //        n = Convert.ToInt32(Console.ReadLine());
        //        PrintNumbersFrom1ToN(n);
        //    }
        //    catch (FormatException)
        //    {
        //        Console.WriteLine("Invalid Number!");
        //    }

        //    var result = SumEvens();
        //    Console.WriteLine("Sum evens from 1...10: " + result);
        //    Console.WriteLine($"Sum evens from 1...10: {result}");
        //    Console.WriteLine("Sum evens from 1...10: {0}", result);
        //    Console.WriteLine(@$"Sum evens from 1...10: {result}");
        //    // 5.
        //    Console.WriteLine(@$"Sum evens from 1...10: {SumEvens()}");
        //    Console.WriteLine(@$"Can bậc 2 from 1...10: {Math.Sqrt(SumEvens())}");
        //    Console.WriteLine(@$"Can bậc 2 của 100: {Math.Sqrt(100)}");

        //    string msg = @$"Căn bậc 2 của 100 {Math.Sqrt(100)}";
        //    Console.WriteLine(msg);


        //}
        // C# hỗ trợ các kiểu dữ liệu số nguyên y chang Java: int, long,...
        // C# hỗ trợ các cấu trúc câu lệnh y change Java: if, if / else, switch, do - while, while
        // CHALLENGE #1: HÃY VIẾT MỘT HÀM IN RA CÁC SỐ TỰ NHIÊN TỪ 1...100
        // CHALLENGE #2: VIẾT HÀM IN RA SỐ CHẴN TỪ 1...100
        // CHALLENGE #3: VIẾT HÀM IN RA CÁC SỐ TỪ 1... ĐẾN N
        // Bữa sau: VAR, OUT, REF, OOP
        static void PrintIntegerList()
        {
            Console.WriteLine("The list of numbers from 1...100");
            for (int i = 1; i <= 100; i++)
            {
                Console.Write($"{i} ");
                //Console.Write(i + " ");
                //Console.Write(@$"{i} ");
                //Console.Write("{0} ", i);
            }
            Console.WriteLine(); // sống có trách nhiệm, in xong phải xuống hàng tránh ảnh hưởng hàm sau đó
        }

        //C4: Viet hàm tính tổng của các số chẵn từ 1 đến 10 (100)
        // 2 4 6 8 10 => 30! Hàm viết thế nào ra sao ko cần biết, chỉ cần biết rang nó phải trả về và in ra 30 - Expected Value
        // Hy vọng hàm trả về 30 - Expected Value
        // Còn thực tế lúc chạy hàm là bao nhiêu, Ví dụ 40, 50, có khi 30, đoán xem, thì giá trị trả về của hàm được gọi là actual value
        // Nếu actual == expected => Hàm ngon cho tình huống này!!!
        // Unit test trong môn SWT301


        static int SumEvens()
        {
            //int sum = 0; // nhồi các con số dần dần vào 1 2 3 4 5 6; nhồi 2 4 6 8 10
            var sum = 0; // Java cx có luôn
            // kĩ thuật ko chĩ rõ tường minh data tpye của biến mà data type của biến sẽ được suy luận từ giá trị gán vào và phải gán ngay lúc khai báo
            // type inference: suy luận kiểu data type của biến
            // xài var bắt buộc phải gán giá trị khởi đầu
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                    sum += i; // nếu trong for, if, else chỉ có 1 lệnh, bỏ {}
            } 
            return sum;
        }

        static void PrintEvenNumbers()
        {
            Console.WriteLine("The list of even numbers from 1...100");
            for (int i = 1; i <= 100; i++)
                if (i % 2 == 0) Console.Write($"{i} ");

            // sống có trách nhiệm
            Console.WriteLine();
        }

        static void PrintNumbersFrom1ToN(in int n) // biến cục bộ (biến global)
        {
            //n = 5000;
            // keyword ở tham số biến tham số thành read-only
            // để đảm bảo code lun xử lí đúng tham số đầu vào
            Console.WriteLine("The list of numbers from 1... to n");
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }

    // CHALLENGE AT HOME
    // KEYWORD "IN" BIẾN THAM SỐ ĐẦU VÀO CỦA HÀM THÀNH READONLY, VÀ NÓ CÓ THỂ ÁP DỤNG CHO BIÊN PRIMITIVE VÀ BIẾN OBJECT, HAY GỌI LÀ ÁP DỤNG CHO TRUYỀN THAM TRỊ VÀ THAM CHIẾU
    // IN NÓ BIẾN THAM SỐ THÀNH READONLY TỨC LÀ KO CHO THAY ĐỔI GIÁ TRỊ TRUYỀN VÀO HÀM
    // vậy hàm F(in int n) thì n ko cho đổi value ?
    // vậy hàm F(in Student x) thì x readonly cỡ nào, đc thay đổi và ko thay đổi cụ thể thế nào???
    // x là Student nó phức tạp hơn int x
}
