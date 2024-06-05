namespace DelegateReview.AnonymousFunc
{
    // khai báo data type, class chứa các hàm thuộc style void F()
    public delegate void NoInputNoOutputDelegate();
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintNumber(); // ko xài thân chủ - luật sư, call hàm directly
                           // chơi trực tiếp với hàm với tên gọi gốc - truyền thống
                           // luật sư = thân chủ = ủy quyền = phát ngôn giùm tui
                           // kí hợp đồng - cho em 1 cái tên mới, đặt nickname / 2nd name cho hàm gốc
            NoInputNoOutputDelegate f = PrintNumber; // ko dùng () vì đó là run hàm
            // phát ngôn, action thay, ủy quyền rồi
            Console.WriteLine("Call method indirectly - using delegate");
            f.Invoke();
            f = () => // anonymous function, hàm ko tên
            {
                Console.WriteLine("The list of even numbers from 1...100");
                for (int i = 2; i <= 100; i += 2)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            };

            
            f = () => // anonymous function, hàm ko tên
            {
                Console.WriteLine("The list of even numbers from 1...100");
                for (int i = 2; i <= 100; i += 2)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            };
            Console.WriteLine("Call method indirectly - using anonymous function again");
            f.Invoke(); // sổ lẻ
            // hack não: in vừa chẵn vừa lẻ
            // IN THÊM DÃY CHIA HẾT CHO 5
            f += () =>
            {
                Console.WriteLine("NAM EM VS NHÃ PHƯƠNG | ĐÀO.MAI");
            };
            Console.WriteLine("Đoán Xem");
            f();
            Console.WriteLine("CHẴN LẺ SONG HÀNH");
            f += () => // anonymous function, hàm ko tên
            {
                Console.WriteLine("The list of odd numbers from 1...100");
                for (int i = 1; i <= 100; i += 2)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            };

            // VIP ĐỂ KẾT THÚC 1 LỆNH - 1 PHÉP GÁN HỢP ĐỒNG LUẬT SƯ THÂN CHỦ
            // đoạn code ở trên, mày thuộc hàm nào??? hàm phải có tên
            // dạ  d9aon5 code trên ngày xưa em thuộc hàm PrintEvenNumbers
            // nay bán cái tên đi rồi, còn lại xử lí thôi, gọi hãm cũ qua tên mới f, delegate ủy quyền hàm cũ, xử lí hàm cũ cho chữ f nó đại diện
            // HÀM GỐC CẦN TÊN, MÀ SẼ GỌI QUA HỢP D9NG62 VỚI LUẬT SƯ!!
            // HÀM ẨN DANH - ANONYMOUS FUNCTION
            // ĐOẠN CODE CỦA HÀM GỐC, NAY DÙNG NICKNAME TÊN LUẬT SƯ
            // CHỈ CÒN 1 TÊN MÀ KO LÀ TÊN GỐC
            // GỌI QUA TÊN MỚI
            // luật sư phát ngôn, run hàm
            Console.WriteLine("Call method indirectly - using anonymous function");
            f.Invoke();
        }
        // CHALLENGE: VIẾT HÀM IN RA CÁC SỐ TỰ NHIÊN TỪ 1...100
        static void PrintNumber()
        {
            Console.WriteLine("The list of numbers from 1...100");
            for (int i = 1; i <= 100; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }

        // CHALLENGE: VIẾT HÀM IN RA CÁC SỐ CHẴN TỪ 1...100
        //static void PrintEvenNumbers()
        //{
        //    Console.WriteLine("The list of even numbers from 1...100");
        //    for (int i = 2; i <= 100; i += 2)
        //    {
        //        Console.Write($"{i} ");
        //    }
        //    Console.WriteLine();
        //}

        // THÁCH THỨC: VIẾT HÀM IN RA CÁC SỐ LẺ TỪ 1...100
        // BẮT BUỘC PHẢI XÀI ANONYMOUS
        // cú pháp viết anonymous function
        // Tên-DELEGATE-DATA-TYPE TÊN-BIẾN-NICK-LUẬT-SƯ = delegate () { // body of function };
    }
}
