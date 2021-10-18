namespace DecoratorPattern
{
    public abstract class GirlDecorator : IGirl
    {
        private IGirl _girl;
        public GirlDecorator(IGirl girl)
        {
            _girl = girl;
        }

        public virtual string GirlDescription()
        {
            return _girl.GirlDescription();
        }

    }
}
