using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Test.Patterns
{
    public class ReaderSingleton
    {
        public static ReaderSingleton instance;
        private List<string> dataList = [];
        private int count = 0;

        private ReaderSingleton() { }

        public static ReaderSingleton getInstance() { 
            if(instance == null)
            {
                instance = new ReaderSingleton();
            }  
            return instance; 
        }

        public void addData(string data)
        {
            this.dataList.Add(data);
        }

        public void showAll()
        {
            foreach(string s in dataList)
            {
                Console.WriteLine(s);
            }
        }
    }
}
