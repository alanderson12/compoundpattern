using System.IO;
using System;

namespace CompoundPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Simulate();
        }

        public static void Simulate()
        {

            AbstractDuckFactory duckFactory = new CountingDuckFactory();

            IQuackable mallerdDuck = new QuackCounter(new MallerdDuck());
            IQuackable redHeadDuck = new QuackCounter(new RedHeadDuck());
            IQuackable duckCall = new QuackCounter(new DuckCall());
            IQuackable rubberDuck = new QuackCounter(new RubberDuck());
            IQuackable gooseDuck = new GooseAdapter(new Goose());

            Console.WriteLine("\nDuck Simulator");
            Simulate(mallerdDuck);
            Simulate(redHeadDuck);
            Simulate(duckCall);
            Simulate(rubberDuck);
            Simulate(gooseDuck);

        Console.WriteLine("The ducks quacked " + QuackCounter.GetNumberOfQuacks() + " times");
        }

        public static void Simulate(IQuackable duck)
        {
            duck.Quack();

            string cs = Directory.GetCurrentDirectory() + "/post.db";
        }
    }
}
