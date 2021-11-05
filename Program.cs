using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Linked linked = new Linked();//object of the linked class
            linked.Add(56);//this will be added first.
            linked.Add(70);//this will be added third.
            linked.insertBetween(2, 30);//this will add 30 in the 2 position.
            linked.popLast();//this will remove 70 from the linked list.
            linked.Display();//this will display.

        }
    }
}

