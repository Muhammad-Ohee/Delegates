using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOne
{
    public delegate void WorkPerformedHandler(int hours, WorkType  workType);
    public delegate void WorkCompletedHandler(WorkType workType);
    public class Worker
    {
        public void DoWork(int hours, WorkType workType, WorkPerformedHandler workPerformedHandler, WorkCompletedHandler workCompletedHandler)
        {
            //Do Work here and notify the consumer that work has been performed
            for (int i = 0; i < hours; i++)
            {
                int percentHours = 100 / hours;

                //Do Some Processing
                Thread.Sleep(4000);

                //Notify how much progress of the work have been done
                workPerformedHandler(i+1, workType);
                Console.Write($"with {(i+1) * percentHours}%.\n");

            }

            // Notify the consumer that work has been completed
            workCompletedHandler(workType);
        }
    }

    public enum WorkType
    {
        Task1,
        Task2,
        Task3,
        Task4
    }
}
