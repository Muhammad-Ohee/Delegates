//Console.WriteLine("Hello, OS");

namespace ExampleTwo
{
    public delegate void CallbackMethodHandler(string message);
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            CallbackMethodHandler dl1 = new CallbackMethodHandler(program.Callback);

            DoSomething(dl1); // Passing delegate reference with method pointer

        }

        public static void DoSomething(CallbackMethodHandler callbackMethodHandler) // Method Passing as a parameter
        {
            Console.WriteLine("Do something....");
            //callbackMethodHandler("OS");
            callbackMethodHandler.Invoke("OS");
        }

        public void Callback(string message)
        {
            Console.WriteLine("Callback Method Executed");
            Console.WriteLine($"Hello: {message}, Good Morning");
        }
    }
}

