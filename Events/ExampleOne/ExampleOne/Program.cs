//Console.WriteLine("Hello, OS");

namespace ExampleOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new Worker();

            //Attaching Worker_WorkPerformed with WorkPerformed Event
            //worker.WorkPerformed += new EventHandler<WorkPerformedEventArgs>(Worker_Performed);
            worker.WorkPerformed += delegate (object sender, WorkPerformedEventArgs e)
            {
                Console.WriteLine($"{e.WorkType} work has completed {e.Hours} hours");
            };

            //Attaching Worker_WorkCompleted with WorkCompleted Event
            //worker.WorkCompleted += new EventHandler(Worker_Completed);
            worker.WorkCompleted += delegate(object sender, EventArgs e)
            {
                Console.WriteLine("Worker Work Completed");
            };

            worker.DoWork(4, WorkType.Golf);
        }

        //Event Handler Method or Event Listener Method
        static void Worker_Performed(object sender, WorkPerformedEventArgs e)
        {
            Console.WriteLine($"{e.WorkType} work has completed {e.Hours} hours");
        }

        //Event Handler Method or Event Listener Method
        static void Worker_Completed(object sender, EventArgs e)
        {
            Console.WriteLine("Worker Work Completed");
        }
    }
}

/*
    The Worker.WorkPerformed event handler we are using the generic event handler delegate and 
    for the Worker.WorkCompleted event handler method using the built-in Event Handler 
 */