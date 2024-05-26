namespace Bmi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double weight = 70; // 70 kg
            double height = 1.7; // m
            double bmi = weight / (height * height);
            Console.WriteLine($"Your bmi is: {bmi}");
            
        }
    }
}
