using System.Diagnostics.CodeAnalysis;

namespace MethodOverloading
{
    public class Program
    {
        public static int Add(int a, int b)
        {
            Console.WriteLine(a + b);
            return a + b;
        }
        public static double Add(double a, double b)
        {
            Console.WriteLine(a + b);
            return a + b; 
        }
        public static bool Add(int a, int b, bool isTrue)
        {
            int y = a + b;
            int sum = y;
            if (sum != -1 && sum != 1)
            {
                Console.WriteLine($"{sum} dollars");
                return true;
                
            }
           else
            {
                Console.WriteLine($"{sum} dollar");
                return false;
            }
            
        }
        static void Main(string[] args)
        {
            Add(2, 6);

            Add(8.60, 9.0);

            Add(1, 1, true);
        }
    }
}
