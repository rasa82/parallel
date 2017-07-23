using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Listing2_7
{
    class Listing2_7
    {
        static void Main(string[] args)
        {
            //create the cancellation token source
            CancellationTokenSource tokenSource = new CancellationTokenSource();

            //create the cancellation token
            CancellationToken token = tokenSource.Token;

            //create task
            Task task = new Task(() => {
                for (int i = 0; i < int.MaxValue; i++)
                {
                    if(token.IsCancellationRequested){
                        Console.WriteLine("Task cancel detected");
                        throw new OperationCanceledException(token);
                    }
                    else
                    {
                        Console.WriteLine("Int value {0}", i);
                    }
                }
            }, token);

            // wait for input before the task
            Console.WriteLine("Press enter to start task");
            Console.WriteLine("Press enter again to cancel task");
            Console.ReadLine();

            //start the task
            task.Start();

            //read a line from the console
            Console.ReadLine();

            //cancel the task
            Console.WriteLine("Cancelling task");
            tokenSource.Cancel();

            // wait for input before exiting
            Console.WriteLine("Main method complete. Press enter to finish.");
            Console.ReadLine();
        }
    }
}
