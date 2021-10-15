using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
