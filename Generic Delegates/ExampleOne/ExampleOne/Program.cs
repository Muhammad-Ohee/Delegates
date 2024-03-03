//Console.WriteLine("Hello, OS");

namespace ExampleOne
{
    class Program
    {
        static void Main(string[] args)
        {
            // The Func delegates can contain a maximum of 16 input parameters and
            // must have one return type and that will be the last parameter in the
            // parameter list.
            Func<int, float, double, double> objectOneFunc = new Func<int, float, double, double>(AddNumber1);
            Func<int, float, double, double> objectTwoFunc = (x, y, z) => x + y + z;
            var result = objectOneFunc.Invoke(10, 10.10f, 10.1010);
            Console.WriteLine(result);
            result = objectTwoFunc.Invoke(10, 10.10f, 10.1010);
            Console.WriteLine(result);

            Console.WriteLine();

            // Action delegate can contain a maximum of 16 input parameters and does not have any return type.
            Action<int, float, double> objectOneAction = new Action<int, float, double>(AddNumber2);
            Action<int, float, double> objectTwoAction = (x, y, z) =>
            {
                Console.WriteLine(x + y + z);
            };
            objectOneAction.Invoke(40, 40.40f, 40.4040);
            objectTwoAction.Invoke(40, 40.40f, 40.4040);

            Console.WriteLine();

            // The Predicate delegate should satisfy some criteria of a method and
            // must have only one input parameter. By default, it is having one
            // output parameter of return type, and we don’t have to pass the output
            // parameter to the Predicate.
            Predicate<string> objectOnePredicate = new Predicate<string>(CheckLength);
            Predicate<string> objectTwoPredicate = x => x.Length > 4;
            var resultTwo = objectOnePredicate.Invoke("Angel");
            Console.WriteLine(resultTwo);
            resultTwo = objectTwoPredicate.Invoke("Angel");
            Console.WriteLine(resultTwo);

        }

        public static double AddNumber1(int no1, float no2, double no3)
        {
            return no1 + no2 + no3;
        }
        public static void AddNumber2(int no1, float no2, double no3)
        {
            Console.WriteLine(no1 + no2 + no3);
        }
        public static bool CheckLength(string name)
        {
            if (name.Length > 4)
                return true;
            return false;
        }
    }
}

