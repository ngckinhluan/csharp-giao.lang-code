using StudentManagerV7.Entities;

namespace StudentManagerV7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // tạo mới 1 sinh viên
            Student s1 = new Student();
            Console.WriteLine("s1 (default)");
            s1.ShowProfile();
            s1.Name = "AN"; 
            s1.Id = "SE1";
            s1.Yob = 2004;
            s1.Gpa = 8.6;
            Console.WriteLine("s1 after setting");
            s1.ShowProfile();

            // VIẾT TỰ NHIỆN HƠN SO VỚI s1.SetName("AN");
            // Id, Name, Yob, Gpa là các thuộc tính của object
            // CÒN _id, _name, _yob, _gpa là các biến dùng để lưu trữ thông tin của object
            // ĐỨA ĐỨNG ĐẰNG SAU, CHỐNG LƯNG CHO PROPERTY, CHO HÀM GET SET
        }
    }
}
