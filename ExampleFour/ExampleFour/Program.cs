//Console.WriteLine("Hello, OS");

using System.Reflection;

namespace ExampleFour
{
    public delegate void DoSomeMethodHandler(string message);
    class Program
    {
        static void Main(string[] args)
        {
            SomeClass someClass = new SomeClass();
            DoSomeMethodHandler dl1 = new DoSomeMethodHandler(someClass.DoSomeWork);
            dl1 += SomeClass.DoSomeWork2;
            //dl1("OS");
            //dl1.Invoke("OS");

            MethodInfo methodInfo = dl1.Method;
            object Target = dl1.Target;
            Delegate[] InvocationList = dl1.GetInvocationList();

            Console.WriteLine($"Method Property: {methodInfo}");
            Console.WriteLine($"Target Property: {Target}");

            foreach (var item in InvocationList)
            {
                Console.WriteLine($"Invocation List: {item}");
            }
        }
    }

    public class SomeClass
    {
        public void DoSomeWork(string message)
        {
            Console.WriteLine("Do some work Executed");
            Console.WriteLine($"Hello: {message}, Good Morning");
        }

        public static void DoSomeWork2(string message)
        {
            Console.WriteLine("Do some work Executed");
            Console.WriteLine($"Hello: {message}, Good Morning");
        }
    }
}

