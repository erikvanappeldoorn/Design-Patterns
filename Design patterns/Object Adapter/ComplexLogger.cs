using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Object_Adapter
{
    public class ComplexLogger
    {
        public void DisplayInfoMessage(string message)
        {
            Console.WriteLine($"Info: {message}");
        }

        public void DisplayWarningMessage(string message)
        {
            Console.WriteLine($"Warning: {message}");
        }

        public void DisplayErrorMessage(string message)
        {
            Console.WriteLine($"Error: {message}");
        }
    }
}
