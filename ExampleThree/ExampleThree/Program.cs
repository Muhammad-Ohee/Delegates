//Console.WriteLine("Hello, OS");

namespace ExampleThree
{
    public delegate int CalculateDel(int numberOne, int numberTwo);
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            CalculateDel del1 = new CalculateDel(program.AddNumber);
            int result = del1(2, 2);
            Console.WriteLine(result);

            Console.WriteLine();

            del1 = new CalculateDel(program.SubNumber);
            result = del1(4, 2);
            Console.WriteLine(result);
        }

        public int AddNumber(int n1, int n2)
        {
            return n1 + n2;
        }

        public int SubNumber(int n1, int n2)
        {
            return n1 - n2;
        }
    }
}

