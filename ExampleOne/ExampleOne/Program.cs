//Console.WriteLine("Hello, OS");

namespace ExampleOne
{
    public delegate void WorkPerformedHandler(int workHours, WorkType workType);
    class Program
    {
        static void Main(string[] args)
        {
            WorkPerformedHandler dl1 = new WorkPerformedHandler(ManagerWorkPerformed);
            dl1(4, WorkType.Golf);
            Console.WriteLine();
            dl1.Invoke(4, WorkType.GoToMeetings);

        }

        public static void ManagerWorkPerformed(int wh, WorkType wt)
        {
            Console.WriteLine("Work Performed by Event Handler");
            Console.WriteLine($"Work Hours: {wh}, Work Type: {wt}");
        }
    }

    public enum WorkType
    {
        Golf,
        GoToMeetings,
        ReportGenerate
    }
}

