//Console.WriteLine("Hello, OS");

namespace ExampleOne
{
    class Program 
    {
        static void Main(string[] args)
        {
            
            WorkPerformedHandler wph = new WorkPerformedHandler(WorkPerformed);
            WorkCompletedHandler wch = new WorkCompletedHandler(WorkCompleted);
            Worker worker = new Worker();
            worker.DoWork(4, WorkType.Task4, wph, wch);
            
        }

        //Delegate Signature must match with the method signature
        static void WorkPerformed(int hours, WorkType workType)
        {
            Console.Write($"{hours} hours completed {workType} ");
        }

        static void WorkCompleted(WorkType workType)
        {
            Console.WriteLine($"{workType} work completed");
        }
    }

    
}

