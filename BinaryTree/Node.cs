using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinaryTree
{
    public class Node
    {
        private int value_;
        public int Value
        {
            get
            {
                return value_;
            }
            set {
                value_ = value;
            }
        }
        
        private Node leftNode_;
        public Node LeftNode
        {
            get
            {
                return leftNode_;
            }
            set
            {
                leftNode_ = value;
            }
        }
        
        private Node rightNode_;
        public Node RightNode
        {
            get
            {
                return rightNode_;
            }
            set
            {
                rightNode_ = value;
            }
        }
        
        public Node(int value) {
            value_ = value;
            leftNode_ = null;
            rightNode_ = null;
        }
        
        public void Print()
        {
//            TODO
        }
        
        public static void Main()
        {
            Node node = new Node(4);
            node.Print();
//          TODO OUTPUT: 4
        }
    }
}
