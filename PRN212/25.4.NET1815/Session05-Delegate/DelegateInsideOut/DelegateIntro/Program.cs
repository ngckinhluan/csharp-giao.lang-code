namespace DelegateIntro
{
    // delegate sẽ khai báo ở bên ngoài class khác, và nằm dưới namespace / package
    // Solution có nhiều project
    // Project có nhiều namespace
    // Namespace có nhiều Class

    // tao - delegate là 1 data type cho nhóm object phức tạp là cái đám hàm tao trỏ / quản lí, đại diện, tao bình đẵng với các class / data type khác.
    public delegate void X(); // X tui là class X đại diện cho 1 đám hàm ở dưới hay ở đâu đó có chung style là void ???()
    // CHÍNH LÀ LỆNH KHAI BÁO CLASS VIẾT NGẮN GỌN - VIẾT NGOÀI CLASS KHÁC (NEWBIE)
    // public class X [voidX()] delegate
    // public X(đưa-vào-tên-hàm-cần-cất-trữ)
    // do X đại diện cho 1 đám hàm, hàm đưa đây tao cất trữ đại diện trỏ delegate

    // X f = tên hàm ở dưới nickname cho tên hàm nào đó ở dưới
    // f là tên gọi khác cho cái hàm ở dưới cùng style X
    // int x = value  10;
    // KHAI BÁO BIẾN VÀ SỬ DỤNG THÌ PHẢI Ở TRONG HÀM, HAY TRONG CLASS KHÁC NÀO ĐÓ!!!
    // X SẴN SÀNG LÀ DATA TYPE BÌNH ĐẲNG NHƯ PERSON, DOG, CAT, PET, RECTANGLE
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    // Student s = new Student();
        //    // int yob = 2003;
        //    // X   f1  = Tên hàm cùng style X đã định nghĩa ở trên
        //    //     f1 trỏ đến hàm nào đó cùng style X
        //    //     f1 là nick name, là đại diện nhận ủy quyền, ủy nhiệm từ hàm khác
        //    //     f1 là con trỏ hàm, biến trỏ đến 1 hàm cụ thể
        //    //     f1 và hàm lúc này là 1
        //    //     gọi f1 như gọi hàm
        //    //     dùng f1() và hàm() đều run như nhau
        //    //     run qua biến ủy quyền - run gián tiếp
        //    // vs. run trực tiếp tên hàm như 100 năm nay

        //    X f1 = new X(TellHer); // f1 là 1 đám hàm có style X, trỏ đến hàm TellHer
        //                           // f1 là tên gọi khác cho hàm TellHer
        //                           // f1 và TellHer như nhau, là 1 lúc này
        //                           // f1 cũng là TellHer
        //                           // giống như sếp là NTT, TB, 1994, Chúng ta của tương lai
        //                           // f1 trỏ đến hàm TellHer, f1 là con trỏ hàm
        //                           // f1 đại diện cho TellHer, f1 là delegate ủy quyền
        //    X f2 = NhanEm; // viết tắt luôn bỏ new luôn cho nó tự nhiên như style value
        //                   // để giống như int yob = 2003;
        //                   // int[] arr = new int[3000];
        //                   // int[] arr = {5, 10, 15, 20, 25, 30};
        //                   // Student s = new Student(...);
        //                   // Student s = new (...);
        //                   // HẾT SỨC LƯU Ý, KHI GÁN BIẾN / NICKNAME CHO 1 HÀM CỤ THỂ NÀO ĐÓ
        //                   // TUYỆT ĐỐI KO GHI TÊN HÀM KÈM () DẤU NGOẶC!!! 
        //                   // VÌ GHI () NGHĨA LÀ RUN HÀM LUÔN RỒI
        //                   // TRONG KHI ĐÓ LỆNH X f2 = NhanEm mang ý nghĩa là đặt nickname cho 1 hàm cụ thể nào đó, gán 
        //                   // giá trị cho biến, giá trị hơi đặc biệt tí: giá trị là 1 cái hàm, đưa tên hàm, chứ ko phải
        //                   // run() cái hàm
        //                   // TellHer();
        //                   // NhanEM();
        //                   // GỌI HÀM CHÀO NHAU HOY
        //                   // GỌI TRỰC TIẾP NHƯ 2 LỆNH ĐÃ CMT Ở TRÊN - KO THÈM LÀM, TRUYỀN THỐNG RỒI
        //                   // TA GỌI QUA CON TRỎ HÀM, BIẾN DELEGATE, BIẾN ỦY QUYỀN, BIẾN NICK NAME
        //                   // BIẾN F1 ĐẠI DIỆN CHO HÀM NÀO ĐÓ, GỌI HÀM TRỰC TIẾP HOẶC GỌI QUA ỦY QUYỀN
        //    f1(); // vì câu lệnh X f1 = tellher; do đó Tellher() chạy hàm thì f1() cũng là chạy hàm TellHer();
        //          // gọi hàm gián tiếp, hàm đã đc ủy quyền cho thằng khác chạy thay vì tự chạy
        //          // gọi hàm qua tên nickname ủy quyền
        //    f2();
        //    // CÁCH GỌI THỨ 3: gọi qua hàm Invoke đc tạo sẵn, giống .ToString
        //    Console.WriteLine("Call message by using Invoke() metod inside the X class");
        //    f1.Invoke();
        //    f2.Invoke();
        //}

        // chơi delegate style nhiều hàm được nhồi vào biến thuộc style X
        // 1 LUẬT SƯ ĐẠI DIỆN NHIỀU THÂN CHỦ
        // 1 CON TRỎ TRỎ ĐA HÀM, VẪN 1 VÙNG NEW X()
        // X CÒN ĐÓNG VAI THÙNG CHỨA TÊN HÀM, BOX CHỨA TÊN HÀM, CABINET, CONTAINER
        // HƠN LÀ 1 CLASS CHỨA BÊN TRONG 1 INFO DƠN LẺ KIỂU PERSON, CAT, DOG
        //static void Main(string[] args)
        //{
        //    X f = new X(TellHer); // int x = 10
        //    f += NhanEm;          // x += 5, ghép 10 + 5
        //    f += SayHelloToSweetHeart;
        //    f += HelloWorld;
        //    // f là gã luật sư đại diện cho 3 thân chủ thay vì chỉ 1 - multicast delegates


        //    // GỌI 3 HÀM CÙNG 1 LÚC
        //    // 1. Gọi lẻ truyền thống TellHer(); NhanEm(); SayHelloToSweetHeart();
        //    // 2. Gọi qua delegate f(); duyệt mảng / list các tên hàm đã add() vào và () và run()
        //    // 3. Gọi qua f.Invoke() duyệt mảng...
        //    f();

        //    // int x = 10; x = 11
        //}

        //static void Main(string[] args)
        //{
        //    X f = TellHer; // new X(TellHer); cái đã tạo ko gian đề phòng add nhiều tên hàm
        //    f += NhanEm;
        //    f += SayHelloToSweetHeart;
        //    f += HelloWorld;
        //    f.Invoke();
        //}

        static void Main(string[] args)
        {
            X f = TellHer;
            f = NhanEm;
            f(); // đáp án ra gì??? int a = 10; a = 11; -> a đang là 11
                 // TẠI 1 THỜI ĐIỂM BIẾN CHỈ LƯU 1 VALUE, TÊN GỌI ỨNG VALUE
                 // TỪ BỎ THÂN CHỦ TELLHER KÍ HỢP ĐỒNG VỚI THÂN CHỦ MỚI

        }

        static void TellHer() => Console.WriteLine("Cuộc sống em ổn ko. Xa anh em phải hạnh phúc!!!");

        static void NhanEm() => Console.WriteLine("Chúc em hạnh phúc bên người!!! Chúng ta của tương lai");

        static void SayHelloToSweetHeart() => Console.WriteLine("Bánh mì không? Hai ta về chung một nhà hen? Chúng ta của tương lai!!!");

        // còn nhiều hàm nữa trong tương lai ở đây, mà có thể ở Project khác .DLL khác
        static void HelloWorld() => Console.WriteLine("Hello Delegate!");

        // ...
        // 1 2 3 4 5 6 ... => int, long, float, double

    }
}
