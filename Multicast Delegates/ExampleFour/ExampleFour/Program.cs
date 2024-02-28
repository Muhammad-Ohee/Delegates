//Console.WriteLine("Hello, OS");

namespace ExampleFour
{
    public delegate void SimpleDelegate(out int number);
    class Program
    {
        static void Main(string[] args)
        {
            SimpleDelegate simpleDelegate = new SimpleDelegate(MethodOne);
            simpleDelegate += MethodTwo;

            // The ValueFromOutPutParameter will be 2, initialized by MethodTwo(),
            // as it is the last method in the invocation list.
            int finalNumber;
            simpleDelegate(out finalNumber);

            Console.WriteLine($"Returned Value = {finalNumber}");
        }

        // This method sets output parameter Number to 1
        public static void MethodOne(out int Number)
        {
            Console.WriteLine("Method One is Executed");
            Number = 2;
        }
        // This method sets output parameter Number to 2
        public static void MethodTwo(out int Number)
        {
            Console.WriteLine("Method Two is Executed");
            Number = 4;
        }
    }
}