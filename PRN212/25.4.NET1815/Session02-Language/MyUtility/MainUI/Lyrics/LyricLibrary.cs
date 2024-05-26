using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// namepsace - package bên Java là 1 thư mục trên HDD/SSD dùng để lưu trữ các class / source code
// nếu thư mục cha có thư mục con có thư mục cháu thì chạm đến class thư mục cháu Cha.Con.Cháu. cái      class mình muốn dùng y chang bên Java.
// muốn xài class thì phải chỉ ra đường đi bên Java là : import java.util.scanner;
// C#: using Cha.Con.Cháu;
// mục đích của việc tạo ra namespace/package: hộp chứa class giúp phân loại, quản lí source code, quản lí các class theo các mục đích khác nhau: nhóm class Controller, nhóm class Dao, nhóm class Dto...
// nhờ chia class vào trong các thư mục cho nên 2 thư mục khác nhau có quyền chứa 2 class trùng tên
// Nhà Minh. thằng Tèo
// Nhà Hàng xóm. thằng Tèo
// giải quyết vấn đề đụng độ tên gọi: clash of naming!!!
namespace MainUI.Lyrics
{
    internal class LyricLibrary
    {
        public static void PrintChungTaCuaTuongLai()
        {
            Console.WriteLine(@"Liệu mai sau phai vội mau không bước bên cạnh nhau (bên cạnh nhau)
Thì ta có đau? (Thì ta có đau? Có đau?)
Đôi mi nhòe phai ai sẽ lau?
Ai sẽ đến lau nỗi đau này?
Vô tâm quay lưng ta thờ ơ, lạnh lùng băng giá như vậy sao? (Vậy sao? Vậy sao?)
Vờ không biết nhau (không biết nhau, không biết nhau)
Lặng im băng qua chẳng nói một lời (chẳng nói một lời)
Ooh-whoa-ooh-whoa-oh-oh-oh (yeah, eh)");
        }
    }
}
