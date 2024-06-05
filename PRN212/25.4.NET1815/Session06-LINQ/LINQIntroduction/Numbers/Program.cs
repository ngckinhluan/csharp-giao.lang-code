using System.Reflection;

namespace Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlayWithBuiltInDemandMethodsV2();
        }

        static void PlayWithBuiltInDemandMethodsV2()
        {
            List<int> _arr = new List<int> { -10, -100, 50, 2, 1, 5, 10, 13, -2 };
            var result = from x in _arr
                         where x > 0
                         select x;

            List<int> query = (from x in _arr
                               where x > 0
                               select x).ToList();
            IEnumerable<int> query2 = from x in _arr
                                      where x > 0
                                      select x;

            foreach (var i in query)
            {
                Console.WriteLine($"{i} ");
            }

            Console.WriteLine("Divisible by 2");
            result = from x in _arr // voi moi x thuoc tap _arr
                     where x % 2 == 0
                     select x;
            foreach (var i in result)
            {
                Console.WriteLine($"{i} ");
            }

        }

        static void PlayWithBuiltInOnDemandMethods()
        {
            List<int> _arr = new List<int> { -10, -100, 50, 2, 1, 5, 10, 13, -2 };
            Console.WriteLine("All =======================");
            _arr.ForEach(x => Console.Write($"{x} "));
            Console.WriteLine("< 0 ========================");
            _arr.ForEach(x =>
            {
                if (x < 0) Console.Write($"{x} ");
            });
            IEnumerable<int> result = _arr.Where(x => x > 0);
            List<int> result2 = _arr.Where(x => x > 0).ToList();
            result2.ForEach(x => Console.WriteLine($"{x} "));
        }

        static void PrintListOnDemand(Predicate<int> f)
        {
            List<int> _arr = new List<int> { -10, -100, 50, 2, 1, 5, 10, 13, -2 };
            foreach (var x in _arr)
            {
                if (f(x)) Console.WriteLine($"{x} ");
            }
        }
    }
}