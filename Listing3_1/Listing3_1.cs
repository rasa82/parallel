using System;
using System.Threading.Tasks;

namespace Listing3_1
{
    class Listing3_1
    {
        static void Main(string[] args)
        {
            //create the bank accoutn instance
            BankAccount account = new BankAccount();

            //create an array of tasks
            Task[] tasks = new Task[10];

            for (int i = 0; i < 10; i++)
            {
                //create a new task
                tasks[i] = new Task(() =>
                {
                    //enter a loop for 1000 balance updates
                    for (int j = 0; j < 100; j++)
                    {
                        //update the balance
                        account.Balance = account.Balance + 1;
                    }
                });

                //start the new task
                tasks[i].Start();
            }

            //wait for all of tasks to complete
            Task.WaitAll(tasks);

            //write out the counter value
            Console.WriteLine("Expected value {0}, Counter value: {1}", 10000, account.Balance);
            // wait for input before exiting
            Console.WriteLine("Press enter to finish");
            Console.ReadLine();
        }
    }
}
