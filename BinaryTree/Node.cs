using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinaryTree
{
    public class Node
    {
        public Node left;
        public Node right;
        public int value;

        public Node(int initial)
        {
            value = initial;
            left = null;
            right = null;
        }
    }
}
