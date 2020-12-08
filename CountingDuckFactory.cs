using System.Linq;
namespace CompoundPattern
{
    public class CountingDuckFactory : AbstractDuckFactory
    {
        public override IQuackable CreateMallerdDuck()
        {
            return new QuackCounter(new MallerdDuck());
        }

        public override IQuackable CreateRedHeadDuck()
        {
            return new QuackCounter(new RedHeadDuck());
        }

        public override IQuackable CreateDuckCall()
        {
            return new QuackCounter(new DuckCall());
        }

        public override IQuackable CreateRubberDuck()
        {
            return new QuackCounter(new RubberDuck());
        }
    }
}