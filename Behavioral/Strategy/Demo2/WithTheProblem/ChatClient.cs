using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Strategy.Demo2.WithTheProblem
{
    public class ChatClient
    {
        private string _encryptionAlgorithm;

        public ChatClient(string encryptionAlgorithm)
        {
            _encryptionAlgorithm = encryptionAlgorithm;
        }

        public void send(string message)
        {
            if (_encryptionAlgorithm == "DES")
                Console.WriteLine("Encrypting message using DES");
            else if (_encryptionAlgorithm == "AES")
                Console.WriteLine("Encrypting message using AES");
            else
                throw new InvalidOperationException("Unsupported encryption algorithm");

            Console.WriteLine("Sending the encrypted message...");
        }
    }
}
