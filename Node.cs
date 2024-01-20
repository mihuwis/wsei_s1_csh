using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newProject02
{
    internal class Node
    {
        public Node parent;

        List<Node> children = new List<Node>();

        public void addChild(Node child)
        {
            children.Add(child);

            child.parent = this;
            
        }

        public int countChildren()
        {
            return children.Count;
        }

        public int countAncestors()
        {
            int sum = 1;

           foreach (Node child in children)
            {
                sum += child.countAncestors();
            }
           return sum;
        }
    }
}
