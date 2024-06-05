namespace PredicateDelegate
{
    // MICROSOFT BẢO RẰNG: NẾU HÀM NHẬN VÀO ĐÚNG 1 ĐẦU VÀO, CHỈ CÓ 1 ĐẦU VÀO HÀM TRẢ VỀ ĐÚNG SAI
    // MỞ RỘNG THÊM: TOÁN LOGIC, TOÁN MỆNH ĐỀ - CÂU PHÁT BIỂU ĐÚNG SAI 
    // CÓ HÀM MỆNH ĐỀ - HÀM NHẬN 1 ĐẦU VÀO SAU ĐÓ TRẢ VỀ 1 CÂU PHÁT BIỂU ĐÚNG SAI HÀM NÀY ĐC GỌI LÀ HÀM TIÊN ĐOÁN, HÀM DỤ ĐOÁN, HÀM MỆNH ĐỀ, HÀM ĐÁNH GIÁ, HÀM LƯỢNG GIÁ, PREDICATE - LOGIC VỊ TỰ
    // Ông x là 1 nhà toán học -> câu này ko biết đúng sai, vì X là biến
    // Hàm IsNhaToanHoc( ông / bà X nào đó)
    // Hàm nhận vào con người, trả ra đúng sai nếu đó là nah2 toán học hay ko
    // IsNhaToanHoc(Ngô Bảo Châu) => Ông Ngô Bảo Châu là 1 nhà toán học => Mệnh đề đúng
    // IsNhaToanHoc(giáo.làng) => SAI MỌE NÓ RỒI, GÃ LÀM THUÊ CHO TƯ BẢN ĐAM MÊ CODE, KO ĐAM MÊ TIỀN 7H SÁNG ĐẾN 7H 5 CÒN VÀI PHÚT NỮA!!
    // Predicate(???) => true / false
    // HÃY ĐOÁN XEM ??? LÀ ĐÚNG HAY SAI
    // MICROSOFT BẢO RẰNG: NẾU HÀM NHẬN VÀO ĐÚNG 1 ĐẦU VÀO, CHỈ CÓ 1 ĐẦU VÀO HÀM TRẢ VỀ ĐÚNG SAI
    // tHAY VÌ KHAI BÁO Func<double, bool> THÌ KHAI BÁO LÀ Predicate<double> là đủ
    // tHAY VÌ KHAI BÁO Func<double, bool> THÌ KHAI BÁO LÀ Predicate<int> là đủ
    // THAY VÌ KHAI BÁO Func<Student, bool> THÌ KHAI BÁO LÀ Predicate<Student> là đủ
    // kiểm tra xem Student x có đúng là??
    internal class Program
    {
        static void Main(string[] args)
        {
            // hàm cuối cùng #18 viết hàm nhận vào 1 con số gpa, trả về nó lớn hơn hay bằng 8 hay ko
            Func<double, bool> check8V1 = gpa => gpa >= 8;
            Predicate<double> check8Final = gpa => gpa >= 
            //                  hàm         nhận vào
            //                              con gpa    trả ra có đúng là nó lớn hơn 8 hay ko
                8;
            Console.WriteLine("Final fantasy: 10 >= 8? " + check8Final(10));

            // LINQ TORNG COLLECTION, LIST TOÀN XÀI LAMBDA!! FILTER DATA
            // LỆNH CUỐI CÙNG
            // CÂU VIEW
            var x = 2004.715; // 7h 15 phút
            var fx = (double a, double b, double c) => a + b + c;
            // hàm tính chu vi tam giác, tổng 3 số
            Func<double, double, double, double> fxx = (a, b, c) => a + b + c;
        }
    }
}
