using MainUI.Lyrics;
using System.Text.Encodings.Web;

namespace MainUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //GetAge();
            //PrintLyricOrPoem();
            //UseVerbatim();
            LyricLibrary.PrintChungTaCuaTuongLai();
          
        }

        // verbatim string dùng để làm gì???
        // 1 trong những ứng dụng là dùng để gán đường dẫn tập tin trong Windows làm cho đường dẫn tự nhiên như lúc xài Windows 
        // verbatim còn hay dùng trong chuỗi kết nối CSDL khi tên server có dấu // \\

        static void UseVerbatim()
        {
            //string filePath = "C:\\news";
            string filePath = @"C:\news"; //verbatim để dùng in chuỗi nguyên bản tự nhiên như nó vẫn là \n là \n chứ ko phải xuống hàng
            // kết hợp đc vs interpolation
            Console.WriteLine(filePath);
            Console.WriteLine(@$"Your path: {filePath} \n\n");
        }
        
        // OOP: static chơi với static
        static void PrintLyricOrPoem()
        {
            //Console.WriteLine("Từ ấy trong tôi bừng nắng hạ");
            //Console.WriteLine("Mặt trời chân lí chói qua tim");
            //Console.WriteLine("Hồn tôi là một vườn hoa lá");
            //Console.WriteLine("Rất rộn hương và rộn tiếng chim");
            // Ctrl K C: comment, Ctr K U un-comment, mở ghi chú ra của 1 đám lệnh
            // Java: Ctrl /

            //Console.WriteLine("Từ ấy trong tôi bừng nắng hạ\n" +
            //                  "Mặt trời chân lí chói qua tim\n" +
            //                  "Hồn tôi là một vườn hoa lá\n" +
            //                  "Rất rộn hương và rộn tiếng chim");

            Console.WriteLine(@"
Từ ấy trong tôi bừng nắng hạ
Mặt trời chân lí chói qua tim
Hồn tôi là một vườn hoa lá
Rất rộn hương và rộn tiếng chim

Liệu mai sau phai vội mau không bước bên cạnh nhau (bên cạnh nhau)
Thì ta có đau? (Thì ta có đau? Có đau?)
Đôi mi nhòe phai ai sẽ lau?
Ai sẽ đến lau nỗi đau này?
Vô tâm quay lưng ta thờ ơ, lạnh lùng băng giá như vậy sao? (Vậy sao? Vậy sao?)
Vờ không biết nhau (không biết nhau, không biết nhau)
Lặng im băng qua chẳng nói một lời (chẳng nói một lời)
Ooh-whoa-ooh-whoa-oh-oh-oh (yeah, eh)
Rồi niềm đau có chóng quên? (Hah-ah-ooh-ah)
Hay càng quên càng nhớ thêm, vấn vương vết thương lòng xót xa?
Đừng như con nít (con nít), từng mặn nồng say đắm say (oh-oh-ah)
Cớ sao khi chia tay (chia tay), ta xa lạ đến kì lạ? (Ta xa lạ đến kì lạ)
    <html>
        <body>
            <div>
            </div>
        </body>
    <html/>
        ");
        }   // raw string, chuỗi nguyên bản, có gì in nấy, phế võ công tất cả kí tự đặc biệt, trở lại        thành kí tự bình thường, \n là \n chứ ko phải xuống hàng - VERBATIM (JAVA CÓ LUÔN)
             // DÙNG VERBATIM để làm gì?

        static void GetAge()
        {
            int yob = 2004; // biến local biến khai báo trong hàm theo cú pháp con lạc đà - Camel Case                  Notation, ex: salary, raidus, basicSalary
            int age = 2024 - yob;
            Console.WriteLine("Yob: " + yob + " | Age: " + age); // cw tab giống sout tab
            Console.WriteLine("Yob: {0} | Age: {1}", yob, age); // place holder
            //                                 thứ tự biến tính từ 0
            //                                 danh sách biến sau dấu phẩy
            //                                 %d, yob như bên C 
            Console.WriteLine($"Yob: {yob} | Age: {age}"); // interpolation
            // tự suy luận đâu là biến để điền giá trị của biến vào chuỗi
        }
        
    }
}
