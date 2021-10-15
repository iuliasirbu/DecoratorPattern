using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
