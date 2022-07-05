using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Strategy.Demo2 
{
    public class ChatClient
    {
        private IEncryptionAlgorithm _encryptionAlgorithm;

        public ChatClient(IEncryptionAlgorithm encryptionAlgorithm)
        {
            _encryptionAlgorithm = encryptionAlgorithm;
        }

        public void send(string message)
        {
            string result = _encryptionAlgorithm.Encrypt(message);

            Console.WriteLine("Sending the encrypted message..." + result);
        }
    }
}
