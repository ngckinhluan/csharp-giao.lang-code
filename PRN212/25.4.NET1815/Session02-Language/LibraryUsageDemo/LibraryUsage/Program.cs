using BmiV2;

namespace LibraryUsage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double bmi = BmiCalculator.GetBmi(70, 1.7);
            BmiCalculator.PrintBmi();
            Console.WriteLine($"BMI: {bmi}");
            Console.WriteLine("BMI: " + bmi);
            Console.WriteLine($@"BMI: {bmi}");
            Console.WriteLine("BMI: {0}", bmi);
            Console.WriteLine($"BMI: {BmiCalculator.GetBmi(70, 1.7)}");
        }
    }
}
