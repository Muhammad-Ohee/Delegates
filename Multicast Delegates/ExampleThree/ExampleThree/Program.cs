//Console.WriteLine("Hello, OS");

namespace ExampleThree
{
    public delegate int SampleDelegate();
    class Program
    {
        static void Main(string[] args)
        {
            SampleDelegate sampleDelegate = new SampleDelegate(MethodOne);
            sampleDelegate += MethodTwo;

            // The Value Returned By Delegate will be 4, returned by the MethodTwo(),
            // as it is the last method in the invocation list.
            int ValueReturnedByDelegate = sampleDelegate();
            Console.WriteLine($"Returned Value = {ValueReturnedByDelegate}");
        }

        // This method returns one
        public static int MethodOne()
        {
            Console.WriteLine("Method One is Executed");
            return 2;
        }
        // This method returns two
        public static int MethodTwo()
        {
            Console.WriteLine("Method Two is Executed");
            return 4;
        }
    }
}

