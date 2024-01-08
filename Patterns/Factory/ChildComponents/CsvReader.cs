using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pattern_Test.Patterns.Singleton;

namespace Pattern_Test.Patterns.Factory.ChildComponents
{
    public class CsvReader: FactoryComponent {
        private string readerName = "CSV";
        public ReaderSingleton reader;
        public CsvReader() 
        { 
            reader = ReaderSingleton.getInstance();
        }
        public override void addMessage(string message)
        {
            string totalMessage = "Message from " + readerName + " is: " + message;
            reader.addData(totalMessage);
        }
    }
}
