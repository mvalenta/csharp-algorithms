using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAlgorithms.DataStructures.tree.binary_search_tree
{
    public class BinarySearchTree
    {
        public BinarySearchTreeNode Root { get; set; }

        public BinarySearchTree()
        {
            Root = new BinarySearchTreeNode();
        }

        public void Insert(int value)
        {
            Root.Insert(value);
        }

        public bool Contains(int value)
        {
            return Root.Contains(value);
        }

        public void Remove(int value)
        {
            Root.Remove(value);
        }

        public override string ToString()
        {
            return Root.ToString();
        }
    }
}
