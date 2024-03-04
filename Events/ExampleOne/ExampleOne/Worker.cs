using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOne
{
    //Step1: Define one delegate
    //public delegate void WorkPerformedHandler(int hours, WorkType workType);

    //public delegate void WorkPerformedHandler(object sender, WorkPerformedEventArgs e); // This is custom delegate

    public class Worker
    {
        //Step2: Define one event to notify the work progress using the custom delegate
        //public event WorkPerformedHandler WorkPerformed;
        public event EventHandler<WorkPerformedEventArgs> WorkPerformed;

        //Step2: Define another event to notify when the work is completed using built-in EventHandler delegate
        public event EventHandler WorkCompleted;

        public void DoWork(int hours, WorkType workType)
        {
            //Do Work here and notify the consumer that work has been performed
            for (int i = 0; i < hours; i++)
            {
                OnWorkPerformed(i, workType);
                Thread.Sleep(4000);
            }

            //Notify the consumer that work has been completed
            OnWorkCompleted();
        }

        protected virtual void OnWorkPerformed(int hours, WorkType workType)
        {
            //Raising Events only if Listeners are attached

            //Approach 1.1
            /*if (WorkPerformed != null)
            {
                WorkPerformed(4, WorkType.Golf);
            }*/

            //Approach 1.2
            if (WorkPerformed != null)
            {
                WorkPerformedEventArgs e = new WorkPerformedEventArgs()
                {
                    Hours = hours,
                    WorkType = workType
                };
                WorkPerformed(this, e);
            }




            //Approach 2
            //WorkPerformed?.Invoke(4, WorkType.Golf);
            /*WorkPerformed?.Invoke(this, new WorkPerformedEventArgs()
            {
                Hours = hours,
                WorkType = workType
            });*/



            //Approach 3.1
            /*WorkPerformedHandler del = WorkPerformed as WorkPerformedHandler;
            if (del != null)
            {
                del(8, WorkType.Golf);
            }*/

            //Approach 3.2
            /*EventHandler<WorkPerformedEventArgs> del = WorkPerformed as EventHandler<WorkPerformedEventArgs>;
            if (del != null)
            {
                WorkPerformedEventArgs e = new WorkPerformedEventArgs()
                {
                    Hours = hours,
                    WorkType = workType
                };
                del(this, e);
            }*/





            //Approach 4.1
            /*if (WorkPerformed is WorkPerformedHandler del)
            {
                del(4, WorkType.Golf);
            }*/

            //Approach 4.2
            /*if (WorkPerformed is EventHandler<WorkPerformedEventArgs> del)
            {
                WorkPerformedEventArgs e = new WorkPerformedEventArgs()
                {
                    Hours = hours,
                    WorkType = workType
                };
                del(this, e);
            }*/
        }

        protected virtual void OnWorkCompleted()
        {
            //Raising the Event

            //Approach 1
            //EventHandler delegate takes two parameters i.e. object sender, EventArgs e
            //Sender is the current class i.e. this keyword and, we do not need to pass any data
            //So, we need to pass Empty EventArgs
            WorkCompleted?.Invoke(this, EventArgs.Empty);

            //Approach 2
            /*if (WorkCompleted is EventHandler del)
            {
                del(this, EventArgs.Empty);
            }*/
        }
    }

    

    public enum WorkType
    {
        Golf,
        GotoMeetings,
        GenerateReports
    }
}


/*
    Let us discuss each of the methods used in the above code:
   
    DoWork: This method takes int hours, and WorkType workType as parameters, 
            and inside this method, we are running a loop based on the int hours. 
            And each time we run the loop we call the OnWorkPerformed method and 
            then make the loop sleep for 3 seconds and once the loop is completed, 
            we call the OnWorkCompleted.

    OnWorkPerformed: In this method, we are raising the event and notifying 
                     the consumer that the work is going on.

    OnWorkCompleted: In this method, we are raising the event and notifying 
                     the consumer that the work is completed. This event is created using 
                     the built-in delegate EventHandler which is taking two parameters i.e. 
                     object sender, EventArgs e. Here, Sender is the current class i.e. we 
                     can pass this keyword and when the work is completed, we don’t need to 
                     pass any data and, we just need to inform that the work is completed. 
                     So, we need to pass the second parameter as empty. So, here we are 
                     passing EventArgs.Empty as the second parameter.
 */