using Pattern_Test.Patterns.AbstractFactory.AbstractComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Test.Patterns.AbstractFactory
{
    public abstract class AbstractFactoryComponent
    {
        public abstract Reader createReader();
        public abstract Writer createWriter();
    }
}
