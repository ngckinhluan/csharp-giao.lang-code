namespace StudentManagerV6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        static void PlayWithGetSet()
        {
            // biến là 1 vùng ram được đặt tên chứa giá trị nào đó, khi chới với biến là ta chơi với vùng ram, chơi với giá trị, chơi thông qua tên biến
            // chơi với vùng ram / với biến ta làm được 2 việc sau:
            // - READ VÙNG RAM, READ BIẾN COI NÓ CÓ VALUE GÌ???
            // - WRITE VÀO VÙNG RAM, THAY ĐỔI VALUE CỦA VÙNG RAM, CỦA BIẾN
            int x = 10; // vùng ram, x mang giá trị 10 khởi đầu
            // HÃY IN RA GIÁ TRỊ CỦA BINE61, CỦA VÙNG RAM, READ(), GET()
            // SỜ CHẠM TÊN BIẾN LÀ SỜ CHẠM VALUE
            Console.WriteLine($"x: {x}"); // GetX() đc x

            // SỬA ĐỔI VALUE,SET() SETTING()
            // TÊN BIẾN DẤU BẰNG CHÍNH LÀ SỬA SET() VALUE
            x = 305; // SETX(20) x = 305 cuối tháng cuối tuần  // SET() thay đổi
            Console.WriteLine("x again: " + x); // GetX() đc x


        }
    }
}
