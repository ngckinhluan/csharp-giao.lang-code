namespace NullValue
{
    internal class Student
    {
        // C# gợi ý cách viết code phần cơ bản của 1 class cực nhanh gọn, học sau!!!
        // quay lại truyền thống:
        // class gồm: field + hàm / method => members thành viên của 1 class
        // Encapsulation
        private string _id; // con lạc đà và gạch chân từ đầu tiên
        public string _name;
        private string _email;
        private string _phone;
        private int _yob;
        private double _gpa;

        public Student()
        {

        }

        public Student(string id, string name, string email, string phone, int yob, double gpa)
        {
            _id = id;
            _name = name;
            _email = email;
            _phone = phone;
            _yob = yob;
            _gpa = gpa;
        }

        public override string ToString()
        {
            return
                $"{nameof(_id)}: {_id}, {nameof(_name)}: {_name}, {nameof(_email)}: {_email}, {nameof(_phone)}: {_phone}, {nameof(_yob)}: {_yob}, {nameof(_gpa)}: {_gpa}";
        }

        public void ShowProfile()
        {
            Console.WriteLine($"ID: {_id} | NAME: {_name} | YOB: {_yob} | GPA: {_gpa}");
        }
    }

    internal class StudentNull
    {
        // C# gợi ý cách viết code phần cơ bản của 1 class cực nhanh gọn, học sau!!!
        // quay lại truyền thống:
        // class gồm: field + hàm / method => members thành viên của 1 class
        // Encapsulation
        private string _id; // con lạc đà và gạch chân từ đầu tiên
        public string _name;
        private string _email;
        private string _phone;
        private int _yob;
        private double? _gpa;

        public StudentNull()
        {

        }

        public StudentNull(string id, string name, string email, string phone, int yob, double? gpa)
        {
            _id = id;
            _name = name;
            _email = email;
            _phone = phone;
            _yob = yob;
            _gpa = gpa;
        }

        public override string ToString()
        {
            return
                $"{nameof(_id)}: {_id}, {nameof(_name)}: {_name}, {nameof(_email)}: {_email}, {nameof(_phone)}: {_phone}, {nameof(_yob)}: {_yob}, {nameof(_gpa)}: {_gpa}";
        }

        public void ShowProfile()
        {
            Console.WriteLine($"ID: {_id} | NAME: {_name} | YOB: {_yob} | GPA: {_gpa}");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            //CreateStudentObject();
            //PlayWithNulllable();
            //PlayWithNullV1();
            //PlayWithNullV2();
            //PlayWithNullV3();
            PlayWithNullV4();
        }

        static void PlayWithNullV1()
        {
            Student s1;
           /* s1.ShowProfile(); */// bị chửi vì biến đang lưu rác, ko thể gọi hàm được, rác đâu có trỏ đến hàm đến chạy
                                  // Java và C# khai báo biến mà ko gán giá trị, cấm ko đc dùng lệnh ở dưới đó 
                                  // Tệ nhất phải gán null - Trỏ vào đáy ram
            // Byte 0; - Giống như kim đồng hồ xe máy, số tốc độ
                    // Nếu xe ko chạy kim, số nhảy về 0
            Student s2 = null;
            // s2.ShowProfile(); // RUNTIME ERROR!!!
            // Để tránh runtime, ta dùng if, hoặc gán tử tế biến object rồi mới chấm hàm để dùng
            // Tại sao lại có null để phải check: Dính đến kết quả của search có thể thấy và ko thấy object: Ko thấy thì trả về null sv null
            if (s2 is null) // if (s2 is null) if (s2 is not null)
                Console.WriteLine("Please assigning or creating an object first before printing it");
            else 
                s2.ShowProfile();
            // cách viết trên hơi dài 1 tí, nhưng ổn
            Student s3 = null;
            Console.WriteLine("s3 checking...");
            s3?.ShowProfile();
            // Null Condition Operator
            // Là kí hiệu, phép toán, phép so sánh kiểm tra 1 object có null hay ko trước khi hàm gọi nó
            // viết gộp của if và else
            // tránh bị run time error
            Student s4 = new Student("SE4", "BỐN", "asdas@gmail...", "4", 2004, 4);
            Console.WriteLine("s4 checking...");
            s4?.ShowProfile();
        }

        static void PlayWithNullV2()
        {
            Student s1 = null;
            Student s2 = s1; // s2 cũng bằng null luôn
            Student s3 = null;

            Student s4 = s3 ?? new Student("SE4", "BỐN", "asd@gmail", "4", 2004, 4.4);
            s4.ShowProfile();

            // Viết lại thì nó là:
            if (s3 == null)
            {
                s4 = new Student("SE4", "BỐN", "asd@gmail", "4", 2004, 4.4);
            }
            else
            {
                s4 = s3;
            }
            // Kĩ thuật này đảm bảo rằng biến sẽ có giá trị nào đó, đc gán giá trị nào đó | đừng nhầm với biến ? GọiHàm() - Null Condition
            // Kĩ thuật này dùng để gán giá trị default cho 1 biến
            // Khi ngộ nhỡ vế bên phải có thành phần là null
            // thì mình có gái trị dự phòng
            // TOÁN TỬ NÀY ĐƯỢC GỌI LÀ: COALESING - Toán tử kết nối kết hợp
            Student s5 = new Student("SE5", "NĂM", "asd@gmail", "4", 2005, 5.5);
            Student s6 = s5 ?? new Student("SE6", "SÁU", "asd@gmail", "4", 2006, 6.6);
            s6.ShowProfile();
            // 2 Chàng trỏ 1 nàng
        }

        static void PlayWithNullV3()
        {
            int yob = 2004;
            string msg;
            // nếu năm sinh lớn hơn 2000 thì in ra gen Z
            // ngược lại in ra: Outdate
            //if (yob > 2000)
            //{
            //    msg = "Genz";
            //}
            //else
            //{
            //    msg = "Outdate";
            //}

            //Console.WriteLine(msg);
            msg = (yob > 2000) ? "Genz" : "Outdate";
            Console.WriteLine(msg);
            // Toán tử tình tay ba - Conditional Ternary Operator
            // Toán tử 3 ngôi!!!
            // Mệnh đề đúng sai trong phép toán này ko hẳn là check null mà là bất kỳ mệnh đề so sánh nào
            // Chỉ cần đúng sai, ko cần có đúng null ko, có đúng null ko
            // Mình dùng ? Cx oke, hoặc dùng ??
            Student s1 = null;
            //Student s2 = (s1 == null) ? new Student("SE2", "HAI", "dasd@gmail.com", "090..." ,2002, 2.2) : s1;
            Student s2 = (s1 != null) ? s1 : new Student("SE2", "HAI", "dasd@gmail.com", "090...", 2002, 2.2) ;
            s2.ShowProfile();
        }

        //static void PlayWithNullV4()
        //{
        //    Student s1 = null;
        //    Student s2 ?= s1;
        //}

        static void PlayWithNullableV2()
        {
            int a = 0;
            /*int b = null;*/ // bị chửi ngay lúc gõ code vì lí do đây là biến primitive (Java) C# Value type là biến, là vùng ram chỉ lưu giá trị đơn lẻ nào đó
            // Số, Kí tự: int, long, float, double
            // Biến style đon giản này phải gán 1 giá trị hợp lệ, ko cho Null
            int? c = 0; // vẫn int bình thường nhưng 
            c = null    // nhưng có thể mang thêm giá trị null để match với 1 cột null trong DB
            // ? ?? y chang như đã học
            Student s1 = null;
            Student? s2 = null;

            // Với kiểu dữ liệu class / object
            // mặc nhiên là đc dùng null mô tả trạng thái tui chưa trỏ ai
            // tui chưa xác định - dùng kết quả trả vể của search
            // Dùng thêm ? cx chả ảnh hưởng
            // ? đi kèm tên data type đc gọi là: Nullable
            // Em có khả năng chứa giá trị null và áp dụng chung cho
            // cả 2 kiểu primitive và object
        }

        static void PlayWithNulllable()
        {
            Student s3 = new Student("SE1", "AN", "an@gmail.com", "090..." , 2004, 7.9);
            StudentNull s4 = new StudentNull("SE1", "AN", "an@gmail.com", "090...", 2004, null);
            // null tại thời điểm này chỉ áp dụng cho biến object để trỏ vào vùng an toàn
            // trỏ vào vùng an toàn byte thứ 0
            // mang ý nghĩa chưa có sv nào đó cần quan tâm, tìm thấy khi search!!!
            // ko áp dụng cho biến primitive (Java)
            // C# offer 1 cơ chế: biến primitive null luôn để tương thích null trong database, cột điểm gpa trong db là null
            // trong code double gpa = null????
            double? gpa = 9.0;
            gpa = null;
            s3.ShowProfile();
            // Kiểm tra ku s4
            s4.ShowProfile();
          
            // ta có int? double?, long?, float? char? bool?
            // vẫn mang giá trị như truyền thống xưa nay, và còn đc gán thêm NULL
            // STYLE NÀY ĐC GỌI LÀ NULLABLE - EM CÓ THỂ MANG THÊM GIÁ TRỊ NULL
        }

        static void CreateStudentObject()
        {
            // tạo mới hồ sơ sinh viên - tạo mới object từ template / class Student
            // có Khuôn - class ta clone clone
            Student s3 = new Student("SE1", "AN", "an@gmail.com", "0902" ,2004, 7.9); // 79 THẦN TÀI LỚN
            s3.ShowProfile();
            //Student s1;         // XIN RAM MÀ THOY
            //s1.ShowProfile();   // VÙNG RAM CHỨA RÁC - GARBAGE VALUE
                                 // RÁC ON OFF CỦA APP TRƯỚC ĐỂ LẠI
           
            // Khai báo biến trong Java và C# nếu khai báo biến mà ko có gán value thì cấm ko đc xài biến ở các câu lệnh phía dưới
            // Dù biến là int, long, float, double, char hay Student, Lecturer, Pet, Dog,...
            //int currentYear;
            //Console.WriteLine(currentYear); // BỊ CHỬI VÌ BIẾN TRONG RAM ĐANG CHỨA RÁC - IN RÁC THÌ CÓ Ý NGHĨA GÌ??? NHƯNG C IN RÁC LUÔN
            int currentYear = 2024;
            Console.WriteLine($"Current Year: {currentYear}");
            // khai báo biến xong PHẢI GÁN VALUE CHO BIẾN ((CHẤP LOẠI BIẾN NÀO, PRIMITIVE VỚI OBJECT))
            Student s2 = null; // XIN RAM, DỌN DẸP RAM SẠCH SẼ, TRỎ VÀO VÙNG NULL, BYTE ĐẦU TIÊN CỦA RAM, ĐÁY CỦA RAM, TẦNG TRỆT CỦA CĂN HỖ
            //s2.ShowProfile(); // bị chửi lúc run app - run time 
                              // vì trỏ vào vùng new student có data để show()
            //s2 = new Student(""); // ỔN NHEN, VÌ GIỐNG S3
            s2 = s3;  // 2 chàng trỏ 1 nàng
            s3._name = "NGỌC TRINH EM ƠI";
            s2.ShowProfile();

            Student s4 = null;

            s4 = s2; // NGỌC TRINH NHE
            //s4.ShowProfile();
            if (s4 != null)
                s4.ShowProfile();
            else
                Console.WriteLine("Please creating a student object before printing the profile");
            Console.WriteLine("NGỌC TRINH CUỐI GIỜ");
            if (s4 != null)
                s4.ShowProfile();
            else
                Console.WriteLine("Please creating a student object before printing the profile");

        }

    }

}

// BIẾN OBJECT KHI KHAI BÁO Student s; thì có quyền gán bằng những giá trị sau
// = New 1 vùng object (Gọi constructor)
// = 1 Biến object khác đã new trước đó s2 = s3
// = null trỏ đáy ram
// dùng: SEARCH 1 OBJECT VÀ KO TÌM THẤY THÌ TRẢ VỀ NULL
// = null trỏ đáy ram

// MỘT NAMESPACE CÓ THỂ CHỨA NHIỀU CLASS 
// CÁC CLASS NÀY CÓ THỂ NẰM RIÊNG BIỆT TRÊN MỖI TẬP TIN HOẶC NÓI CÁCH KHÁC MỖI TẬP TIN ỨNG VỚI 1 CLASS CODE NHƯNG TRONG 1 TẬP TIN VẪN CÓ THỂ CÓ THỂ CÓ NHIỀU CLASS; NHƯNG XÀI CHUNG 1 TẬP TIN VÀ 1 TÊN GÌ ĐÓ .CS

// LÀM LẺ TỨC LÀ MỖI TẬP TIN 1 CLASS -> THƯ MỤC NAMESPACE HOÀNH TRÁNG
// NHƯNG CLASS NÀO RA CLASS ĐẤY VÌ CHÚNG CÓ TÊN RIÊNG
// LÀM GỘP: 1 TẬP TIN VẬT LÍ CÓ THỂ GỒM NHIỀU CODE CLASS BÊN TRONG -> THƯ MỤC NAMESPACE GỌN GÀNG NHƯNG KO BIẾT CHÍNH XÁC CÓ BAO NHIÊU CLASS VÌ CÁC CLASS XÀI CHUNG 1 TẬP TIN

// THƯỜNG KO CÓ GÌ ĐẶC BIỆT THÌ MỖI CLASS 1 TẬP TIN VÀ SHARE CHUNG THƯ MỤC CHỨA CODE - SHARE DÙNG CHUNG NAMEPSACE
