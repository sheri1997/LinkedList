using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Linked linked = new Linked();//object of the linked class
            linked.Add(56);//this will be added first.
            linked.Add(30);//this will be added second.
            linked.Add(70);//this will be added third.
            linked.Display();//this will display.
        }
    }
}

