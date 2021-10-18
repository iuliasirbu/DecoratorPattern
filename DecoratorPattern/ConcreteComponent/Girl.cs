namespace DecoratorPattern
{
    public class Girl : IGirl
    {
        public string name { get; set; }
        public string GirlDescription()
        {
            return "She is " + name;
        }
    }
}