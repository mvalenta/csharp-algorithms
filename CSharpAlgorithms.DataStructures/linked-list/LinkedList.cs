using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpAlgorithms.DataStructures.linked_list
{
    public class LinkedList
    {
        #region classdef
        public LinkedListNode Head { get; set; }
        public LinkedListNode Tail { get; set; }
        public LinkedList()
        {

        }
        #endregion

        #region Methods
        /// <summary>
        /// Make new node to be the head
        /// </summary>
        /// <param name="item"></param>
        /// <returns>The new LinkedList</returns>
        public LinkedList Prepend(object item)
        {
            var newNode = new LinkedListNode() { Item = item, Next = Head };
            Head = newNode;

            return this;
        }

        /// <summary>
        /// Add node to end of linked list or set to head if no head exists
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public LinkedList Append(object item)
        {
            var newNode = new LinkedListNode() { Item = item };

            if (Head == null)
            {
                Head = newNode;
                Tail = newNode;
                return this;
            }

            //Attach new node to end
            Tail.Next = newNode;
            Tail = newNode;
            return this;
        }
        /// <summary>
        /// Delete a node based on the object
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public LinkedListNode Delete(object item)
        {
            if(Head == null)
                return null;

            LinkedListNode temp = Head;
            LinkedListNode prev = null;

            // If head node itself holds the item to be deleted
            //TODO: Fix comparison of object
            if (temp != null && temp.Item == item)
            {
                Head = temp.Next; // Changed head
                return temp;
            }

            // Search for the object to be deleted, keep track of the
            // previous node as we need to change temp.next
            while (temp != null && temp.Item != item)
            {
                prev = temp;
                temp = temp.Next;
            }

            if (temp == null) return null; //object not found

            prev.Next = temp.Next;
            return temp;

        }
        /// <summary>
        /// Find a node based on item
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public LinkedListNode Find(object item)
        {
            if(Head == null)
                return null;
            LinkedListNode temp = Head;
            while(temp != null)
            {
                if(temp.Item == item)
                {
                    return temp;
                }
                temp = temp.Next;
            }
            return null;
        }
        /// <summary>
        /// Delete the tail node
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public LinkedListNode DeleteTail(LinkedListNode node)
        {
            var temp = Tail;
            if (Head == Tail)
            {
                Head = null;
                Tail = null;

                return temp;
            }

            var currentNode = Head;
            while (currentNode.Next != null)
            {
                if (currentNode.Next.Next == null)
                {
                    currentNode.Next = null;
                }
                else
                {
                    currentNode = currentNode.Next;
                }
                Tail = currentNode;
                return temp;
            }

            return null;
        }
        /// <summary>
        /// Delete the head node
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public LinkedListNode DeleteHead(LinkedListNode node)
        {
            if (Head == Tail)
                return null;

            LinkedListNode temp = Head;
            if (temp.Next != null)
            {
                Head = temp.Next;
            }
            else
            {
                Head = null;
                Tail = null;
            }
            return temp;
        }
        public LinkedListNode[] ToArray()
        {
            return ToList().ToArray();
        }
        public List<LinkedListNode> ToList()
        {
            var list = new List<LinkedListNode>();
            var temp = Head;
            while (temp != null)
            {
                list.Add(temp);
                temp = temp.Next;
            }
            return list;
        }
        public override string ToString()
        {
            return string.Join("->", ToList().Select(x => x.Item.ToString()).ToArray());
        }
        #endregion
    }
}
