namespace LambdaExpression
{
    delegate void PlayNumberDelegate(int x); // nhóm hàm nhận vào 1 con x, muốn làm gì với x thì làm
    // 3 cách chơi với hàm
    // C1: làm 1 cái hàm tường minh - explicit, nhận x, làm gì đó in ra kq - CÓ GHẾ TRONG QUÁN CÀ PHÊ
    // C2: làm 1 hàm ẩn danh - anonymous method / function - implicit, éo thèm đặt tên hàm
    // éo thèm viết code riêng, tất cả gom cho thằng delegate
    // mày lấy code của tao, khỏi cần tên tao
    // C3: TỪ CÁCH 2 CẮT BỚT CODE DƯ THỪA!! => LAMBDA EXPRESSION (CODE KHÁ GIỐNG EXPRESSION BODY KHI NÓ CÙNG XÀI => NHƯNG COI CHỪNG, KHÁC ĐẤY

    // CÓ CÂU:
    internal class Program
    {

        static void Main(string[] args)
        {
            PlayNumberDelegate playNumber = MakeTriple; // hợp đồng luật sư thân chủ
            playNumber(3); // action gián tiếp

            // C2: LÀM BIẾNG ĐẶT CHỖ 1 HÀM TƯỜNG MINH, VÀO QUÁN KO NGỒI LẤY CAFE THÔI
            // TAKE AWAY, HỢP ĐỒNG LUẬT SƯ - THÂN CHỦ KO ĐỂ LẠI TÊN
            // HÀM VÔ DANH ANNONYMOUS FUNCTIONS / METHOD
            playNumber = delegate (int x)
            {
                Console.WriteLine($"{x}{x}{x}{x}");
            }; // đừng quên chấm phẩy kết thúc hợp đồng
            playNumber(9);

            // C3: CHỈ CÒN CÁI DÂY NỊT. GHÉP 5 LẦN ĐẦU VÀO!!! BIỂU THỨC LAMBDA
            playNumber = (int xxx) => Console.WriteLine($"{xxx}{xxx}{xxx}{xxx}");
            // CÓ CÂU: HÀM VÔ DANH RÚT GỌN CHỈ CÒN CÁI DÂY NỊT => BIẾN THÀNH BIỂU THỨC LAMBDA
            //         BIỂU THỨC LAMBDA LÀ HÀM VÔ DANH TRONG DELEGATE
            //         HÀM VÔ DANH KO HẲN LÀ LAMBDA VIẾT FULL
            //         LAMBDA GIỐNG EXPRESSION BODY VỀ KÍ HIỆU => VÀ SỰ LƯỢC BỚT
            //         NHƯNG EXPRESSION BODY PHẢI FULL
            playNumber(10);
            PrintStudent();
            // C3: CÒN CÁI DÂY NỊT MỎNG
            playNumber = xxx => Console.WriteLine($"{xxx}{xxx}{xxx}{xxx}");
            playNumber(68);
            Console.WriteLine($"Test: {CalculateSth(23)}");
        }
        // C1: HÀM TƯỜNG MINH
        static void MakeTriple(int n) => Console.WriteLine($"{n}{n}{n}");
        //                               expression body: hàm có 1 lệnh duy nhất, ko cần ngoặc return gì cả

        static Action PrintStudent = () => Console.WriteLine("Hello Student!");

        static Func<int, int> CalculateSth = x => x * x;
    }
}
