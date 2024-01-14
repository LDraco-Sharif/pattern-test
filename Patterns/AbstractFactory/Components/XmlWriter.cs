using Pattern_Test.Patterns.AbstractFactory.AbstractComponents;
using Pattern_Test.Patterns.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Pattern_Test.Patterns.AbstractFactory.Components
{
    public class XmlWriter: Writer
    {
        private string fileType = "XML";
        private LoggerSingleton logger;

        public XmlWriter()
        {
            logger = LoggerSingleton.getInstance();
        }

        public override void write(string data)
        {
            logger.addData(fileType + ": Reading file - " + data);
        }
    }
}
