namespace DelegateReviewLambdaExpression
{
    // CHALLENGE: IN CHO TUI TỔNG CÁC SỐ TỪ 1 CHO ĐẾN 100 -> 5050
    // hàm void F() - không tham số không trả về
    internal delegate void NoInputOutputDelegate();
    internal class Program
    {
        static void Main(string[] args)
        {
            //NoInputOutputDelegate f = Sum;
            NoInputOutputDelegate f = () =>
            {
                int sum = 0;
                for (int i = 1; i <= 100; i++)
                {
                    sum += i;
                }
                Console.WriteLine("The sum 1...100: " + sum);
            }; // hợp đồng bán tên - vô danh
            f(); // phát ngôn - run

            // tui mún tính tổng các số chẵn từ 1..10
            // 2 4 6 8 10
            // KĨ THUẬT RÚT GỌN PHÂN SỐ / BIỂU THỨC
            // RÚT GỌN ANONYMOUS METHOD ĐỂ CHỈ CÒN CÁI DÂY NỊT => LAMBDA EXPRESSION
            f = () =>
            {
                int sum = 0;
                for (int i = 2; i <= 10; i += 2)
                {
                    sum += i;
                }
                Console.WriteLine("The sum of even numbers from 1...10: " + sum);
            };
            Console.WriteLine("To see the sum of 30");
            f();
            // hợp đồng bán tên - vô danh
            // BIỂU THỨC LAMDA: BẢN CHẤT LÀ HÀM ANONYMOUS NHƯNG VIẾT RÚT GỌN ĐẾN MỨC TỐI GIẢN - CHỈ CÒN CÁI DÂY NỊT
            // CÓ CÂU: LAMBDA LÀ ANONYMOUS
            // ANONYMOUS KO HẲN LÀ LAMBDA NẾU CHƯA TỐI GIẢN
            // EXPRESSION BODY VÀ LAMBDA EX XÀI CHUNG KÍ HIỆU =>
            // NHƯNG KHÁC NHAU
            // EXPRESSION BODY HÀM VẪN CÒN FULL TÊN; HÀM CHỈ CÓ 1 LỆNH; RÚT GỌN LUÔN CẢ CẶP DẤU {}
            // LAMBDA EX: BỐI CẢNH HÀM VÔ DANH, CHƠI VỚI DELEGATE
            // HÀM KO CÓ TÊN
            // CÓ THỂ RÚT GỌN {} HOẶC KO TÙY HÀM NHIỀU LỆNH HAY ÍT LỆNH
            // HÀM 1 LỆNH ĐC QUYỀN LOẠI BỎ {}
            // CÚ PHÁP GÕ LAMBDA
            // Tên-data-type-delegate biến-trỏ-hàm = delegate(){...} //
            // ANONYMOUS
            // Tên-data-type-delegate biến-trỏ-hàm =() => {...};
            // RÚT GỌN TIẾP...

            // LAMDA
            // Tên - data-type-delegate biến-trỏ-hàm =() => {...};
            // RÚT GỌN CHỈ CHỪA LẠI THAM SỐ () => VỚI THÂN HÀM {}


            static void Sum()
            {

            }
        }
    }
}
