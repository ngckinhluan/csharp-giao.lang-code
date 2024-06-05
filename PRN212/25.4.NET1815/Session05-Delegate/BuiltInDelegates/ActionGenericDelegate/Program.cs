using System.Threading.Channels;

namespace ActionGenericDelegate
{
    // C#6: VIẾT HÀM NHẬN VÀO 1 SỐ NGUYÊN DƯƠNG, IN RA BÌNH PHƯƠNG CỦA NÓ
    // VIẾT HÀM LẺ CÓ SẴN NGOÀI KIA
    // ANONYMOUS FUNC, LAMBDA EXPRESSION => XÀI DELEGATE ÒI
    // C#7: VIẾT HÀM NHẬN VÀO 1 SỐ NGUYÊN DƯƠNG, IN RA BÌNH PHƯƠNG CỦA NÓ
    // DÙNG ANNONYMOUS
    // C#8: VIẾT HÀM NHẬN VÀO 1 SỐ NGUYÊN DƯƠNG, IN RA BÌNH PHƯƠNG CỦA NÓ
    // DÙNG LAMBDA
    //public delegate void OneInputNoOutputDelegate(int n);
    //                      voidF(int n) 
    // MICROSOFT BẢO RẰNG: HÀM MÀ KO TRẢ RA GÌ CẢ, GỌI LÀ HÀNH ĐỘNG, ACTION 
    // TUY NHIÊN CÓ LOẠI HÀNH ĐỘNG / HÀM CÓ CẦN ĐẦU VÀO, 1 ĐẦU, 2 ĐẦU, 3 ĐẦU VÀO...
    // N ĐẦU VÀO -> CŨNG LÀ HÀNH ĐỘNG, CŨNG LÀ ACTION
    // TUY THẾ 1 ĐẦU VÀO CÓ THỂ LÀ INT, LONG, STUDENT, FLOAT
    //         2 ĐẦU VÀO CÓ THỂ LÀ INT| INT  INT / LONG, STRING / STRING, STIRNG / INT
    // HÀM NHIỀU THAM SỐ | THAM SỐ KHÁC NHAU VỀ DATA TYPE, THỨ TỰ DATA TYPE!!!
    // VÔ CHỪNG LOẠI HÀM NHƯ THẾ NÀY???
    // GENERIC XUẤT HIỆN, DÙ BẠN INT, LONG, CHAR, PERSON, STUDENT BẠN LÀ DATA TYPE <T> MÀ THÔI, LÚC NÀO CẦN DÙNG, THAY <T> BẰNG DATA TYPE CỤ THỂ
    public delegate void OneInputNoOutputDelegate(int n);
    //                      void F(int x)
    // KỂ TỪ NAY VỀ SAU, MỖI KHI NÓI VỀ HÀM VOID, KO ĐẦU VÀO, THÌ XÀI
    // Action f =
    // KỂ TỪ NAY VỀ SAU, MỖI KHI NÓI VỀ HÀM VOID, CÓ ĐẦU VÀO, 1, 2,3 ,4 ,.. 16 ĐẦU VÀO
    // THÌ XÀI, KHAI BÁO, DÙNG DELEGATE CÓ SẴN, STYLE GENERIC NHƯ SAU
    // Action <int>          f = hàm có 1 đầu vào int
    // Action <char>         f = hàm có 1 đầu vào char
    // Action <Student>      f = hàm có 1 đầu vào Student
    // Action <int, int>     f = hàm có 2 đầu vào int, int
    // Action <Student, int> f = hàm có 2 đầu vào String, int
    // Action <16 đầu vào>   f = hàm có 16 đầu vào, tùy data type bạn cần

    internal class Program
    {
        static void Main(string[] args)
        {
            OneInputNoOutputDelegate f = ComputeExponent; // truyền thống, delegate tự trồng, tự build
            Action<int> f2 = ComputeExponent;
            Console.WriteLine("C#9: Using Action<> Generic on the method with up to 16 params");
            f2(1000);

            // C#10: Dùng ACTION<> TÍNH MŨ 3 CỦA 1 CON SỐ VÀ IN RA. DÙNG LUÔN
            // ANONYMOUS & LAMDA EXPRESSION
            Action<int> f3 = x => Console.WriteLine($"{x} ^ 3 = {Math.Pow(x, 3)}");
            f3(10);

            // C#11: VIẾT HÀM IN RA DIỆN TÍCH HÌNH CHỮ NHẬT - WIDTH, LENGTH
            Action<double, double> f6 = (width, length) => Console.WriteLine($"Area ({width} x {length}) = {width * length}");
            f6(4, 5);
            Console.WriteLine("\nC#11: USING ACTION<> GENERIC ON THE METHOD WITH UP TO 16 PARAMS - AREA OF RECTANGLE");
            f6(20, 10);
            // C#12: IN RA SỐ CHẴN TỪ 1 ĐẾN N...
            Action<int> f8 = n =>
            {
                Console.WriteLine("The list of even numbers from 1 to n");
                if (n < 1)
                {
                    Console.WriteLine("Invalid input");
                    return;
                }

                for (int i = 1; i <= n; i++)
                {
                    if (i % 2 == 0) Console.Write($"{i} ");
                }
            };
            f8(-2);
        }

        static void ComputeRectangleArea(double width, double length) => Console.WriteLine($"Area ({width} x {length}) = {width * length}");





        //static void Main(string[] args)
        //{
        //    Console.WriteLine("C#6: CALL METHOD AS NORMAL");
        //    ComputeExponent(5); // 25
        //    Console.WriteLine("C#7: CALL METHOD USING ANONYMOUS FUNC");
        //    OneInputNoOutputDelegate f1 = ComputeExponent; // đc quyền hàm cùng style, BẰNG TÊN HÀM NÀO ĐÓ NGOÀI KIA, HÀM CÓ 2 TÊN, THÊM NICK
        //    OneInputNoOutputDelegate f2 = (x) => Console.WriteLine($"Bình phương của {x} là {x * x}");
        //    f2.Invoke(10);
        //    f2.Invoke(25);
        //}
        static void ComputeExponent(int x) => Console.WriteLine($"Bình phương của {x} là {x * x}");

    }
}
