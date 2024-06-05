namespace ActionDelegate
{
    // CHALLENGE #1: VIẾT HÀM IN RA CÂU THÔNG BÁO: NAM EM ĐÃ RA VIỆN RỒI!!!
    // VIẾT THEO STYLE TRUYỀN THỐNG, NHỚ RUN HÀM
    // C#2: VIẾT HÀM IN RA CÂU THÔNG BÁO: NAM EM VÀ 35 TRIỆU
    // C#3: VIẾT HÀM IN RA CÂU THÔNG BÁO: 8 / 3 / 2024: CHÚNG TA CỦA TƯƠNG LAI
    // C#4: DÙNG LẠI HÀM C#1 KẾT HỢP VỚI DELEGATE
    // C#5: KO DÙNG DELEGATE DO TA TẠO RA, NOINPUTOUTPUTDELEGATE() ANY MORE MICROSOFT, .NET SDK CUNG CẤP SẴN CHO TA 1 DELEGATE STYLE VOID F()
    // GỌI LÀ: Action, làm đi, hành động đi, run đi, vậy thoy, ko cần vào, ko cần ra
    // NẾU SAU NÀY BẠN CẦN LÀM VIỆC VỚI HAM KO-VÀO-KO-RA THÌ TA KO CẦN TẠO DELEGATE
    // MÀ XÀI LUÔN Action và chỉ việc khai báo biến = trỏ đến hàm nào là xong
    // C#5: VIẾT HÀM IN RA CÂU THÔNG BÁO "8/3/2K4l CHÚNG TA CỦA TƯƠNG LAI | SƠN TÙNG M-TP vs HẢI TÚ VS THIỀU BẢO TRÂM "
    // DÙNG DELEGATE & LAMBDA
    // DÙNG DELEGATE & ANONYMOUS FUNCTION
    delegate void NoInputNoOutputStyle();
    //  VOID F() STYLE

    internal class Program
    {
        static void Main(string[] args)
        {
            NoInputNoOutputStyle f1 = delegate () { };
            NoInputNoOutputStyle f2 = delegate () { };
            // Action f3 = () => { };
            Console.WriteLine("C#5: XÀI ACTION");
            Action f4 = ShowNotication; // truyến thống hàm có sẵn ngoài kia
            f4(); // Nam Em đã ra viện
            Action f5 = () => Console.WriteLine("8/3/2024: CHÚNG TA CỦA TƯƠNG LAI");
            f5.Invoke();
        }
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("CHALLENGE #1 - CALL METHOD AS NORMAL");
        //    ShowNotication();
        //    Console.WriteLine("CHALLENGE #2 - CALL METHOD ANNONYMOUS FUNCTION");
        //    NoInputNoOutputStyle f = () =>
        //    {
        //        Console.WriteLine("2/3/2024: NAM EM VÀ 35.000.000 VNĐ");
        //    };
        //    f.Invoke();
        //    Console.WriteLine("CHALLENGE #3 - CALL METHOD USING LAMBDA");
        //    NoInputNoOutputStyle f2 = () =>
        //    {
        //        Console.WriteLine("8/3/2024: CHÚNG TA CỦA TƯƠNG LAI");
        //    };
        //    f2.Invoke();
        //    NoInputNoOutputStyle f3 = () => Console.WriteLine("8/3/2024: CHÚNG TA CỦA TƯƠNG LAI");
        //    f3.Invoke();
        //    Console.WriteLine("CHALLENGE #4 - CALL METHOD USING DELEGATE & EXPLICIT METHOD");
        //    NoInputNoOutputStyle f4 = ShowNotication; // gán = hàm có sẵn
        //    // luật sư - thân chủ
        //    f4.Invoke();
        //}

        static void ShowNotication() => Console.WriteLine("2/3/2024: NAM EM ĐÃ RA VIỆN");
        // HÀM FULL TÊN, XÀI => ĐÍCH THỊ MÀY LÀ EXPRESSION BODY

        
        
    }
}
