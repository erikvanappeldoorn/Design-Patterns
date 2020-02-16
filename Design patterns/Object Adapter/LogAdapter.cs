using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Object_Adapter
{
    public class LogAdapter : ILogger
    {
        private readonly ComplexLogger logger;

        public LogAdapter()
        {
            logger = new ComplexLogger();
        }

        public void Log(string message)
        {
            logger.DisplayInfoMessage(message);
        }
    }
}
