namespace CompoundPattern
{
    public class DuckFactory : AbstractDuckFactory
    {
        public override IQuackable CreateMallerdDuck()
        {
            return new MallerdDuck();
        }

        public override IQuackable CreateRedHeadDuck()
        {
            return new RedHeadDuck();
        }

        public override IQuackable CreateDuckCall()
        {
            return new DuckCall();
        }

        public override IQuackable CreateRubberDuck()
        {
            return new RubberDuck();
        }
    }
}