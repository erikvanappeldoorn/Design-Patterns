

using Design_Patterns.Abstract_Factory;
using Design_Patterns.Bridge;
using Design_Patterns.Composite;
using Design_Patterns.Decorator;
using Design_Patterns.Facade;
using Design_Patterns.Factory;
using Design_Patterns.Object_Adapter;
using Design_Patterns.Prototype;
using Design_Patterns.Command;
using System;
using Design_Patterns.State;
using Design_Patterns.Strategy;
using Design_Patterns.Visitor;

namespace Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //Factory 

            //var platinumCreditcardFactory = new PlatinumCreditCardFactory(50_000, 100);
            //PlatinumCreditCard creditcard = (PlatinumCreditCard)platinumCreditcardFactory.GetCreditCard();

            //Console.ReadLine();

            // Abstract Factory

            //var samsungFactory = new SamsungFactory();
            //var normalPhone = samsungFactory.GetNormalPhone();
            //var smartPhone = samsungFactory.GetSmartPhone();

            //Console.WriteLine(normalPhone.GetModelDetails());
            //Console.WriteLine(smartPhone.GetModelDetails());

            //Prototype

            //Sandwich sandwich = new Sandwich("Normal", "Chorizo", "Gouda", "pickles");

            //var sandwichCopy = sandwich;
            //sandwichCopy.Cheese = "Brie";

            //Console.WriteLine(sandwich.Cheese);

            // Object Adapter

            //var logAdapter = new LogAdapter();
            //logAdapter.Log("Hello Glasspaper");

            // Bridge

            //McDonalds macDonalds = new McDonalds();
            //var order = new SendGlutenFreeOrder(macDonalds);
            //order.Send();

            // Composite

            //var cola = new Cola(150);
            //cola.Flavors.Add(new CherryCola(25));
            //cola.Flavors.Add(new VanillaCola(50));

            //cola.DisplayCalories();

            // Decorator

            //var moccaMaster = new Filtered();
            //var milkDecorator = new MilkDecorator(moccaMaster);
            //var chocolateDecorator = new ChocolateDecorator(milkDecorator);

            //Console.WriteLine(chocolateDecorator.GetDescription());
            //Console.WriteLine(chocolateDecorator.Cost);

            // Facade

            //var home = new Home();
            //home.Arrive();
            //Console.WriteLine();
            //home.Leave();

            // Command 

            //var switcher = new Switch();
            //var light = new Light();
            //switcher.ExecuteCommand(new SwitchUpCommand(light));
            //switcher.ExecuteCommand(new SwitchDownCommand(light));
            //switcher.ExecuteCommand(new SwitchDownCommand(light));

            // State

            //Player player = new Player();
            //player.HittedByBullets(7);
            //player.HittedByBullets(15);

            //var cook = new Cook(new MicrowaveStrategy());
            //cook.StartCooking("some meat");

            // Visitor

            Employee employee = new Employee("Erik van Appeldoorn", 50_000, 25);
            var incomeVisitor = new IncomeVisitor();
            var paidTimeOffVisitor = new PaidTimeOffVisitor();
            employee.Accept(incomeVisitor);
            employee.Accept(paidTimeOffVisitor);

            Console.ReadLine();

        }
    }
}
