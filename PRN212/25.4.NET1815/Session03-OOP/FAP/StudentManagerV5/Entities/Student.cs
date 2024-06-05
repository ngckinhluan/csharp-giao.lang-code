namespace StudentManagerV5.Entities;

public class Student
{
    private string _id;
    private string _name;
    private int _yob;
    private double _gpa;

    // ctor tab sinh ra constructor rỗng 1 cách chủ động
    public Student()
    {

    }

    public Student(string id, string name)
    {
        _id = id;
        _name = name;
    }

    //Create constructor with full fields
    public Student(string id, string name, int yob, double gpa)
    {
        _id = id;
        _name = name;
        _yob = yob;
        _gpa = gpa;
    }

    // constructor còn lại có tham số dùng ctrl.
    // n cách để đúc 1 object!!!!
    // hoàn thiện 1 object ta dùng hàm Set()

    // CÔNG THỨC ĐỂ LẬP TRÌNH OOP - OBJECT ORIENTED PRADIGM / PROGRAMMING LẬP TRÌNH DỰA TRÊN VIỆC LÀM VIỆC VỚI CÁC OBJECT
    // OBJECT LÀ GÌ??
    // LÀ NHỮNG THỨ CỤ THỂ QUANH TA MÀ MÔ TẢ BẰNG NHỮNG CÂU TỪ DÀI
    // MÔ TẢ QUA 2 THỨ, 2 GÓC NHÌN
    // 1. GÓC NHÌN TING4 - STATE - VỀ ĐẶC ĐIỂM
    // ID, NAME, YOB, GPA, SALARY, WORKING HOURS,...
    // 2. GÓC NHÌN ĐỘNG - BEHAVIOURS - METHOD - FUCNTION
    // TÍNH LƯƠNG(), TÍNH SỐ NGÀY NGHỈ CÒN LẠI() TÍNH TUỔI() TÍNH BILL()
    // ==>> CÔNG THỨC LẬP TRÌNH OOP
    // 1. NHẬN DIỆN XUNG QUANH BÀI TOÁN CÁC OBJECT (ĐẶC ĐIỂM VÀ HÀNH VI)
    // 2. PHÂN LOẠI, GOM NHÓM, CHIA NHÓM, ĐẶT TÊN NHÓM THEO NHỮNG OBJECT MÀ CÓ NHIỀU ĐIỂM TƯƠNG ĐỒNG (CLASSIFY - CHIA NHÓM THÀNH CÁC NHÓM - CLASS)
    // NHÓM CLASS STUDENT, LECTURER, EMPLOYEE, CUSTOMER, PRODUCT, ORDER, BILL, INVOICE,..
    // TẠO CLASS (ĐẠI DIỆN CHO 1 ĐÁM OBJECT...)
    // ĐẶC ĐIỂM ID: _________-
    //          NAME: ______
    //          YOB: ______ 
    // CLASS NHƯ 1 TEMPLATE, FORM, BIỂU MẪU, BLUE-PRINT, KHUÔN DÙNG ĐỂ ĐÚC RA, CLONE RA, COPY RA, NHÂN BẢN RA CÁC OBJECT
    // 3. MỖI FORM, BIỂU MẪU, KHUÔN CẦN ĐC LÔI RA, CLONE, ĐỔ MỰC, VẬT LIỆU, ĐIỀN INFO LÊN ĐỂ THÀNH OBJECT, CÁI HÀNH Đ0NG NÀY CHÍNH LÀ ỨNG VỚI HÀM CONSTRUCTOR
    // TA TẠO CONSTRUCTOR ĐỔ INFO VÀO OBJECT
    // 4. KHI TA ĐIỀN XONG CÁI FORM, BÀI THI TRẮC NGHIỆM, CẦM LÊN, TA DÒM NÓ, TA THẤY CÓ ĐÁP ÁN KO ỔN, TA GÔM / TẨY SỬA, SỬA -> SET() SETTING() SETTER()
    // 5. KHI TA TẠO XONG ACCOUNT TRÊN MXH, TA SẼ SHOW PROFILE(), SHOW HẾT INFO CÓ THỂ, KHI XUẤT XƯỞNG CON ĐIỆN THOAI, ĐỂ KÈM CÁI HƯỚNG DẪN SỬ DỤNG, THÔNG TIN CẤU HÌNH VÀO TRONG CÁI HỘP
    // KHOE INFO CẢU 1 OBJECT -> SHOW PROFILE() TOSTRING()
    // VẬY LẬP TRÌNH OOP LÀ TẠO CLASS, LẬP TRÌNH TRÊN TEMPLATE, FORM, CHUNG CHUNG NHẤT 
    // Y CHANG GIẢI PHƯƠNG TRÌNH BẬC 2 TRÊN A B C SAU NÀU ĐƯA INFO CỤ THỂ
    // TỪ OBJECT RA ĐC CLASS -> TỪ CLASS TRỞ LẠI OBJECT CÙNG NHÓM -> KĨ THUẬT QUẢN LÍ INFO QUA OOP
    // 6. CLONE OBJECT TỪ KHUÔN, NEW OBJECT, NEW CÁI FORM, NEW BỨC TƯỢNG TỪ KHUÔN TOÁN TỬ NEW GIOGN61 PHOTOCOPY 1 CÁI FORM, ĐIỀN INFO VÀO RIÊNG CỦA MÌNH.
    public string GetName()
    {
        return _name;
    }

    public string GetId()
    {
        return _id;
    }
    public void SetId(string id)
    {
        _id = id;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public int GetYob()
    {
        return _yob;
    }

    public void SetYob(int yob)
    {
        _yob = yob;
    }

    public double GetGpa()
    {
        return _gpa;
    }

    public void SetGpa(double gpa)
    {
        _gpa = gpa;
    }
    

    //// Print all info but informat |id |name|yob|gpa|
    //public void ShowProfile()
    //{
    //    Console.WriteLine($"ID: {_id}");
    //    Console.WriteLine($"Name: {_name}");
    //    Console.WriteLine($"Yob: {_yob}");
    //    Console.WriteLine($"Gpa: {_gpa}");
    //}

    // Create toString() method
    public override string ToString()
    {
        return $"ID: {_id} | Name: {_name} | Yob: {_yob} | Gpa: {_gpa}";
    }

    
    public void ShowProfile()
    {
        Console.WriteLine(ToString());
    }


   


}