using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinaryTree
{
    class Tree
    {
        private Node rootNode_;
        public Node RootNode
        {
            get
            {
                retutn rootNode_;
            }
            set
            {
                rootNode_ = value;
            }
        }
        
        
        public Tree()
        {
            rootNode_ = null;
        }
        
        public Node InsertNodeWithValue(int value)
        {
//          TODO
        }
        
        public void Print()
        {
//          TODO
        }
        
        private static void Main()
        {
            Tree tree = new Tree();
            tree.InsertNodeWithValue(1);
            tree.Print();
//          TODO OUTPUT: 1
        }
    }
}