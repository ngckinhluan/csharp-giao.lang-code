using StudentManagerV3.Entities;

namespace StudentManagerV3;

public class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student(); // Xài empty, default, constructor - đúng cho Java luôn
        Console.WriteLine("s1 details by using default cst: " + s1);
        
        // muốn sửa info thì chắc chắn phải là đem vật liệu về đổ vào - setter, hàm Set()
        // ĐIỀU GÌ XẢY RA NẾU
        // Class của bạn thiết kế sẵn 1 hay 1 vài constructor có tham số???
        
    }
}