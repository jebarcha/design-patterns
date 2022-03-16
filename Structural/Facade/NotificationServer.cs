using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Facade
{
    public class NotificationServer
    {
        //STEPS:
        // connect() -> Connection
        // authenticate(appID, key) -> AuthToken
        // send(authToken, message, target)
        // conn.Disconnect()

        public Connection Connect(string ipAddress)
        {
            return new Connection();
        }
        public AuthToken Authenticate(string appID, string key)
        {
            return new AuthToken();
        }
        public void Send(AuthToken authToken, Message message, string target)
        {
            Console.WriteLine("Sending a message");
        }
    }
}
