using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Abstract_Factory
{
    public class SamsungFactory : IMobilePhoneAbstractFactory
    {
        public INormalPhone GetNormalPhone()
        {
            return new SamsungGuru();
        }

        public ISmartPhone GetSmartPhone()
        {
            return new SamsungGalaxy();
        }
    }
}
