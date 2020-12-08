using System.Linq.Expressions;
using System.Globalization;
using System.Runtime.CompilerServices;
using System;

namespace CompoundPattern
{
    public class GooseAdapter : IQuackable
    {
        Goose goose;

        public GooseAdapter(Goose goose)
        {
            this.goose = goose;
        }

        public void Quack()
        {
            goose.Honk();
        }
    }
}