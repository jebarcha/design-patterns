using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    public class HttpRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public HttpRequest(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
