using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Visitor
{
    public class HtmlDocument
    {
        private List<IHtmlNode> _nodes = new List<IHtmlNode>();

        public void Add(IHtmlNode node)
        {
            _nodes.Add(node);
        }

        public void Execute(IOperation operation)
        {
            foreach (var node in _nodes)
            {
                node.Execute(operation);
            }
        }
        
    }
}
