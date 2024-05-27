using System.Runtime.Intrinsics.Arm;
using StudentManagerV1.Entities;

namespace StudentManagerV1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TẠO MỚI HỒ SƠ SINH VIÊN 1 BẠN CỤ THỂ NÀO ĐÓ
            Student s1 = new Student("SE1", "AN", 2004, 8.6);
            //      biến        object, con nguười
            //      tên gọi     đc gọi tắt là s1 và hắn là Student
            s1.ShowProfile();
            string msg = s1.ToString();
            string msg2 = $"s1 details: {msg}";
            Console.WriteLine(msg2);
            Console.WriteLine("s1 details: " + s1.ToString());
            Console.WriteLine("s1 details: " + s1); // gọi thầm tên em ToString() y chang bên Java

            // NẾU GHÉP TÊN BIẾN VÀO CHUỖI THÌ BIẾN OBJECT TỰ ĐỘNG GỌI HAM TOSTRING() ĐỂ LẤY CHUỖI RA BÊN TRONG OBJECT ĐEM ĐI GHÉP
            // ĐIỀU GÌ XẢY RA NẾU TA KO LÀM HÀM TOSTRING()

            // CÁCH TẠO OBJECT SỐ 2
            Student
                s2 = new("SE2", "BINH", 2004,
                    8.7); // SAU NEW KHÔNG CẦN TÊN CLASS VẪN GIỮ ĐƯỢC Ý NGHĨA GỐC DO KHAI BÁO LÀ STUDENT RỒI
            s2.ShowProfile();
            Console.WriteLine(s2); // GỌI THẦM TO STRING

            // CÁCH TẠO OBJECT SỐ 3
            var s3 = new Student("SE3", "CUƯỜNG", 2004, 8.8);
            s3.ShowProfile(); // type inference

            // CÁCH TẠO OBJECT SO 4
            var s4 = s3; // 2 chàng trỏ 1 nàng

            // KO CÓ TỪ KHÓA NEW, TỨC LÀ KO CÓ VÙNG RAM ĐƯỢC CẤP
            Console.WriteLine("s4 check var!!!");
            s4.ShowProfile();
            s4.SetGpa(999);
            Console.WriteLine("s3 check var after s4 modification");
            s3.ShowProfile();

            // lưu ý: nếu bạn có 1 hàm nhận vào object 
            // void F(Student x)
            // {
            // }
            // gọi hàm: F(s4) ~~~~~~~~~~~~~~~~ x = s4 trong hàm
            // trong thân hàm x làm gì, thì
            // do đó hàm nhận vào biến object chính là đã truyền tham chiếu luôn rồi!!! do trong hàm
            // và ngoài hàm cùng trỏ 1 vùng ram new bự chà bá.
        }
    }
}