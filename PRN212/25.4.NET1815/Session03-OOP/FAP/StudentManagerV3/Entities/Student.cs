namespace StudentManagerV3.Entities;

public class Student
{
    public string _name { get; set; }
    public string _id { get; set; }
    public int _yob { get; set; }
    public double _gpa { get; set; }
    
    // NẾU 1 CÁI KHUÔN KO LÀM CÁI PHỄU, THÌ TA VẪN ĐÚC ĐC 1 OBJECT MANG KHÔNG KHÍ BÊN TRONG - MẶC NHIÊN VẪN CÓ ĐC OBJECT KHÔNG KHÍ
    // NẶC NHIÊN CÓ SẴN GỌI LÀ DEFAULT
    // ĐỐI VỚI JAVA C# NẾU BẠN KO LÀM CONSTRUCTOR / PHỄU ĐỂ ĐÚC OBJECT, THÌ JAVA, C# CUNG CẤP SẴN CHO BẠN
    // 1 PHỄU TRỐNG KHÔNG, KO NHẬN ĐẦU VÀO, CŨNG CHẲNG CÓ XỬ LÍ GÁN ĐỒ RA VÔ, CÁI CONSTRUCTOR DEFUALT
    // DẠNG public Student() {}
    // bạn dùng nó để new như bình thường,se4e tạo ra 1 vùng new chứa toàn info default, nhưng vẫn là object
    // y chang ngoài đời, bạn mua 1 căn nhà thô, bạn photo một tờ giấy / form điền - new rô
    // từ từ điền vào sau, từ từ trang trí deco sau.
    // bản chất vẫn là có nhà, có giấy, có formn có object
    public override string ToString() => $"{_id} | {_name} | {_yob} | {_gpa}";

}