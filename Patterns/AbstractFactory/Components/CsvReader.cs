using Pattern_Test.Patterns.AbstractFactory.AbstractComponents;
using Pattern_Test.Patterns.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Test.Patterns.AbstractFactory.Components
{
    public class CsvReader: Reader
    {
        private string fileType = "CSV"; 
        private LoggerSingleton logger;

        public CsvReader()
        {
          logger  = LoggerSingleton.getInstance();
        }

        public override void read(string data)
        {
            logger.addData(fileType + ": Reading file - " + data);
        }
    }
}