using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Command.Example3_UndoableOperations
{
    public class HtmlDocument
    {
        private string _content;
        public void MakeBold()
        {
            Content = $"<b>{_content}</b>";
        }

        public string Content { get => _content; set => _content = value; }

    }
}
