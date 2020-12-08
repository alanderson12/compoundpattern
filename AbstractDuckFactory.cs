namespace CompoundPattern
{
    public abstract class AbstractDuckFactory
    {
        public abstract IQuackable CreateMallerdDuck();
        public abstract IQuackable CreateRedHeadDuck();
        public abstract IQuackable CreateDuckCall();
        public abstract IQuackable CreateRubberDuck();
    }
}