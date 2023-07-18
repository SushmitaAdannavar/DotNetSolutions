using System;
using System.Collections.Generic;
using System.Text;

namespace Data_structures
{
    public class Node1
    {
        public int Data;
        public Node1 Next;
        public Node1(int data)
        {
            Data=data;
            //Next = null;
        }
    }
    public class stack
    {
        public Node1 top;
        public void push(int data)
        {
            Node1 node = new Node1(data);
            node.Next = top;
            top = node;

        }
        public void pop()
        {
            int data = top.Data;
            top = top.Next;
            Console.WriteLine("popped " + data);
        }
        public void display()
        {
            // Console.WriteLine(top.Data);
            //Node node = head;
            Node1 stop=top;
            while (stop != null)
            {
                Console.WriteLine(stop.Data + "");
                stop = stop.Next;
            }
        }
    }
}
