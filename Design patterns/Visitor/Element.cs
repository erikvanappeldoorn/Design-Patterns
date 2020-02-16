using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Visitor
{
    public abstract class Element
    {
        public abstract void Accept(IVisitor visitor);
    }
}
