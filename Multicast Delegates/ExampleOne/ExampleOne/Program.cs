//Console.WriteLine("Hello, OS");

namespace ExampleOne
{
    public delegate void RectangleDelegate(double height, double width);
    class Rectangle
    {
        public void GetArea(double height, double width)
        {
            Console.WriteLine($"Area is {height * width}");
        }
        public void GetPerimeter(double height, double width)
        {
            Console.WriteLine($"Perimeter is {2 * (height + width)}");
        }
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            RectangleDelegate rectDel = new RectangleDelegate(rect.GetArea);
            rectDel += rect.GetPerimeter;

            Delegate[] InvocationList = rectDel.GetInvocationList();
            Console.WriteLine("InvocationList:");
            foreach (var item in InvocationList)
            {
                Console.WriteLine($"  {item}");
            }

            Console.WriteLine();
            Console.WriteLine("Invoking Multicast Delegate:");
            rectDel.Invoke(13.45, 76.89);

            Console.WriteLine();
            Console.WriteLine("Invoking Multicast Delegate After Removing one Pipeline:");
            //Removing a method from delegate object
            rectDel -= rect.GetPerimeter;
            rectDel.Invoke(13.45, 76.89);
        }
    }
}

