using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAlgorithms.DataStructures.queue
{
    public class Queue
    {
        public linked_list.LinkedList list { get; set; }
        public Queue()
        {
            list = new linked_list.LinkedList();
        }

        public bool IsEmpty()
        {
            return list.Tail == null;
        }

        public object Peek()
        {
            if(list.Head == null){
                return null;
            }
            return list.Head.Item;
        }
        public void Enqueue(object item)
        {
            list.Append(item);
        }
        public object Dequeue()
        {
            var removedHead = list.DeleteHead();
            if(removedHead == null)
            {
                return null;
            }
            return removedHead.Item;
        }
        public override string ToString() 
        {
            return list.ToString();    
        }
    }
}
