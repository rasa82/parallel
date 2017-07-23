using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Listing2_9
{
    class Listing2_9
    {
        static void Main(string[] args)
        {
            // create cancellation token source
            CancellationTokenSource sourceToken = new CancellationTokenSource();

            // create cancellation token
            CancellationToken token = sourceToken.Token;

            //create task
            Task task = new Task(() => {
                for (int i = 0; i < int.MaxValue; i++)
                {
                    if (token.IsCancellationRequested)
                    {
                        Console.WriteLine("Task cancel detected!");
                        throw new OperationCanceledException(token);
                    }
                    else
                    {
                        Console.WriteLine("Int value is: {0}",i);
                    }
                }
            }, token);

            // create second task that will use wait handle
            Task task2 = new Task(() => { 
                // wait in the handle
                token.WaitHandle.WaitOne();
                // write out a message
                Console.WriteLine(">>>>  wait handle released");
            });

            // wait for input before we start the task
            Console.WriteLine("Press enter to start task");
            Console.WriteLine("Press enter again to cancel tasl");
            Console.ReadLine();

            //starting a task
            task.Start();
            task2.Start();

            // cancel task
            Console.ReadLine();
            sourceToken.Cancel();

            // wait for input before exiting
            Console.WriteLine("Main method complete. Press enter to finish.");
            Console.ReadLine();
        }
    }
}
