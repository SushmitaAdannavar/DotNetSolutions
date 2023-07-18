using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Data_structures
{
    class Node
    {
        public int Data;
        public Node Next;
        public Node(int data)
        {
            Data=data;
            Next = null;
        }
    }
    public class LinkedList
    {
        Node head;
        int count=0;
        public void AddNodeAtFront(int Data)
        {
            if (head==null)
            {

                Node node = new Node(Data);
                head = node;
                count++;
            }
            else
            {
                Node node = new Node(Data);
                node.Next = head;
                head = node;
                count++;
            }
            display();
            
        }
        public void AddNodeAtLast(int Data)
        {
            Node node1 = head;
            Node node = new Node(Data);
            while(node1.Next!=null)
            {
                node1 = node1.Next;
            }
            node1.Next = node;
            count++;
            display();
        }
        public void AddNodeAtPosition(int pos,int Data)
        {
            int nodecount = 1;
            Node temp = head;
            if (pos == 1)
            {
                AddNodeAtFront(Data);
            }
            else
            {
                Node node2 = new Node(Data);
                while (temp != null)
                {
                    if (nodecount == pos - 1)
                    {
                        node2.Next = temp.Next;
                        temp.Next = node2;
                        break;

                    }
                    temp = temp.Next;
                    nodecount++;
                }
                display();
            }
            
        }
        public void display()
        {
            Node node = head;
            while(node!=null)
            {
                Console.Write(node.Data+"->");
                node = node.Next;
            }
            Console.WriteLine();
        }
        public void DeleteAtfirst()
        {
            
            Console.WriteLine("Deleted first node" + head.Data);
            Node temp = head;
            head = head.Next;
            temp = null;
            display();
        }
        public void DeleteAtLast()
        { 
            Node temp = head;
           Node prevnode=null;
           
          while(temp.Next!=null)
            {
               prevnode= temp;
                temp=temp.Next;
               
            }

            Console.WriteLine("Deleted last node" + temp.Data);
           
            prevnode.Next = null;
            temp = null;
            display();
        }
        public void DeleteAtPos(int pos)
        {
            Node temp = head;
            Node prevNode = null;
            int nodecount=1;
            while (temp.Next != null && nodecount!=pos)
            {
                prevNode = temp;
                temp = temp.Next;
                nodecount++;
            }
            if(nodecount==pos)
            {
                prevNode.Next = temp.Next;
                Console.WriteLine("Deleted value " + temp.Data);
                temp = null;
                display();
            }
                
            

        }
    }
}
