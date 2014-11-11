using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinaryTree
{
    class Tree
    {
        Node root;

        public Tree() 
        {
            root = null;
        }

        public Tree(int initial)
        {
            root = new Node(initial);
        }

        public void AddElement(int value)
        {
            if (root == null)
                root = new Node(value);
        }
    }
}
