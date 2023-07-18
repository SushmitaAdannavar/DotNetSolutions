using System;

namespace Data_structures
{
    internal class Program
    {
        static void Main(string[] args)
        {
             LinkedList linkedlist = new LinkedList();
             linkedlist.AddNodeAtFront(3);
            linkedlist.AddNodeAtFront(5);
           linkedlist.AddNodeAtLast(10);
           linkedlist.AddNodeAtFront(12);
            linkedlist.AddNodeAtLast(17);
            linkedlist.AddNodeAtPosition(2, 78);
            linkedlist.AddNodeAtPosition(1, 32);
             linkedlist.DeleteAtfirst();
             linkedlist.DeleteAtLast();
             linkedlist.DeleteAtPos(3);
            /*stack Stack = new stack();
            Stack.push(3);
            Stack.push(5);
            Stack.push(7);
            Stack.push(9);
            Stack.push(12);
            Stack.display();
            Stack.pop();
                Stack.display();*/



        }
    }
}
