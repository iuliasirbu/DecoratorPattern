namespace DecoratorPattern.ConcreteDecorator
{
    public class BowDecorator : GirlDecorator
    {
        public BowDecorator(IGirl girl) : base(girl)
        {
        }

        public override string GirlDescription()
        {
            string type = base.GirlDescription();
            type += "\r\nShe has a bow";
            return type;
        }
    }
}
