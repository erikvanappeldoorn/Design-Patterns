using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Abstract_Factory
{
    public interface IMobilePhoneAbstractFactory
    {
        INormalPhone GetNormalPhone();
        ISmartPhone GetSmartPhone();
    }
}
