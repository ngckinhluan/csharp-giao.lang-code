using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV1.Entities
{
    internal class Student
    {
        private string _id;
        private string _name;
        private int _yob;
        private double _gpa;
    }
    
    // OBJECT - ĐỐI TƯỢNG: LÀ 1 THỨ QUANH TA, DÙNG NHIỀU LỜI ĐỂ MÔ TẢ VỀ NÓ: CÂY BÚT GỒM CÓ GIÁ TIỀN, HÃNG SX, MÀU SẮC,...
    // ĐỐI TƯỢNG ĐC MÔ TẢ QUA ĐẶC ĐIỂM VÀ HÀNH VI - HÀNH ĐỘNG
    // BÉ CƯNG NHÀ MÌNH CÓ: TÊN, NĂM SINH, ĐÃ CHÍCH VẮC XIN, HÀNH ĐỘNG: DỤI MÁ VÀO TAY, CÀO GHẾ NỆM...
    // CÁC ĐỐI TƯỢNG ĐỀU ĐC CHO 1 CÁI TÊN GỌI:
    // CÁI BÚT CỦA TUI, BÉ CƯNG NHÀ BẠN, TUI, BẠN, KU TÈO, KU TÍ, SẾP, THẰNG KIA, CHI PU,..
    // DANH TỪ RIÊNG: TÊN GỌI CHO 1 ĐỐI TƯỢNG CỤ THỂ NÀO ĐÓ
    
    // CÁC ĐỐI TƯỢNG QUANH TA ĐC CHIA THÀNH CÁC NHÓM DỰA THEO ĐẶC ĐIỂM CHUNG, ĐIỂM TƯƠNG ĐỒNG, TA GOM CHÚNG THÀNH 1 CÁI NHÓM,
    // ĐẶT CHO CHÚNG 1 CÁI TÊN - CLASS XUẤT HIỆN
    // CLASS LÀ TÊN GỌI CHUNG, DANH TỪ CHUNG CHO 1 NHÓM ĐỐI TƯỢNG TƯƠNG ĐỒNG
    // class Student đại diện cho 1 nhóm bạn an, binh, cuong, dung
    // CLASS NHƯ CÁI KHUÔN DÙNG ĐỂ ĐÚC RA CÁC ĐỐI TƯỢNG
    // Student có an, binh, cuong, dung, em, giang, huong, khanh, minh,...
    
    // TỪ ĐỐI TƯỢNG -> TÌM RA CLASS NHÓM ĐỐI TƯƠNG
    // TỪ CLASS -> CLONE RA OBJECT MỚI
    // GIÚP TA QUẢN LÍ MỌI OBJECT, MỌI INFO QUANH TA
}
