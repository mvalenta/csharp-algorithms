using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAlgorithms.DataStructures.tree.binary_search_tree
{
    public class BinarySearchTreeNode : BinaryTreeNode
    {
        public BinarySearchTreeNode(int? value = null, BinaryTreeNode parent = null) : base(value, parent)
        {
        }


        public BinarySearchTreeNode Insert(int value)
        {
            if (Value == null)
            {
                Value = value;
                return this;
            }

            if (value < Value)
            {
                // Insert to the left.
                if (Left != null)
                {
                    ((BinarySearchTreeNode)Left).Insert(value);
                }
                else
                {
                    SetLeft(new BinarySearchTreeNode(value));
                }
            }
            else if (value > Value)
            {
                // Insert to the right.
                if (Right != null)
                {
                    ((BinarySearchTreeNode)Right).Insert(value);
                }
                else
                {
                    SetRight(new BinarySearchTreeNode(value));
                }
            }

            return this;
        }

        public BinarySearchTreeNode Find(int? value)
        {
            // Check the root.
            if (Value == value)
            {
                return this;
            }

            if (value < Value && Left != null)
            {
                // Check left nodes.
                return ((BinarySearchTreeNode)Left).Find(value);
            }
            else if (value > Value && Right != null)
            {
                // Check right nodes.
                return ((BinarySearchTreeNode)Right).Find(value);
            }

            return null;
        }

        public bool Contains(int value)
        {
            return Find(value) != null;
        }

        public void Remove(int value)
        {
            var nodeToRemove = Find(value);

            if (nodeToRemove == null)
            {
                throw new Exception("Item not found in the tree");
            }

            var parent = nodeToRemove.Parent;

            if (nodeToRemove.Left == null && nodeToRemove.Right == null)
            {
                // Node is a leaf and thus has no children.
                // Just remove the pointer to this node from the parent node.
                parent.RemoveChild(nodeToRemove);
            }
            else if (nodeToRemove.Left != null && nodeToRemove.Right != null)
            {
                // Node has two children.
                // Find the next biggest value (minimum value in the right branch)
                // and replace current value node with that next biggest value.
                var nextBiggerNode = ((BinarySearchTreeNode)nodeToRemove.Right).FindMin();
                if (nextBiggerNode != nodeToRemove.Right)
                {
                    if(nextBiggerNode.Value.HasValue)
                        Remove(nextBiggerNode.Value.Value); //Get value of int? property value
                    nodeToRemove.Value = nextBiggerNode.Value;
                }
                else
                {
                    // In case if next right value is the next bigger one and it doesn't have left child
                    // then just replace node that is going to be deleted with the right node.
                    nodeToRemove.Value = nodeToRemove.Right.Value;
                    nodeToRemove.Right = nodeToRemove.Right.Right;
                }
            }
            else
            {
                // Node has only one child.
                // Make this child to be a direct child of current node's parent.
                if (nodeToRemove.Left != null)
                {
                    parent.ReplaceChild(nodeToRemove, nodeToRemove.Left);
                }
                else
                {
                    parent.ReplaceChild(nodeToRemove, nodeToRemove.Right);
                }
            }
        }

        

        public BinarySearchTreeNode FindMin()
        {
            if (Left == null)
            {
                return this;
            }

            return ((BinarySearchTreeNode)Left).FindMin();
        }
    }
}
