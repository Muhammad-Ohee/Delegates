//Console.WriteLine("Hello, OS");

namespace ExampleOne
{
    delegate string AnnonymousMethod(string name);
    class Program
    {
        static void Main(string[] args)
        {
            string Message = ". Welcome to Oblivion.";
            //AnnonymousMethod del = new AnnonymousMethod(AnnonymousMethodHandler);

            AnnonymousMethod del = delegate (string name)
            {
                return "Hello " + name + Message;
            };

            //AnnonymousMethod del = name => "Hello " + name + Message;


            Console.WriteLine(del("OS"));
        }

        /*static string AnnonymousMethodHandler(string name)
        {
            return "Hello " + name + ". Welcome to Oblivion.";
        }*/
    }
}

