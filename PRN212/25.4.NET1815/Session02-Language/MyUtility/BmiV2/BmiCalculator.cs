using System.Threading.Channels;

namespace BmiV2
{
    /// <summary>
    /// Class này sẽ chứa các hàm tính toán liên quan đến chỉ số BMI, là chỉ số dựa trên chiều cao và cân nặng giúp đánh giá ai đó có mập ôm hay không?
    /// </summary>
    public class BmiCalculator
    {
        // khai báo biến và hàm => gọi chung là member của 1 class
        // biến: gọi là: field, property, attribute, instance variable (non-static), class-variable (static)
        // Math.sqrt() Math.Sqrt()

        // Tên hàm trong Java: Verb + Object, chữ hoa từng đầu từ, từ đầu tiên viết chữ thường, gọi là cú pháp con lạc đà
        // camel Case Notation, ví dụ: sqrt() toStirng() getGpa()
        // Tên hàm trong C#: Verb + Object, chữ hoa từng đầu từ kể cả từ đầu tiên, gọi là cú pháp Pascal, Pascal Case Notation, ví dụ: Sqrt(), ToString(), GetGpa()

        /// <summary>
        /// Hàm này tính chỉ số BMI của 1 cá nhân bất kỳ và trả về con số đó.Phép tính BMI dựa trên chiều cao, cân nặng
        /// 
        /// </summary>
        /// <param name = "weight" > Cân nặng đo bằng kg</param>
        /// <param name = "height" > Chiều cao đo bằng m</param>
        /// <returns>Chỉ số BMI của 1 người</returns>
        public static double GetBmi(double weight, double height) => weight / (height * height);
        // NẾU HÀM CHỈ CÓ 1 CÂU LỆNH DUY NHẤT, CHO PHÉP ĂN BỚT RÚT GỌN CODE
        // BỎ LUÔN { BỎ LUÔN RETURN BỎ LUÔN }
        // KĨ THUẬT VIẾT THÂN HÀM {...} THEO STYLE RÚT GỌN ĐC GỌI LÀ EXPRESSION BODY - THÂN HÀM NHƯ MỘT BIỂU THỨC
        // CẤM KO ĐC NHẦM LẪN VỚI BIỂU THỨC LAMBDA CX XÀI CHUNG => HỌC SAU

        //static double GetBmi(double weight, double height) 
        //    => weight / (height * height);


        //static double GetBmi(double weight, double height)
        //{
        //    // quy tắc đặt tên biến - biến local
        //    // cú pháp con Lạc Đà, Noun
        //    return weight / (height * height);
        //}
        // VIẾT THỬ NGHIỆM THÊM 1 CÁI HÀM KHÁC, HÀM VOID, STYLE EXPRESSION BODY
        //static void PrintBmi()
        //{
        //    Console.WriteLine("BMI stands for Body Mass Index - chỉ số khối của cơ thể - con số được tính dựa trên chiều cao và cân nặng");
        //}
        public static void PrintBmi() => Console.WriteLine(
                "BMI stands for Body Mass Index - chỉ số khối của cơ thể - con số được tính dựa trên chiều cao và cân nặng");
    }
}
