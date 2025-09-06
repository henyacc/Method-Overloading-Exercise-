namespace MethodOverloading
{
    public class Program
    {
        public static int Add(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }

        public static decimal Add(decimal numOne, decimal numTwo)
        {
            return numOne + numTwo;
        }

        public static string Add(int numOne, int numTwo, bool isCurrency)
        {
            int sum = numOne + numTwo;
            
            if (isCurrency && sum > 1)
            {
                return $"{sum} dollars";
            }  
            else if (isCurrency && sum == 1)
            {
                return $"{sum} dollar";
            }
            else
            {
                return sum.ToString();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Add(1, 2));
            Console.WriteLine(Add(1.4m, 2.687m));
            Console.WriteLine(Add(numOne:1, numTwo:1, isCurrency: true));
        }
    }
}
