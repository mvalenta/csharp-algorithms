using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpAlgorithms.DataStructures.tree
{
    public class BinaryTreeNode
    {
        public BinaryTreeNode Left { get; set; }
        public BinaryTreeNode Right { get; set; }
        public BinaryTreeNode Parent { get; set; }
        public int? Value { get; set; }

        public BinaryTreeNode(int? value = null, BinaryTreeNode parent = null)
        {
            Left = null;
            Right = null;
            Parent = parent;
            Value = value;
        }

        public int LeftHeight()
        {
            if (Left == null)
            {
                return 0;
            }

            return Left.Height() + 1;
        }

        public int RightHeight()
        {
            if (Right == null)
            {
                return 0;
            }

            return Right.Height() + 1;
        }

        public int Height()
        {
            return Math.Max(LeftHeight(), RightHeight());
        }

        public int BalanceFactor()
        {
            return LeftHeight() - RightHeight();
        }

        public BinaryTreeNode SetLeft(BinaryTreeNode node)
        {
            // Reset parent for left node since it is going to be detached.
            if (Left != null)
            {
                Left.Parent = null;
            }

            // Attach new node to the left.
            Left = node;

            // Make current node to be a parent for new left one.
            if (Left != null)
            {
                Left.Parent = this;
            }

            return this;
        }

        public BinaryTreeNode SetRight(BinaryTreeNode node)
        {
            // Reset parent for right node since it is going to be detached.
            if (Right != null)
            {
                Right.Parent = null;
            }

            // Attach new node to the right.
            Right = node;

            // Make current node to be a parent for new right one.
            if (Right != null)
            {
                Right.Parent = this;
            }

            return this;
        }

        public bool RemoveChild(BinaryTreeNode nodeToRemove)
        {
            if (Left != null && Left == nodeToRemove)
            {
                Left = null;
                return true;
            }

            if (Right != null && Right == nodeToRemove)
            {
                Right = null;
                return true;
            }

            return false;
        }

            public bool ReplaceChild(BinaryTreeNode nodeToReplace, BinaryTreeNode replacementNode)
            {
                if (nodeToReplace == null || replacementNode == null)
                {
                    return false;
                }

                if (Left != null && Left == nodeToReplace)
                {
                    Left = replacementNode;
                    return true;
                }

                if (Right != null && Right == nodeToReplace)
                {
                    Right = replacementNode;
                    return true;
                }

                return false;
            }

            public List<object> TraverseInOrder()
            {
                var traverse = new List<object>();

                // Add left node.
                if (Left != null)
                {
                    traverse.AddRange(Left.TraverseInOrder());
                }

                // Add root.
                traverse.Add(Value);

                // Add right node.
                if (Right != null)
                {
                    traverse.AddRange(Right.TraverseInOrder());
                }

                return traverse;
            }

            public override string ToString()
            {
                return string.Join(",", TraverseInOrder().Select(x => x.ToString()));
            }
        }
}
