using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Listing2_8
{
    class Listing2_8
    {
        static void Main(string[] args)
        {
            //create cancellation token source
            CancellationTokenSource tokenSource = new CancellationTokenSource();

            //create cancellation token
            CancellationToken token = tokenSource.Token;

            //create task
            Task task = new Task(() => {
                for (int i = 0; i < int.MaxValue; i++)
                {
                    if (token.IsCancellationRequested)
                    {
                        Console.WriteLine("Task cancelation detected");
                        throw new OperationCanceledException(token);
                    }
                    else
                    {
                        Console.WriteLine("Int value: {0}", i);
                    }
                }
            }, token);

            //regirster a cancellation delegate
            token.Register(() => {
                Console.WriteLine(">>>>  Delegate Invoked\n");
            });

            // wait for input before we start the task
            Console.WriteLine("Press enter to start task");
            Console.WriteLine("press enter again to cancel the task");
            Console.ReadLine();

            //start the task
            task.Start();

            //read line from console
            Console.ReadLine();
            tokenSource.Cancel();

            // wait for input before exiting
            Console.WriteLine("Main method complete. Press enter to finish.");
            Console.ReadLine();
        }
    }
}
