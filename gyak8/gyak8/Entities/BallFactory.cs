using gyak8.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyak8.Entities
{
    public class BallFactory :IToyFactory
    {
        public Abstractions.Toy CreateNew()
        {
            return new Toy();
        }
    }
}
