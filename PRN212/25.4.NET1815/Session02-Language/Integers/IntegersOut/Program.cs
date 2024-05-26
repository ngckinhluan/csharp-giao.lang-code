namespace IntegersOut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // xài hàm out ra sao???
            // có 3 cách
            // c1. Khai báo biến và gắn sẵn value, nhưng value sẽ bị đè sửa bở bên trong hàm. 
            int n = 3979;
            string msg = $"Before calling method, n = {n}";
            Console.WriteLine(msg);
            ChangeXv2(out n);
            string msg2 = $"After calling method, n = {n}";
            Console.WriteLine(msg2);

            // c2. Khai báo biến, không thèm gắn value cho biến vì đằng nào hàm out hứa sẽ có value
            int x;
            //string msg3 = $"Before calling method, n = {x}";
            //Console.WriteLine(msg3);
            ChangeXv2(out x);
            string msg4 = $"After calling method, n = {x}";
            Console.WriteLine(msg4);

            // c3: cách này ChatGPT, Copilot hay dùng
            // vừa khai báo biến, vừa truyền out, đằng nào cx đc value từ hàm ném ra!!!
            ChangeXv2(out int xxx);
            Console.WriteLine("After calling out method, xxx = " + xxx);
            
        }

        static void ChangeXv2(out int p)
        {
            // chữ out: hứa trong hàm sẽ có 1 value cho n!!! Phải gán 1 giá trị cho n; ko báo lỗi - giữ lời hứa luôn có value nào đó!!!!!
            p = 6789; // sbtc 2204 mãi mãi ko chết
        }

        // Xài hàm cần có biến đưa vào
        //              int xxx = 20;
        // ChangeXV2(out 20)

        //static void Main(string[] args)
        //{
        //    int x = 10;
        //    ChangeXv1(x); // gọi hàm xem có thay đổi ko
        //    string msg = @$"After calling method x = {x}";
        //    Console.WriteLine(msg);
        //}

        // Viết 1 hàm nhận vào 1 con số (qua biến đầu vào), sau đó hàm thay đổi biến đầu này thành giá trị mới
        // Kĩ thuật truyền thống truyền tham trị, pass by value
        // Copy data từ vị trí gốc sang hàm đc gọi
        // Hàm làm gì ko biết, data gốc ko bị thay đổi
        // Pass by value: Tao cho mày bản copy data, photo ra 1 bản
        static void ChangeXv1(int n)
        {
            Console.WriteLine("In method, n at first: " + n);
            n = 3979;
            Console.WriteLine("In method, n after: " + n);
        }

        
        // Challenge #1: Viêt 1 hàm trả về
        // Tổng các số từ 1...10 (100)
        // Tổng các sổ lẻ từ 1...10
        // Tổng các số chẵn từ 1...10
        // Số lượng các số lẻ từ 1..10
        // Số lượng các số chẵn từ 1..10
        // Số lượng các số nguyên tố
        // ...
        // Chỉ 1 hàm duy nhất!!!
    }
}
