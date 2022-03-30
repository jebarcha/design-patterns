using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Singleton
{
    public class ConfigManager
    {
        private Dictionary<string, object> settings = new Dictionary<string, object>();
        private static ConfigManager instance = new ConfigManager();
        private ConfigManager()
        {
        }
        public static ConfigManager GetInstance()
        {
            return instance;
        }

        public void Set(string key, object value)
        {
            settings.Add(key, value);
        }
        public Object? Get(string key)
        {
            return settings.ContainsKey(key) ? settings[key] :null;
        }

    }
}
