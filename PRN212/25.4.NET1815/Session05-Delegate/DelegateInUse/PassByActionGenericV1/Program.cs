using System.Threading.Channels;

namespace PassByActionGenericV1
{
    // CHALLENGE #1: VIẾT HÀM NHẬN VÀO 1 CON SỐ, IN RA CON SỐ ĐÓ NẾU ĐÓ LÀ SỐ CHẴN
    //               VIẾT HÀM NHẬN VÀO 1 CON SỐ, IN RA CON SỐ ĐÓ NẾU ĐÓ LÀ SỐ LẺ
    //               VIẾT HÀM NHẬN VÀO 1 CON SỐ, IN RA CON SỐ ĐÓ NẾU ĐÓ LÀ SỐ >= 50
    //               VIẾT HÀM NHẬN VÀO 1 CON SỐ, IN RA CON SỐ ĐÓ NẾU ĐÓ LÀ SỐ NGUYÊN TỐ
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    // gọi lẻ 4 hàm là style truyền thống ko nói
        //    PrintEvenNumber(5); // ko in
        //    PrintNumberGtEq50(5); // ko in
        //    PrintPrimeNumber(5); // 5
        //    PrintOddNumber(5);
        //    Console.WriteLine("Round 2");
        //    PrintEvenNumber(10);
        //    PrintOddNumber(11);
        //    PrintPrimeNumber(13);
        //    PrintNumberGtEq50(50);
        //}
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Print even numbers from 5 10 15 20");
        //    PrintOnDemand(PrintEvenNumber); // IN CHẲN TỪ 5 10 15 20 25
        //    Console.WriteLine("Print odd numbers from 5 10 15 20");
        //    PrintOnDemand(PrintOddNumber);
        //    Console.WriteLine("Print prime numbers from 5 10 15 20");
        //    PrintOnDemand(PrintPrimeNumber); // IN nguyên tố từ dãy 5 10 15 20
        //    Console.WriteLine("Print >= 50 numbers from 5 10 15 20");
        //    PrintOnDemand(PrintNumberGtEq50);
        //    // NOTHING

        //    // C#2: THÁCH THỨC DANH HÀI: IN RA CÁC SỐ CHIA HẾT CHO 5
        //    // C#3: CÓ SỐ NÀO IN SỐ NẤY, IN HẾT
        //    Console.WriteLine("Print divisable by 5 numbers from 5 10 15 20");
        //    PrintOnDemand(n =>
        //    {
        //        if (n % 5 == 0) Console.WriteLine($"{n} ");
        //    });
        //    Console.WriteLine("PRINT ALL 5 10 15 20 25 26 29");
        //    PrintOnDemand(n =>
        //    {
        //        Console.WriteLine($"{n} ");
        //    });
        //    // tao sẽ cung cấp 1 con x bên trong của tao cho mày, mày làm gì với x kệ mày
        //    // có thằng check xxx là nguyên tố thì mới in, có thằng thì check chẳng mới in, có thằng ko check gì cả in luôn!!!!
        //}
        // TAO LÀ 1 HÀM NHẬN VÀO 1 HÀM KHÁC CÓ THAM SỐ INT X
        // tao chịu trách nhiệm hàm bên ngoài đưa vào, tao thảy cho nó 1 con số
        // tao phó mặc cho hàm đó làm gì thì làm với con os61 tao thảy cho
        // TAO TRỞ NÊN LINH HOẠT VỚI NHU CẦU XỬ LÍ DATA CỦA MỌI NGƯỜI
        // KHI TAO CHỈ THẢY DATA CỦA TAO CHO MỌI NGƯỜI
        static void PrintOnDemand(Action<int> f)
        {
            // đầu vào đưa lấy ở đâu mà đưa cho f
            // giả sử mình có sẵn data 5 10 15 20 25 26  29
            f(5); // f đại diện - luật sư của nhiều hàm khác cùng style void F(int x)
            // data bên trong class mình viết chứa hàm TraiBao() sẽ gửi cho hàm đâu đó bên ngoài, outsource xử lí data ra ngoài
            f(10);
            f(15);
            f(20);
            f(25);
            f(26);
            f(29);
            // NHỜ BÊN NGOÀI FILETR DATA THEO CÁCH CỦA HỌ
            // TẬP DATA 5 10 15 20... TRONG NỘI TẠI SẼ ĐC CUNG ỨNG RA BÊN NGOÀI
            // CUNG ỨNG DỊCH VỤ XỬ LÍ DATA THEO YEU CẦU
            // BÁC NÀO MÚN XỬ LÍ, EM ĐƯA DATA BÁC LO XU LI
        }

        static void Main(string[] args)
        {

            Console.WriteLine(" >= 50");
            PrintOnDemandV2(PrintNumberGtEq50);
            // C#4: IN SỐ CHIA HẾT CHO 3
            Console.WriteLine("Divisable by 3");
            PrintOnDemandV2(n =>
            {
                if (n % 3 == 0) Console.Write($"{n} ");
            });
        }

        static void PrintOnDemandV2(Action<int> f)
        {
            // NẾU TA CÓ NHIỀU DATA CẦN SÀNG LỌC THEO NHU CẦU BÊN NGOÀI, THÌ ĐƯA DATA VÀO MẢNG
            // LEVEL HÔM QUA: TAO GỌI MÀY, MÀY LÀM ĐI Action f, LÀM TRỌNG GÓI ĐÓNG KÍN
            // LEVEL HÔM NAY: TAO GỌI MÀY, MÀY LÀM ĐI Action<int> f. TAO TỬ TẾ GỬI THÊM
            //            INFO CHO MÀY, MÀY LÀM GÌ INFO KỆ MÀY
            // NẾU TAO CÓ NHIỀU DATA, TAO ĐƯA HẾT CHO MÀY QUA VÒNG FOR() MỚI GỌI ĐƯỢC MÀY NHIỀU LẦN; MÀY LÀM GÌ VỚI ĐÁM DATA TAO GỬI KỆ MÀY: CÓ DATA VÀ KÊU GỌI XỬ LÍ Ở BÊN NGOÀI
            // BÊN NGOÀI MUỐN IN CHẴN, IN LẺ, IN NGUYÊN TỐ, SỐ ÂM, SỐ DƯƠNG... HỖ TRỢ HẾT
            List<int> arr = new List<int> { 5, 99, 10, 15, 20, 1, 3, 5, 7, 100, 101 };
            foreach (var x in arr)
            {
                f(x);
            }
        }
        static void PrintEvenNumber(int n)
        {
            if (n % 2 == 0) Console.WriteLine($"{n} ");
        }

        static void PrintOddNumber(int n)
        {
            if (n % 2 != 0) Console.WriteLine($"{n} ");
        }

        static void PrintNumberGtEq50(int n)
        {
            if (n >= 50) Console.WriteLine($"{n}");
        }

        static void PrintPrimeNumber(int n)
        {
            if (n < 2) return;
            for (int i = 2; i < Math.Sqrt(n); i++)
            {
                if (n % i == 0) return; // lỡ chia hết đứa nào, thoát luôn ko in
            }
            Console.WriteLine($"{n}"); // sống sót đến đây là nguyên tố chắc luôn

        }
    }
}
