using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        // Define a delegate type
        delegate void DisplayMessage(string message);

        static void Main()
        {
            // Create an instance of the delegate, pointing to the ShowMessage method
            DisplayMessage messageDelegate = ShowMessage;

            // Call the delegate
            messageDelegate("Hello, this is a delegate example!");

            // Create another instance of the delegate, pointing to the ShowUpperCaseMessage method
            messageDelegate = ShowUpperCaseMessage;

            // Call the delegate
            messageDelegate("Hello, this is a delegate example in uppercase!");
            Console.ReadKey();
        }

        // Method that matches the delegate signature
        static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }

        // Another method that matches the delegate signature
        static void ShowUpperCaseMessage(string message)
        {
            Console.WriteLine(message.ToUpper());

        }
    }
}
