using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Mediator.Demo2
{
    public class TextBox : UIControl
    {
        private string _content;
        public string GetContent()
        {
            return _content;
        }

        public void SetContent(string content)
        {
            this._content = content;
            NotifyEventHandlers();
        }

        public bool IsEmpty()
        {
            return string.IsNullOrEmpty(_content);
        }
    }
}
