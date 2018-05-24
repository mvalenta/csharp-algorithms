using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAlgorithms.DataStructures.linked_list
{
    public class LinkedListNode
    {
        public LinkedListNode()
        {
            
        }
        public LinkedListNode(object item)
        {
            Item = item;
        }
        public object Item { get; set; }
        public LinkedListNode Next { get; set; }
    }
}
