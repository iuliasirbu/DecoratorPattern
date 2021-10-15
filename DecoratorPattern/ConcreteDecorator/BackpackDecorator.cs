using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
