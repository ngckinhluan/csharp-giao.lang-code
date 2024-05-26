namespace IntegersRef
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 6868;
            ChangeX(ref x);
            Console.WriteLine(x);
        }

        static void ChangeX(ref int p)
        {
            p = 6789;
        }
    }
}

// IN OUT REF: 3 thằng ku này dính đến tham số đầu vào
// out và ref giống nhau 99%
// trong hàm thay đổi thì bên ngoài đổi theo - truyền tham chiếu - pass by reference
// OUT: Hứa chắc kèo, chắc chắn có 1 giá trị trả về trong hàm
// REF: Tao ko hứa, có thể hứa, có thể không
//      Xài REF bắt buộc phải gán value cho biến trước
//      Phòng hờ ref ko làm gì
//      Sau gọi hàm vẫn có value!!!
// Nha sĩ khuyên dùng - Chốt hạ:
// Dùng out tiện lợi hơn, tự nhiên hơn do luôn hứa trả về giá trị, ko cần gán giá trị lần đầu
// Hàm luôn phải trả value thì mới hợp logic
// Class
// Generic <>
// Đi vào Delegate -> Anonymous Method -> Lambda Expression -> Linq -> EF Core DB
// Đi vào PE
