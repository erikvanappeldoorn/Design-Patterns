using System;
using Design_Patterns.Chain_Of_Responsibility;

namespace Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            ChainOfResponsibilityExample();
            
            Console.ReadLine();
        }

        private static void ChainOfResponsibilityExample()
        {
            var monkey = new MonkeyHandler();
            var squirrel = new SquirrelHandler();
            var dog = new DogHandler();

            monkey.SetNext(squirrel).SetNext(dog);

            string[] food = ["Nut", "Banana", "Cup of coffee"];

            foreach (var item in food)
            {
                Console.WriteLine($"Who wants: {item}?");

                var result = monkey.Handle(item) ?? "Nobody wants it";
                Console.WriteLine($"Result: {result}");
                Console.WriteLine();
            }
        }
    }
}
