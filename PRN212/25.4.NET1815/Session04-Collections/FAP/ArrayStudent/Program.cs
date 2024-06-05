using ArrayStudent.Entities;

namespace ArrayStudent
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //CreateStudent.Invoke();
            PlayWithStudentList.Invoke();
        }
        // CHALLENGE #2: HÃY LƯU HỒ SƠ THÔNG TIN, HỒ SƠ CỦA 30 BẠN SINH VIÊN TRONG PHÒNG NÀY
        static Action CreateStudent = () =>
        {
            Student s1 = new Student(); // default constructor
                                        // defualt _backing field
            s1.Id = "SE1";
            s1.Name = "AN";
            s1.ShowProfile();
            Student s2 = new Student() { Id = "SE2", Name = "BÌNH" };
            // Object initializer
            s2.ShowProfile();
        };

        private static Action PlayWithStudentList = () =>
        {
            // CHƠI NGOO
            //Student s1, s2, s3, s4, s5,...
            Student[] arrs = new Student[30];
            // 30 ô nhớ              s1, s2, s3, s4, s5,... ,s30
            // arr là má mì có 30 biến
            // arr.Length = 30
            // arr[0]. có xổ gì ko?
            // arr[0] arr[1]... chính là từng biến sv lẻ, nay về ở chung vùng ram bị biến mảng arr má mì quản lí
            // lợi gì: for nhanh tất cả các biến
            // ko chơi mảng, thì phải gọi tên từng biến sv lẻ, nay về ở chung vùng ram bị biến mảng arr má mì quản lí
            // giờ chỉ là arr[i]. for i thoải mái luôn
            arrs[0] = new Student() { Id = "SE1", Name = "AN" };
            arrs[1] = new Student() { Id = "SE2", Name = "BÌNH" };
            Student s2 = new() { Id = "SE3", Name = "CƯỜNG" };
            arrs[2] = arrs[0];
            arrs[2].ShowProfile(); // AN FOR SURE
            // BTVN: LƯU GIÙM TÔI THÊM 5 - 10 SV VỚI ĐIỂM LỘN XỘN THỨ TỰ
            // IN RA DANH SÁCH SINH VIÊN
            // SẮP XẾP DANH SÁCH SINH VIÊN THEO ĐIỂM TĂNG DẦN
            // VÀ IN RA MÀN HÌNH
            arrs[3] = new Student() { Id = "SE4", Name = "John Doe", Yob = 2004, Gpa = 3.5 };
            arrs[4] = new Student() { Id = "SE5", Name = "Jane Smith", Yob = 2004, Gpa = 3.7 };
            arrs[5] = new Student() { Id = "SE6", Name = "Alice Johnson", Yob = 2002, Gpa = 3.9 };
            arrs[6] = new Student() { Id = "SE4", Name = "Bob Brown", Yob = 2004, Gpa = 3.2 };
            arrs[7] = new Student() { Id = "SE5", Name = "Charlie Davis", Yob = 2004, Gpa = 3.4 };
            arrs[8] = new Student() { Id = "SE9", Name = "George Harris", Yob = 2000, Gpa = 3.7 };
            arrs[9] = new Student() { Id = "SE10", Name = "Hannah Scott", Yob = 2003, Gpa = 3.5 };
            Console.WriteLine("All students");
            for (int i = 0; i < arrs.Length; i++)
            {
                if (arrs[i] != null)
                {
                    arrs[i].ShowProfile();
                }
            }
            Console.WriteLine();
            // Method-based syntax
            IEnumerable<Student> query = arrs.Where(s => s != null).OrderBy(s => s.Gpa);
            Console.WriteLine("All students sorted by GPA in acsending order");
            foreach (var student in query)
            {
                student.ShowProfile();
            }

            Console.WriteLine("All students sorted by GPA in descending order");
            // Method-based syntax
            IEnumerable<Student> query2 = arrs.Where(s => s != null).OrderByDescending(s => s.Gpa);
            foreach (var student in query2)
            {
                student.ShowProfile();
            }

            // Query syntax descending
            IEnumerable<Student> queryStudentDescending = from student in arrs
                                                          where student != null
                                                          orderby student.Gpa descending
                                                          select student;
            Console.WriteLine("Print student descending by GPA using query syntax");
            foreach (var student in queryStudentDescending)
            {
                student.ShowProfile();
            }

            // Query syntax ascending
            IEnumerable<Student> queryStudentAcsending = from student in arrs
                                                         where student != null
                                                         orderby student.Gpa ascending
                                                         select student;
            var resultStudentV2 = queryStudentAcsending.ToList();
            Console.WriteLine("Print student acsending by GPA using query syntax");
            resultStudentV2.ForEach(s => s.ShowProfile());

            var resultStudent = (from student in arrs
                                where student != null
                                orderby student.Name ascending
                                select student).ToList(); // ToList() because we want to use ForEach
            resultStudent.ForEach(s => s.ShowProfile());

        };
    }
}
