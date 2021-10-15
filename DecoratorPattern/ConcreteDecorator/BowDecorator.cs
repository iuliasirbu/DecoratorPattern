using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
