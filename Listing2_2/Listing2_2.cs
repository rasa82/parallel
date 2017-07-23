using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing2_2
{
    class Listing2_2
    {
        static void printMessage()
        {
            Console.WriteLine("Hello World");
        }
        static void Main(string[] args)
        {
            // use an Action delegate and a named method
            Task task1 = new Task(new Action(printMessage));

            // use a anonymous delegate
            Task task2 = new Task(delegate
            {
                printMessage();
            });

            //use lambda expression and named method
            Task task3 = new Task(() => printMessage());

            //use lambda expression and an anonymuous method
            Task task4 = new Task(() => {
                printMessage();
            });

            task1.Start();
            task2.Start();
            task3.Start();
            task4.Start();

            //wait for input before exiting
            Console.WriteLine("Main method completed. Press enter to finish.");
            Console.ReadLine();
        }
    }
}
