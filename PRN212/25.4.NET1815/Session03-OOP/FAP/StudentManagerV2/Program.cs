using System.Threading.Channels;
using StudentManagerV2.Entities;

namespace StudentManagerV2;

internal class Program
{
    static void Main(string[] args)
    {
        // TẠO OBJECT KHI CÁI KHUÔN CÓ 2 CÁI PHỄU
        Student s1 = new Student("SE1", "AN", 8.6, 2004);
        Console.WriteLine("s1 details: " + s1); // gọi thầm tên em ToString();
        // NẾU BIẾN CỤC BỘ (BIẾN KHAI BÁO TRONG HÁM) MÀ KO GÁN GIÁ TRỊ
        // THÌ CẤM SỬ DỤNG Ở CÁC LỆNH TIẾP ĐÓ
        // NẾU FIELD CỦA OBJECT MÀ KO ĐC GÁN VALUE LÚC ĐÚC, LÚC NEW
        // THÌ SẼ MANG GIÁ TRỊ DEFAULT
        // SỐ = 0; CHỮ = RỖNG, BOOL THÌ LÀ FALSE
        // ĐỂ ĐẢM BẢO CÁC HÀM BÊN TRONG OBJECT VẪN SỬ DỤNG BIẾN ĐC BÌNH THƯỜNG VÌ ĐÃ CÓ VALUE, DÙ LÀ VALUE DEFAULT
        // ĐỂ SỬA ĐƯỢC NGỮNG VALUE DEFAULT NÀY THÌ TA ĐỔ VALUE MỚI CHO NÓ TỨC LÀ GỌI HÀM SETTER (ĐƯA VÀO DATA MỚI ĐÈ DATA CŨ)
        Student s2 = new Student("SE1", "BINH");
        Console.WriteLine("s2 details: " + s2);
        s2.SetYob(2004);
        s2.SetYob(2005);
        s2.SetYob(2006);
        s2.SetYob(2007);
        s2.SetYob(2008);
        s2.SetYob(2009);
        Console.WriteLine("s2 after setting yob: " + s2); // gọi thầm tên em
        
        // một vùng new SE2 BÌNH CÓ THỂ ĐC SƯA INFO THOẢI MÁI SỐ LẦN
        // NGHĨA LÀ HÀM SET() CÓ QUYỀN GỌI NHIỀU LẦN VÀ VẪN LÀ OBJECT ĐÓ, VẪN VÙNG NEW ĐÓ
        // NHƯNG
        s2 = new Student("SE2", "HAI HAI");
        Console.WriteLine("se2 again after new: " + s2);
        
        // KHI DÙNG NEW LÀ LẬP TỨC CÓ VÙNG RAM MỚI
        // NEW LÀ GỌI PHỄU ĐỂ ĐÚC RA OBJECT MỚI
        // .SET() CÓ THỂ GỌI N LẦN ỨNG VỚI VIỆC MÌNH THAY ĐỔI BACKGROUND THÌ THÀNH HÌNH BẠN TRAI / BẠN GÁI MỚI
        // THAY ĐỔI BACKGROUND BAO LẦN THÌ VẪN LÀ CAÁI ĐIỆN THOẠI CŨ / OBJECT
        // SET() THAY ĐỔI TRÊN OBJECT
        // NEW TẠO MỚI OBJECT HOÀN TOÀN
        

    }
}