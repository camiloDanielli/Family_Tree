using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Library
{
    public abstract class Node
    {
        private List<Node> children = new List<Node>();

        public ReadOnlyCollection<Node> Children {
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public void AddChildren(Node n)
        {
            this.children.Add(n);
        }

        public abstract void Accept(Ivisitor visitor);
    }
}