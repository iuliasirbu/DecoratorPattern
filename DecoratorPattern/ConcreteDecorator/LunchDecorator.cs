namespace DecoratorPattern.ConcreteDecorator
{
    public class LunchDecorator : GirlDecorator
    {
        public LunchDecorator(IGirl girl) : base(girl)
        {
        }

        public override string GirlDescription()
        {
            string type = base.GirlDescription();
            type += "\r\nShe has a lunch sack";
            return type;
        }
    }
}
