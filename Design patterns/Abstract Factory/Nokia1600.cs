using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Abstract_Factory
{
    public class Nokia1600 : INormalPhone
    {
        public string GetModelDetails()
        {
            return "Model: Nokia 1600\nRAM: NA\nCamera: NA\n";
        }
    }
}
