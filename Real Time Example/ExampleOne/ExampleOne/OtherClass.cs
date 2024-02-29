using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOne
{
    public class OtherClass
    {
        void SomeOtherMethod()
        {
            WorkPerformedHandler wph = new WorkPerformedHandler(WorkPerformed);
            WorkCompletedHandler wch = new WorkCompletedHandler(WorkCompleted);
            Worker worker = new Worker();
            worker.DoWork(8, WorkType.Task2, wph, wch);
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
