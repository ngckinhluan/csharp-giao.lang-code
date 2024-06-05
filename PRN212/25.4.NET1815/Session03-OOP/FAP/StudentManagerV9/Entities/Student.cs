using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV9.Entities
{
    internal class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Yob { get; set; }
        public double Gpa { get; set; }

        // RUNTIME TỰ SINH RA GIÚP TA _id, _name, _yob, _gpa lúc chạy app giúp dân dev viết code tiện hơn, tránh những code nhàm chán
        // lỡ quên cú pháp prop tab
        // JAVA KO CÓ TRÒ NÀY, MÚN LÀM TRÒ NÀY PHẢI CÀI THÊM DEPENDENCY BÊN NGOÀI THƯ VIỆN NGOÀI - THƯ VIỆN LOMBOK
    }
}
// CHỐT HẠ: CÁCH THIẾT KẾ 1 CLASS LƯU TRỮ INFO CÁC OBJECT
// CÁCH 1: KHAI BÁO CÁC _BACKING FIELD NHƯ BÊN JAVA (_)
//         SAU ĐÓ LÀM CÁC HÀM GET() SET() NHƯ JAVA
// CÁCH 2: KHAI BÁO CÁC _BACKING FIELD NHƯ BÊN JAVA (_)
//         SAU ĐÓ DÙNG CÁI HÀM GET() / SET() THEO STYLE VIẾT GỘP
//         VÀ XỬ LÍ TRÊN _BACKING FIELD, DÙNG THÊM => NẾU CẦN
//         public string Name {get => _name; set => _name = value; }
//         * QUÊN CÚ PHÁP THÌ GÕ, THÌ GÕ propfull tab
//         * CÁCH NÀY ĐC GỌI LÀ FULL PROPERTY (hàm + _backing field)
// CÁCH 3: KHAI BÁO HÀM GET SET() THEO STYLE NGẮN GỌN, KO THÈM XÀI _BACKING FIELD, RUN TIME TỰ CHẾ RA BACKING FIELD
// public string Name { get; set; }
// * quên cú pháp, thì gõ PROP TAB TAB
// * CÁCH NÀY ĐC GỌI LÀ AUTO-IMPLEMENTED PROPERTY
// (run time tự sinh ra backing field cho ta)
// CÁCH 4: KHAI BÁO _BACKING FIELD NHƯ BÌNH THƯỜNG (GIỐNG JAVA)
//         CHỦ ĐỘNG VIẾT RIÊNG CÁC HÀM GET() SET() TRUYỀN THỐNG 
//         HOẶC KO CÓ HÀM GET() SET() NHƯNG CÓ CÁC HÀM KHÁC
//         XỬ LÍ _BACKING FIELD
