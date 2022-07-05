using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Strategy.Demo2
{
    public class AES : IEncryptionAlgorithm
    {
        public string Encrypt(string text)
        {
            Console.WriteLine("Encrypting message using AES");
            return "encryptedText";
        }
    }
}
