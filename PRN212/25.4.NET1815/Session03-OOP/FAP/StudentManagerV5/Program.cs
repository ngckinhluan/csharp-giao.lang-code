
using StudentManagerV5.Entities;

namespace StudentManagerV5;

class Program
{
    static void Main(string[] args)
    {

        Student s1 = new Student();
        Console.WriteLine("s1 at first (default)");
        Console.WriteLine(s1); // gọi thầm tên em ToString()
        s1.SetName("An");
        s1.SetId("SE1");
        Console.WriteLine("s1 after setting...");
        Console.WriteLine(s1);

        // new đủ
        Student s2 = new("SE2", "Bình", 2004, 8.6);
        Console.WriteLine("s2(full)");
        Console.WriteLine(s2);

        // new đủ nhưng
        var s3 = new Student(name: "Cường", yob: 2005, gpa: 8.6, id: "SE3");
        // kĩ thuật truyền value vào hàm vào constructor nhưng ko theo thứ tự khai báo biến của tên hàm mà đảo thứ tự thỏa mái miễn là ghi chú thêm thên biến đầu vào :
        // giúp bạn truyền tham số theo cách bạn muốn, thứ tự bạn muốn mà ko gây báo lỗi tương thích tham số
        // kĩ thuật này gọi là: Named Argument: Truyền tham số đi kèm tham số
        // Insert into Accout Values (THEO THỨ TỰ CỘT TRONG DB,...)
        // Insert into Account(Email, Phone, Id) Values(...)

        // OBJECT VÔ DANH, ANONYMOUS OBJECT
        //Student s4 = new Student("SE4", "DŨNG", 2004, 8.9);
        // tên biến                object có full info
        // nick name
        // con trỏ      trỏ =       vùng new bự
        // s4. tức là vào vùng new xem có gì, có public gì
        // s4 chính là tay cầm móc vào Con Diều vùng new
        new Student("SE4", "DŨNG", 2004, 8.9).ShowProfile();
        // OBJECT ĐC TẠO RA NHƯNG KO BỊ BIẾN NÀO TRỎ VÀO
        // NHƯ CON DIỀU BAY LÊN RỒI ĐỨT DÂY, KO NÍU KÉO NÓ ĐC ĐỂ ĐIỀU CHỈNH
        // OBJECT MÀ KO ĐC ĐẶT TÊN, GÁN VÀO BIẾN TRỎ THÌ GỌI LÀ OBJECT VÔ DANH
        // ANNONYMOUS OBJECT
        // MÁY ẢO JAVA, .NET RUNTIME ĐỊNH KÌ QUÉT RAM COI CÓ ĐỨA NÀO TRÔI NỔI KO CÓ CON TRỎ MÓC VÀO, THÌ BỊ CLEAR KHỎI RAM
        // ĐOẠN CODE CỦA RUNTIME TRONG RAM DỌN DẸP BỘ NHỚ GỌI LÀ GARBAGE COLLECTOR - BỘ GOM RÁC - CÔNG TY MÔI TRƯỜNG ĐÔ THỊ
        // CÔNG TY GOM RÁC ĐI NHÀ DÂN, NHÀ DÂN ĐỔ RÁC RA NGOÀI, CÔNG TY GOM RÁC ĐI LẤY, ĐỔ VÀO XE, XE ĐI ĐỔ RÁC
        // Random rd = new Random();
        // double n = rd.NextDouble();
        // double n = new Random().NextDouble();
        Student s5 = s2; // SE2 || BINH || 8.6
        PassAStudent(s2);
        Console.WriteLine("s2 after calling method");
        s2.ShowProfile();
    }
    // HÀM KHÁC NGOÀI MAIN() NHƯNG TRONG CLASS
    static void PassAStudent(Student x) // PassX(int x) PassX (out int x) PassX (ref int x)
    {
        x.SetName("THÍCH TỰ DO");
    }
}

// TRUYỀN 1 OBJECT VÀO HÀM CHÍNH LÀ TRUYỀN VÙNG NEW BÊN NGOÀI VÀO HÀM, CHÍNH LÀ TRUYỀN THAM CHIẾU, VÌ TRONG HÀM MÀ SET() GÌ THÌ VÙNG NEW NGOÀI BỊ ẢNH HƯỞNG NGAY, HIỆN TƯỢNG 2 CHÀNG TRÒ 1 NÀNG
// HÀM NHẬN VÀO BIẾN OBJECT CHÍNH LÀ TRUYỀN THAM CHIẾU LUÔN RỒI, TRONG HÀM CÓ THỂ THAY ĐỔI VÙNG NEW BÊN NGOÀI - KO CẦN REF OUT