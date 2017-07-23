using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing2_4
{
    class Listing2_4
    {
        static void Main(string[] args)
        {

            string[] message = { "First Task", "Second Task", "Third Task", "Fourth Task"};

            foreach (string msg in message)
            {
                Task myTask = new Task(obj => printMessage((string)obj), msg);
                myTask.Start();
            }

            // wait for input before exiting
            Console.WriteLine("Main method complete. Press enter to finish.");
            Console.ReadLine();
        }

        static void printMessage(string message){

            Console.WriteLine("Message {0}", message);
        }
    }
}
