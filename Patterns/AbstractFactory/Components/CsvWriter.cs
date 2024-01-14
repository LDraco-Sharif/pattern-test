using Microsoft.VisualBasic.FileIO;
using Pattern_Test.Patterns.AbstractFactory.AbstractComponents;
using Pattern_Test.Patterns.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Test.Patterns.AbstractFactory.Components
{
    public class CsvWriter: Writer
    {
        private string fileType = "CSV";
        private LoggerSingleton logger;

        public CsvWriter()
        {
            logger = LoggerSingleton.getInstance();
        }

        public override void write(string data)
        {
            logger.addData(fileType + ": Writing file - " + data);
        }
    }
}
