namespace DelegateReview
{
    // MỘT NAMESPACE, KO GIAN, THƯ MỤC TRÊN GIẤY TỜ ĐỂ NÓI VỀ HỘ KHẨU CỦA CÁI CLASS, NƠI Ở, ĐỊNH CƯ CỦA CÁI CLASS, THƯỜNG MẶC ĐỊNH SẼ LẤY TÊN THƯ MỤC TRÊN HDD / SDD ĐỂ NÓI VỀ HỘ KHẨU CỦA CÁI CLASS - TÊN NAMESPACE - TÊN PACKAGE
    // MỘT NAMESPACE SẼ CHỨA NHIỀU CLASS ~ CÁI KHUÔN SẼ NẰM Ở ĐÂU TRONG XƯỞNG SẢN XUẤT
    // MỘT XƯỞNG CÓ NHIỀU KHUÔN - NAMESPACE CÓ NHIỀU CLASS
    // TA CÓ THỂ KHAI BÁO CÁC CLASS RIÊNG RẼ, MIỄN LÀ PHẦN ĐẦU NÓI RẰNG NÓ THUỘC VỀ KO GIAN NÀO, HỘ KHẨU NÀO, NAMEPSACE NÀO
    // ĐẦU TẬP TIN SOURCE CODE SẼ CHỨA CÁI KHAI BÁO NAMESPACE ĐỂ QUẢN LÍ CÁC CLASS THUỘC VỀ NÓ
    // TRONG 1 TẬP TIN SOURCE, TA CÓ THỂ KHAI BÁO CLASS KHÁC NGOÀI CLASS DEFAULT CÓ SẴN KHI TẠO TẬP TIN SOURCE
    public class Lecturer
    {

    }

    public class Student
    {
        // là 1 cái khuôn có nhiều khoảng trống bên trong để đổ vào các info của 1 object cần đúc, cần lưu trữ
    }
    // Student    s         = new Student(...){...};
    // data-type  biến / nick-name    object,  value
    //            tên gọi cho 1       phức tạp
    // delegate là kĩ thuật thiết kế 1 cái class đặc biệt
    // class này ko lưu info của các object theo style truyền thống; mà nó đi lưu thông tin là: TÊN CỦA CÁC HÀM TỒN TẠI ĐÂU ĐÓ NGOÀI KIA
    //public class X [void X()] : Delegate
    //{
    //    // biến lưu các tên hàm, hay nhiều tên hàm
    //    // _list-tên-của-các-hàm-cần-lưu-trỏ-đến
    //    public X(đưa-vào-tên-hàm-cần-lưu) {...}
    //    public void Invoke() dùng để duyệt qua danh sách các hàm đang lưu trữ để run hàm luôn
    //}

    // xài class đặc biệt này:
    // X            f =         new X(đưa-hàm-nào-đó-vào-đây);
    // Student      biến            value 
    // CHO PHÉP VIẾT NGẮN GỌN CÚ PHÁP KHAI BÁO CLASS LƯU TRỮ TÊN HÀM
    delegate void X(); // tui X đại diện cho 1 loạt các hàm có cùng style void F()

    // MỘT NAMESPACE SẼ CHỨA 3 THẰNG NGANG CƠ NAHU - CÙNG LEVEL
    // 1. CLASS TRUYỀN THỐNG STUDENT, PERSON, DOG, PET,...
    // 2. INTERFACE - DẠNG CLASS ĐẶC BIỆT (CHỨA HÀM ABSTRACT KO CODE)
    // 3. DELEGATE - DẠNG CLASS ĐẶC BIỆT (CHỨA BÊN TRONG TÊN HÀM)
    // CHALLENGE: LÀM VIỆC VỚI CÁC HÀM CÓ STYLE VOID F() - DÙNG STYLE DELEGATE
    public delegate void NoInputNoOutputDelegate(); // đại diện style void F()
    // public class NoInputNoOutputDelegate
    // {
    // }

    // XÀI CLASS TRONG CLASS KHÁC VÌ CLASS LÀ DATA TYPE
    internal class Program
    {
        string _id;
        static void Main(string[] args)
        {
            NoInputNoOutputDelegate f = new NoInputNoOutputDelegate(TellHerMessage);
            //            f là tên gọi khác, nick-name, 2nd name của hàm gốc có tên là TellHerMessage1
            // có thể hình dung: muốn chơi với hàm TellHerMessage1; ta có thể dùng tên thay thế là f1
            // LUẬT SƯ  = THÂN CHỦ
            // HÃY NÓI CHUYỆN VỚI F CŨNG CHÍNH LÀ NÓI CHUYỆN VỚI TellHerMessage1
            // 1 HÀM CÓ 2 TÊN
            // CUỐI GIỜ: BÁN 1 TÊN CHO QUỸ DỮ!!! CHỈ CÒN LẠI 1 TÊN, NHƯNG KO CẦN TÊN GỐC
            NoInputNoOutputDelegate f2 = TellHerMessage2; // new ngầm, làm biếng xài new
            // gọi 2 hàm thử coi
            // thay vì gọi trực tiếp, làm việc trực tiếp với tên gốc của hàm, ta làm việc qua nickname. 2nd name, luật sư 
            // bằng nhau về tên gọi  bằng nhau về run() hàm
            Console.WriteLine("See messages 1st time...");
            f();
            f2.Invoke(); // tương đương nhau, vào trong vùng new để lôi các tên hàm gốc ra và run()
            // luật sư nói là thân chủ nói, nick name run() nghĩa là hàm gốc run()
            f2 = TellHerMessage3; // thay đổi nick name, 2nd name, tên gọi
            f2.Invoke(); // f2()

            Console.WriteLine("See messages 3rd time!");
            f1 += new Program().TellHerMessage3(); // cộng dồn int a = 5; a+= 4 => a = 10
            f1(); // 1 3
            f2(); // 3 
           


        }
        // CHALLENGE: VIẾT HÀM IN RA SỐ TỰ NHIÊN TỪ 1...100
        static void PrintNumbers()
        {
            Console.WriteLine("The list of numbers from 1 to 100");
            for (int i = 1; i <= 100; i++)
            {
                Console.Write($"{i} ");
            }
        }

        static void TellHerMessage()
        {
            Console.WriteLine("1. Cuộc sống em ổn không?");
        }

        static void TellHerMessage2()
        {
            Console.WriteLine("2. Xa anh em phải hạnh phúc");
            // EXPRESSION BODY: HÀM CHỈ CÓ 1 LỆNH; DẸP LUÔN RETURN NẾU CÓ DÙNG => ĐỂ TÁCH TÊN HÀM VÀ THÂN HÀM (BODY OF FUNCTION)
            // NHƯNG HÀM PHẢI VẪN CÒN ĐẦY ĐỦ TÊN HỌ
            // VÌ NÓ RẤT GIỐNG BIỂU THỨC LAMBDA - LAMBDA EXPRESSION, NHƯNG LÀ CÂU CHUYỆN HOÀN TOÀN KHÁC
        }

        static void TellHerMessage3()
        {
            Console.WriteLine("3. Giữa Mai và Đào, anh chỉ được chọn Em");
        }
    }
}
