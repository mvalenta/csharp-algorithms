using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAlgorithms.DataStructures.stack
{
    public class Stack
    {
        public linked_list.LinkedList list { get; set; }

        public Stack()
        {
            list = new linked_list.LinkedList();
        }

        public bool IsEmpty()
        {
            return list.Tail == null;
        }

        public object Peek()
        {
            if(list.Tail == null){
                return null;
            }
            return list.Tail.Item;
        }
        public void Push(object item)
        {
            list.Append(item);
        }
        public object Pop()
        {
            var removedTail = list.DeleteTail();
            if(removedTail == null)
            {
                return null;
            }
            return removedTail.Item;
        }
        public object[] ToArray()
        {
            var reversedList = list.ToList();
            reversedList.Reverse();
            return reversedList.ToArray();
        }
        public override string ToString() 
        {
            return list.ToString();    
        }

    }
}
