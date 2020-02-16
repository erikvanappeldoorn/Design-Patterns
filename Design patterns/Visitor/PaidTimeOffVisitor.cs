using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Visitor
{
    public class PaidTimeOffVisitor : IVisitor
    {
        public void Visit(Element element)
        {
            Employee employee = element as Employee;
            employee.PaidTimeOffDays += 3;
            Console.WriteLine($"{employee.Name} new paid time off days: {employee.PaidTimeOffDays}");
        }
    }
}
