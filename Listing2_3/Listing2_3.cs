using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing2_3
{
    class Listing2_3
    {
        static void Main(string[] args)
        {
            // use an Action delegate and a named methos
            Task task1 = new Task(new Action<object>(printMessage), "First Message");

            //use anonymous delefate
            Task task2 = new Task(delegate(object obj)
            {
                printMessage(obj);
            }, "Second Task");

            // use lambda expression and a named method
            // note that parameters to a lambda don't need
            // to be youted if there is only one parameter
            Task task3 = new Task((obj) => printMessage(obj), "Third Task");

            // use lambda expression and anonymous method
            Task task4 = new Task((obj) => { printMessage(obj); }, "Fourth Task");

            task1.Start();
            task2.Start();
            task3.Start();
            task4.Start();

            //wait for input before exiting
            Console.WriteLine("Main method completed. Press enter to finish.");
            Console.ReadLine();
        }

        static void printMessage(object message)
        {
            Console.WriteLine("Message: {0}", message);
        }
    }
}
