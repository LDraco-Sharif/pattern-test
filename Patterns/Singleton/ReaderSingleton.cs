using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Test.Patterns.Singleton
{
    public class LoggerSingleton
    {
        private static LoggerSingleton instance;
        private List<string> dataList = [];
        private int count = 0;

        private LoggerSingleton() { }

        public static LoggerSingleton getInstance()
        {
            if (instance == null)
            {
                instance = new LoggerSingleton();
            }
            return instance;
        }

        public void addData(string data)
        {
            dataList.Add(data);
        }

        public void showAll()
        {
            foreach (string s in dataList)
            {
                Console.WriteLine(s);
            }
        }
    }
}
