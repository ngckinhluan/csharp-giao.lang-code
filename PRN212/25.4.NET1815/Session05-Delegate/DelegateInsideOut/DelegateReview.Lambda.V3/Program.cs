namespace DelegateReview.Lambda.V3
{
    // VIẾT GIÙM TUI HÀM TÍNH DINE65 TÍCH HÌNH CHỮ NHẬT (WIDTH + LENGTH_
    // VIẾT GIÙM TUI HÀM MŨ A^B, X^Y
    // HÀM PHẢI TRẢ VỀ GIÁ TRỊ, KO ĐC IN KQ, TRẢ VỀ ĐỂ NƠI GỌI TỰ IN
    // VOID HÀM PHẢI TỰ IN
    // STYLE HÀM: DOUBLE F(DOUBLE A, DOUBLE B)
    delegate double TwoInputsOneOutput(double a, double b);
    internal class Program
    {
        static void Main(string[] args)
        {
            TwoInputsOneOutput f = ComputeRectangleArea;
            double area = f(5, 10);
            Console.WriteLine("Compute area (5 x 10) using delegate: " + area);
            f = (w, l) => w * l;
            area = f(3, 7);
            Console.WriteLine("Compute area (3 x 7) using lambda: " + area);

            // VIẾT HÀM TÍNH A^B, 2^10 = 1024 = 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2 FOR
            // MATH.POW(A, B) ~ A^B JAVA Y CHANG
            f = (a, b) => Math.Pow(a, b);
            double power = f(2, 10);
            Console.WriteLine("Compute 2^10 using lambda: " + power);

            // CÂU VIEW CHO BUỔI HỌC SAU
            var fx = (int a, int b, int c) => a + b + c;
            Console.WriteLine("fx(3, 4, 5): " + fx(3, 4, 5));
        }
        static double ComputeRectangleArea(double width, double length) => width * length;

    }
}
