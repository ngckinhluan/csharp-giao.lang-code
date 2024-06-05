using StudentManagerV4.Entities;

namespace StudentManagerV4;

class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student("SE1", "AN");
        // nếu class ko co constructor thì C# Java sẽ tự sinh ra cho mình 1 constructor rỗng
        // default để giúp ta clone 1 vùng ram chứa object toàn là thông tin default. Giống như xin 1 cái form để dành điền sau
        // nếu đã có 1 constructor có tham so, hoặc nhiều constructor, thì Java, C# ko sinh ra default
        // lí do: cần constructor để đúc object, mà giờ có rồi ko cần sinh ra nưa
        // NHƯNG...
        // EM THIX LÀM CONSTRUCTOR RỖNG 1 CÁCH CHỦ ĐỘNG
        // EXPLICIT - TƯỜNG MINH, RÕ RÀNG
    }
}