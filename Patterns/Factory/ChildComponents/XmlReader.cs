using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pattern_Test.Patterns.Singleton;

namespace Pattern_Test.Patterns.Factory.ChildComponents
{
    internal class XmlReader : FactoryComponent
    {
        private string readerName = "XML";
        public LoggerSingleton reader;
        public XmlReader()
        {
            reader = LoggerSingleton.getInstance();
        }
        public override void addMessage(string message)
        {
            string totalMessage = "Message from " + readerName + " is: " + message;
            reader.addData(totalMessage);
        }
    }
}

