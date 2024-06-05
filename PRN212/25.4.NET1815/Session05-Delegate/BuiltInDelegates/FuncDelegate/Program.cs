namespace FuncDelegate
{
    // C#13: VIẾT HÀM NHẬN VÀO 1 CON SỐ, SAU ĐÓ TRẢ VỀ BÌNH PHƯƠNG CỦA NÓ
    // CÓ RETURN, KO IN RA TRONG HÀM
    delegate double OneInputOneOutputDelegate(double value);
    //                      double F(double x)  
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C#13 - METHOD RETURN VALUE");
            OneInputOneOutputDelegate f1 = ComputeExponent; // truyền thống, delegate tự trồng, tự build
            f1(5); // 25 ko có 25 mặc dù vẫn tính ra 25
            var result = f1(5);
            Console.WriteLine($"5 ^ 2 = {result}");
            Console.WriteLine($"10 ^ 2 = {f1(10)}");
            // C#14: TÍNH BÌNH PHƯƠNG CỦA 1 CON SỐ RỒI TRẢ VỀ KẾT QUẢ
            Func<int, double> f = x => x * x;
            Console.WriteLine("C#14 - METHOD RETURNS VALUE USING FUNC<>");
            Console.WriteLine("1000^2 = " + f(1000));
            // C#15: TÍNH CHU VI CỦA TAM GIÁC
            Func<double, double, double, double> f2 = (x, y, z) => x + y + z;
            Console.WriteLine("C#15: Triangle Func<>");
            Console.WriteLine($"3 + 4 + 5 = {f2(3, 4, 5)} ");
            // C#16: THÁCH THỨC DANH HÀI: VIẾT HÀM TRẢ VỀ CON SỐ BẤT KÌ (NGẪU NHIÊN / BẠN THÍCH) 6789 SBTC 2204 MMKC
            Func<int> getMyOwnNumber = () => 6789;
            Console.WriteLine("C#16 - RANDOM NUMBER<>");
            Console.WriteLine("My own number" + getMyOwnNumber.Invoke());
            // C#17:  VIẾT HÀM NHẬN VÀO 1 CON SỐ DOUBLE GPA - ĐIỂM TRUNG BÌNH
            // TRẢ VỀ TRUE NẾU GPA >= 8, TRẢ VỀ FALSE NẾU GPA < 8
            Console.WriteLine("C#10 - RANDOM NUMBER<>");
            Console.WriteLine(" 10 >= 8 ? " + CheckGradeGtEg8(10));
            Func<double, bool> CheckHang8 = gpa => gpa >= 8;
            
            Console.WriteLine(" 10 >= 8 ? " + CheckHang8(10));
            
            // MS LẠI BẢO RẰNG, MẾU HÀM CÓ TRẢ VỀ GIÁ TRỊ int, long, char, Student, Car, Pet,...
            // và hàm có thể có đầu vào hay ko, kệ, THÌ HÃY XÀI 1 DELEGATE STYLE GENERIC
            // TÊN LÀ FUNC
            // Func<int> -> hàm ko đầu vào, trả về int
            // Func<long> -> hàm ko đầu vào, trả về long
            // Func<char> -> hàm ko đầu vào, trả về char
            // Func<Student> -> hàm ko đầu vào, trả về Student
            // Func<int, int> -> hàm có 1 đầu vào int, trả về int
            // Func<double, double, double> -> hàm có 2 đầu vào double double, trả về double
            // BÊN PHẢI NHẤT LÀ ĐẦU RA, CÒN LẠI LÀ ĐẦU VÀO, CHƠI GENERIC CẢ ĐÁM
            // HÀM 5 ĐẦU VÀO + 1 ĐẦU RA -> 6 GENERIC
            // HÀM CÓ TỐI ĐA 16 ĐẦU VÀO T1 T2 T3... T16 CỘNG VỚI THẰNG ĐẦU RA TRESULT
            // HÀ CÓ KO ĐẦU VÀO => 17 LOẠI HÀM
            // Func<int, int, long, char, Student, float, Pet, Lecture,... int>
            // -----------------------------------------------------------------
            // đầu vào                   đầu ra
        }

        // <html>   5 > 3 > < dùng đánh dầu tag
        //          5 &gt; 3
        //            greater than
        static bool CheckGradeGtEg8(double gpa)
        {
            if (gpa >= 8)   // biểu thức so sánh luôn trả về true / false
                // return luôn biểu thức so sánh cho rồi
                // đằng nào cũng cần ném ra true false
                // ném luôn biểu thức so sánh
                return true;
            return false;
        }

        static double ComputeExponent(double n) => n * n;

        // I look around and sin's city is cold and empty
        // No one's around to judge me
        // I can't see clearly when you're gone
        // I said, ooh, I'm blinded by the lights
        // No, I can't sleep until I feel your touch

    }
}
