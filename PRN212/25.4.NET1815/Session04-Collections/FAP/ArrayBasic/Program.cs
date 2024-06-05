using System.Threading.Channels;

namespace ArrayBasic
{
    internal class Program
    {
        public delegate void NoInputNoOutput();
        static void Main(string[] args)
        {
            //// Luật sư - Thân chủ
            //NoInputNoOutput f = PlayWithIntegerListV1;
            //f.Invoke(); // Luật sư lên tiếng
            //f = PlayWithIntegerListV2;
            //f.Invoke(); // Luật sư lên tiếng
            //PlayWithDelegateV3();

            //PlayWithIntegerListV1.Invoke();
            //PlayWithIntegerListV2.Invoke();
            //PlayWithIntegerListV3.Invoke();
            PlayWithIntegerListV4.Invoke();
        }

        static Action PlayWithIntegerListV4 = () =>
        {
            int[] arr1 = { -10, -5, 0, 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };
            // in mảng
            Console.WriteLine($"{arr1[0]} {arr1[1]} {arr1[2]} {arr1[3]} {arr1[4]} {arr1[5]} {arr1[6]} {arr1[7]} {arr1[8]} {arr1[9]}");
            // vì các biến lẻ trong mảng dùng chỉ số [0]... để phân biệt: 0, 1, 2, 3, 4,... tăng dần => vòng lặp xuất hiện, mảng chơi với lặp
            Console.WriteLine("The list of 5 10... (printed by using for i)");
            for (global::System.Int32 i = 0; i < arr1.Length; i++)
                Console.Write($"{arr1[i]} ");
            // sống có trách nhiệm, xuống hàng
            Console.WriteLine();
            Console.WriteLine("The list of 5 10... (printed by using for-each)");
            foreach (int y in arr1) Console.Write($"{y} "); // toán tử với mọi x thuộc tập số N arr
                                                            // y là 1 con số nguyên có quyền mang giá trị là x = arr[0], x= arr[1], x = arr[2], x = arr[3], x = arr[4], x = arr[5], x = arr[6], x = arr[7], x = arr[8], x = arr[9]
            Console.WriteLine();
            foreach (var x in arr1) Console.Write($"{x} "); // x chính là 1 cn int do nó ứng với arr[i], mảng nguyên.
            Console.WriteLine();

        };



        static Action PlayWithIntegerListV3 = () =>
    {
        int[] arr1 = { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };
        //            new ngầm int[10]
        // [] nhiều biến int
        //               [0] [1] [2] [3]
        //               các biến int như bình thường kèm value
        //               int x = 5, và x đc gọi tên mới là arr[0]
        //               tên biến lẻ này hơi dài về tên 1 chút
        // arr LÀ BIẾN MÁ MÌ QUẢN LÍ DƯỚI TRƯỚNG 
        //     10 EM BIẾN INT LẺ [0] [1] [2]
        // ARR LÀ BIẾN CON TRỎ VÙNG NEW BỰ CHỨA 10 BIẾN INT 
        // vậy arr có quyền chấm để đi vào vùng new
        // ARR LÀ BIẾN OBJECT, VÌ TRỎ VÙNG NEW BỰ PHỨC TẠP
        //                     VÌ VÙNG NEW BỰ INT CÓ 10 BIẾN INT
        // MẢNG LÀ BIẾN THAM CHIẾU LUÔN
    }; // VIP



        static Action PlayWithDelegateV3 = () =>
        {
            Console.WriteLine("Test");
        };

        static Action PlayWithIntegerListV2 = () =>
        {
            // CÁCH HIỆN ĐẠI, HIỆU QUẢ - KHAI BÁO SỈ - CÚ PHÁP ĐÚNG CÁCH CÁCH VIẾT SẼ RỐI HƠN 1 CHÚT
            int a = 5, b = 10, c = 15, d = 20;
            int[] arr1 = { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };
            // NEW NGẦM, arr1 = new int[10];
            int[] arr2 = [5, 10, 15, 20, 25, 30, 35, 40, 45, 50];
            // new ngầm LUÔN
            int[] arr3 = new int[10] { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };
            int[] arr4 = new int[] { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };
            int[] arr5 = new int[10];
            //           CÓ 1O BIẾN INT RIÊNG LẺ NHƯNG ĐƯỢC KHAI BÁO NHANH = 1 CÂU LỆNH
            //           10 BIẾN INT NÀY LÀ: arr[0], arr[1], arr[2], arr[3], arr[4], arr[5], arr[6], arr[7], arr[8], arr[9].
            arr5[0] = 5;
            arr5[1] = 10;
            arr5[2] = 15;
            arr5[3] = 20;
            arr5[4] = 25;
            arr5[5] = 30;
            arr5[6] = 35;
            arr5[7] = 40;
            arr5[8] = 45;
            arr5[9] = 50;
            // KHAI BÁO MẢNG: MẢNG LÀ KĨ THUẬT KHAI BÁO NHIỀU BIẾN, (KHAI BÁO SỈ)
            // CÙNG 1 LÚC, CÙNG 1 KIỂU, CÙNG 1 TÊN, Ở SÁT NHAU TRONG RAM

            // KHAI BÁO MẢNG LÀ KHAI BÁO NHIỀU BIẾN ĐỂ CHỨA NHIỀU GIÁ TRỊ TRONG RAM
            // MỘT CÁCH HIỆU QUẢ, NHANH GỌN HIỆU QUẢ

            // DO MẢNG LÀ ĐẠI DIỆN CHO NHIỀU BIẾN TRÙNG TÊN TRÙNG KIỂU, DO ĐÓ ĐỂ
            // PHÂN BIỆT TỪNG BIẾN LẺ, TA DÙNG [INDEX ĐẾM TỪ 0]

            // BIẾN THỨ [0], BIẾN THỨ [1], BIẾN THỨ [2]

            // CÓ 3 THỨ CẦN LƯU Ý KHI CHƠI MẢNG
            // TÊN MẢNG
            // NEW [] NEW NGOẶC VUÔNG
            // ...

        };


        // CHALLENGE 1: HÃY LƯU TRỮ DÃY SỐ 5 10 15 20 25 30 35 40 45 50... VÀ IN RA MÀN HÌNH
        static Action PlayWithIntegerListV1 = () =>
        {
            // CÁCH TRUYỀN THỐNG KIỂU TRÂU BÒ - KHAI BÁO LẺ, BIẾN LẺ, BIẾN RỜI RẠC, TỪNG BIẾN 1
            // biến: tên gọi cho value nào đó
            //int a, b, c, d, e, f, g, h, j;
            //a = 5;
            //b = 10;
            //c = 15;
            //d = 20;
            //e = 25;
            //f = 30;
            //g = 35;
            //h = 40;
            //j = 45;
            //k = 50;
            int a = 5; int b = 10, c = 15, d = 20, e = 25, f = 30, g = 35, h = 40, j = 45, k = 50;
            // In ra màn hình
            Console.WriteLine("The list of 5 10 15...");
            Console.WriteLine($"{a} {b} {c} {d} {e} {f} {g} {h} {j} {k}");

        };

        static Predicate<int> IsEven = x => x % 2 == 0;
        static Predicate<int> IsOdd = x => x % 2 == 1;
        static Func<double, double> CalculateSquare = x => Math.Pow(x, 2);

    }
}
