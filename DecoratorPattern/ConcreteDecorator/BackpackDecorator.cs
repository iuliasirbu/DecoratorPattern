namespace DecoratorPattern
{
    public class BackpackDecorator : GirlDecorator
    {
        public BackpackDecorator(IGirl girl) : base(girl)
        {
        }

        public override string GirlDescription()
        {
            string type = base.GirlDescription();
            type += "\r\nShe has a backpack";
            return type;
        }
    }
}
