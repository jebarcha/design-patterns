using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Singleton.Demo2
{
    public class MyLogger
    {
        private string _fileName;
        private static Dictionary<string, MyLogger> _instances = new Dictionary<string, MyLogger>();
        private MyLogger(string fileName)
        {
            this._fileName = fileName;
        }
        public void Write(string message)
        {
            Console.WriteLine("Writing a message to the log.");
        }
        public static MyLogger GetInstance(String fileName)
        {
            if (!_instances.ContainsKey(fileName)) 
            {
                _instances.Add(fileName, new MyLogger(fileName));
            }
            return _instances[fileName];
        }
    }
}
