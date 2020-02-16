using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Abstract_Factory
{
    public class NokiaPixel : ISmartPhone
    {
        public string GetModelDetails()
        {
            return "Model: Nokia Pixel\nRAM: 3GB\nCamera: 8MP\n";
        }
    }
}
