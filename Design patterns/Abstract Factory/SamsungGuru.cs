using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Abstract_Factory
{
    public class SamsungGuru : INormalPhone
    {
        public string GetModelDetails()
        {
            return "Model: Samsung Guru\nRAM: NA\nCamera: NA\n";
        }
    }
}
