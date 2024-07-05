using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDZ6
{
    public class Roof : IPart
    {
        public void Builder(House house)
        {
            house.roof = new Roof();
        }
    }
}
