using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing2_1
{
    class Listing0_1
    {
        //Create and start a simple task 
        static void Main(string[] args)
        {

            //Call the static Task.Factory.StartNew() method with an Action delegate as an argument
            Task.Factory.StartNew(() =>
            {
                Console.WriteLine("Hello world");
            });

            //wait for input before exiting
            Console.WriteLine("Main method completed. Press enter to finish.");
            Console.ReadLine();
        }
    }
}
