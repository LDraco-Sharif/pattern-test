using Pattern_Test.Patterns.AbstractFactory.AbstractComponents;
using Pattern_Test.Patterns.AbstractFactory.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Test.Patterns.AbstractFactory.Factory
{
    public class Csv : AbstractFactoryComponent
    {
        public override Reader createReader()
        {
            return new CsvReader();
        }

        public override Writer createWriter()
        {
            return new CsvWriter();
        }
    }
}
