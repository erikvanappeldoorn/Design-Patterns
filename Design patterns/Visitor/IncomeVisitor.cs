using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Visitor
{
    public class IncomeVisitor : IVisitor
    {
        public void Visit(Element element)
        {
            Employee  employee = element as Employee;
            employee.AnnualSalary *= 1.10;
            Console.WriteLine($"{employee.Name} new salary: {employee.AnnualSalary}" );
        }
    }
}
